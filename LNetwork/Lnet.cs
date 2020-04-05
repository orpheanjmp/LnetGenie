using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml.Linq;

namespace LNetwork
{
    internal class LnetContext
    {
        public byte[] Buffer;
        public SslStream Stream;
    }

    public sealed class Lnet
    {
        public delegate void MessageReceivedHandler(object source, MessageEventArgs args);

        public delegate void ConnectedHandler(object source, EventArgs args);

        public delegate void DisconnectedHandler(object source, EventArgs args);

        public event MessageReceivedHandler MessageReceived;
        public event ConnectedHandler Connected;
        public event DisconnectedHandler Disconnected;

        private const string Host = "lnet.lichproject.org";
        private const int Port = 7155;

        private const string Pem =
            "-----BEGIN CERTIFICATE-----\nMIIDlTCCAn2gAwIBAgIJAKuu65i5NsruMA0GCSqGSIb3DQEBCwUAMGExCzAJBgNV\nBAYTAlVTMREwDwYDVQQIDAhJbGxpbm9pczESMBAGA1UECgwJTWF0dCBMb3dlMQ8w\nDQYDVQQDDAZSb290Q0ExGjAYBgkqhkiG9w0BCQEWC21hdHRAaW80LnVzMB4XDTE0\nMDYwNzE3NDUwMFoXDTI0MDYwNDE3NDUwMFowYTELMAkGA1UEBhMCVVMxETAPBgNV\nBAgMCElsbGlub2lzMRIwEAYDVQQKDAlNYXR0IExvd2UxDzANBgNVBAMMBlJvb3RD\nQTEaMBgGCSqGSIb3DQEJARYLbWF0dEBpbzQudXMwggEiMA0GCSqGSIb3DQEBAQUA\nA4IBDwAwggEKAoIBAQCcIRn0IMCNYeL5agKmkdedgJXsIyTJS8qKrY6EvQsq4tt0\nmO3Or9K8IaDl7qFdQ9nfSJ5phNgoCy9wZ9rDWv5FhY5MnnVHGr3fCa7RkMxJFR/N\nwiD4ihQlixOUly76glceyc/6QQS9bNe96evZDstERGAFfzgHY4qAlyurR6mBu9Mb\nyyCRok6xMRnjrbTMNkvvOsuG0sY9ot+SLHGgU3qT7+wVh/CbWcjeF7/Qwa//fbFk\nmq5c1FuvhU3DanSSz+VuWudPFSyZ3r5pYrLMJWsyomDa4gkL2bJ5jya2BWDMXvSS\nCpdQgPDIlClMfAFLd/Ss8ZIGa6uNFcSK6Xca51ClAgMBAAGjUDBOMB0GA1UdDgQW\nBBScbglRiGzz9yzuhgBwFYjgimeByDAfBgNVHSMEGDAWgBScbglRiGzz9yzuhgBw\nFYjgimeByDAMBgNVHRMEBTADAQH/MA0GCSqGSIb3DQEBCwUAA4IBAQA7MLZYfqam\n5aaSBqQpT6sOGDtVc9koIok59oTQmNXqe+awg2VUnAiesxtLd+FWGUMp8XzHdGWw\nH3O6kAUkPm/in001X7TRAhbgDujfTRbTzxND0XrjuEzDMALs3YpDM1pMXqC7RXWA\n7z+N0gRaUgmh1rMbk/qA3cAfC2dwf2j3NYy3bDw3lMpdyIwAfOQxiZVglYgX3dgT\nU9b//gsUyPCvlpL0mYcmhOOLt6oqQhMJaw1I6A9xMe2kO2L+8KPGK2u1B+P5/Sx0\nFE8LIp5KA3a7yRbOty19NsGR+yW7WwV7BL6c6GOKb/iKJBLYzTmNG6m16hRrxDGj\ntGu91I0ORptB\n-----END CERTIFICATE-----";

        private readonly LnetContext _context = new LnetContext();

        private TcpClient _client;

        public Lnet()
        {
            var cert = new X509Certificate2();
            cert.Import(Encoding.ASCII.GetBytes(Pem));

            var store = new X509Store("lnetgenie");
            store.Open(OpenFlags.MaxAllowed);
            store.Add(cert);
            store.Close();

            _context.Buffer = new byte[32768];
        }

        private void GetMessage(IAsyncResult result)
        {
            try
            {
                var context = (LnetContext) result.AsyncState;
                var messageData = new StringBuilder();
                var size = context.Stream.EndRead(result);

                var decoder = Encoding.UTF8.GetDecoder();
                var chars = new char[decoder.GetCharCount(context.Buffer, 0, size)];
                decoder.GetChars(context.Buffer, 0, size, chars, 0);
                messageData.Append(chars);

                var message = messageData.ToString();

                Console.WriteLine(message);

                var data = XDocument.Parse("<root>" + message + "</root>");

                var nodes =
                    from el in data.Root?.Elements()
                    select el;

                foreach (var element in nodes)
                    switch (element.Name.ToString())
                    {
                        case "ping":
                            Pong();
                            break;

                        case "message":
                        {
                            switch (element.FirstAttribute.Value)
                            {
                                case "greeting":
                                    OnMessageReceived(new Message
                                        {Type = "greeting", Text = element.Value, Channel = "Lnet", From = ""});
                                    break;
                                case "server":
                                    OnMessageReceived(new Message
                                        {Type = "server", Text = element.Value, Channel = "Lnet", From = ""});
                                    break;

                                default:
                                {
                                    var attributes = new Dictionary<string, string>();

                                    foreach (var attribute in element.Attributes())
                                        attributes[attribute.Name.ToString()] = attribute.Value;

                                    switch (attributes["type"])
                                    {
                                        case "private":
                                            OnMessageReceived(new Message
                                            {
                                                Type = attributes["type"], From = attributes["from"],
                                                Channel = "private",
                                                Text = element.Value
                                            });
                                            break;

                                        case "channel":
                                            OnMessageReceived(new Message
                                            {
                                                Type = attributes["type"], From = attributes["from"],
                                                Channel = attributes["channel"], Text = element.Value
                                            });
                                            break;

                                        default:
                                            OnMessageReceived(new Message
                                                {Type = "unknown", From = "", Channel = "", Text = element.Value});
                                            break;
                                    }

                                    break;
                                }
                            }
                        }
                            break;

                        default:
                            Console.WriteLine(element.Name.ToString());
                            break;
                    }

                _context.Stream.BeginRead(_context.Buffer, 0, _context.Buffer.Length, GetMessage, _context);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void OnMessageReceived(Message message)
        {
            MessageReceived?.Invoke(this, new MessageEventArgs {Message = message});
        }

        private void OnConnected()
        {
            Connected?.Invoke(this, EventArgs.Empty);
        }

        private void OnDisconnected()
        {
            Disconnected?.Invoke(this, EventArgs.Empty);
        }

        public void Connect()
        {
            _client = new TcpClient(Host, Port);
            Console.WriteLine("Connected to Lnet");

            _context.Stream = new SslStream(
                _client.GetStream(),
                false,
                ValidateServerCertificate,
                null);

            try
            {
                _context.Stream.AuthenticateAsClient(Host);
                OnConnected();
                _context.Stream.BeginRead(_context.Buffer, 0, _context.Buffer.Length, GetMessage, _context);
            }
            catch (AuthenticationException e)
            {
                Console.WriteLine("Exception: {0}", e.Message);
                if (e.InnerException != null) Console.WriteLine("Inner exception: {0}", e.InnerException.Message);

                Console.WriteLine("Authentication failed - closing the connection.");
                Disconnect();
                OnDisconnected();
            }
        }

        public void Disconnect()
        {
            if (!_client.Connected) return;
            _client.Close();
            Console.WriteLine("Disconnected from Lnet");
            OnDisconnected();
        }

        private static bool ValidateServerCertificate(
            object sender,
            X509Certificate certificate,
            X509Chain chain,
            SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }

        public void Login(string name, string game, string password = "")
        {
            string login = $"<login name='{name}' game='{game}' client='1.6' lich='4.7'></login>";

            if (!_context.Stream.CanWrite) return;

            Console.WriteLine(login);
            _context.Stream.Write(Encoding.UTF8.GetBytes(login));
            _context.Stream.Flush();
        }

        private void Pong()
        {
            const string pong = "<pong/>";

            if (!_context.Stream.CanWrite) return;

            Console.WriteLine(pong);
            _context.Stream.Write(Encoding.UTF8.GetBytes(pong));
            _context.Stream.Flush();
        }

        public void Tune(string channel)
        {
            var tune = $"<tune channel='{channel}'></tune>";

            if (!_context.Stream.CanWrite) return;

            Console.WriteLine(tune);
            _context.Stream.Write(Encoding.UTF8.GetBytes(tune));
            _context.Stream.Flush();
        }

        public void Send(string method, string target, string message)
        {
            string msg;

            switch (method)
            {
                case "channel":
                    msg = $"<message type='channel' channel='{target}'>{message}</message>";
                    break;

                case "private":
                    msg = $"<message type='private' to='{target}'>{message}</message>";
                    break;

                default:
                    return;
            }

            if (!_context.Stream.CanWrite) return;

            Console.WriteLine(msg);
            _context.Stream.Write(Encoding.UTF8.GetBytes(msg));
            _context.Stream.Flush();
        }
    }

    public class MessageEventArgs : EventArgs
    {
        public Message Message { get; set; }
    }

    public class Message
    {
        public string Type { get; set; }
        public string From { get; set; }
        public string Channel { get; set; }
        public string Text { get; set; }
    }
}