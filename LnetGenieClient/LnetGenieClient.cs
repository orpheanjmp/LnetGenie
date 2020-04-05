using System;
using System.Windows.Forms;
using LNetwork;

namespace LnetGenieClient
{
    public partial class LnetGenieClient : Form
    {
        private readonly Lnet _lnet;
        private delegate void AddLineHandler(LNetwork.Message message);

        private delegate void ToggleHandler();

        public LnetGenieClient()
        {
            InitializeComponent();

            _lnet = new Lnet();
            _lnet.MessageReceived += _lnet_MessageReceived;
            _lnet.Connected += _lnet_Connected;
            _lnet.Disconnected += _lnet_Disconnected;
        }

        private void _lnet_Disconnected(object source, EventArgs args)
        {
           HandleToggle(true);
        }

        private void _lnet_Connected(object source, EventArgs args)
        {
           HandleToggle(false);
        }

        private void _lnet_MessageReceived(object source, MessageEventArgs args)
        {
            AddLine(args.Message);
        }

        private void HandleToggle(bool connected)
        {
            if (connectBtn.InvokeRequired || btnDisconnect.InvokeRequired)
            {
                ToggleHandler handler;

                if (connected)
                {
                    handler = ToggleConnected;
                }
                else
                {
                    handler = ToggleDisconnected;
                }

                var toggle = new ToggleHandler(handler);
                connectBtn.Invoke(toggle);
                btnDisconnect.Invoke(toggle);
            }
            else
            {
                connectBtn.Enabled = connected;
                btnDisconnect.Enabled = !connected;
            }
        }

        private void ToggleConnected()
        {
            connectBtn.Enabled = true;
            btnDisconnect.Enabled = false;
        }

        private void ToggleDisconnected()
        {
            connectBtn.Enabled = false;
            btnDisconnect.Enabled = true;
        }

        private void AddLine(LNetwork.Message message)
        {
            if (outputFld.InvokeRequired)
            {
                var addLine = new AddLineHandler(AddLine);
                outputFld.Invoke(addLine, message);
            }
            else
            {
                string line;

                if (message.Type == "server" || message.Type == "greeting")
                {
                    line = message.Text;
                }
                else
                {
                    line = $"[{message.Channel}]-{message.From}: {message.Text}";
                }

                outputFld.AppendText(line);

                if (!message.Text.EndsWith(Environment.NewLine))
                {
                    outputFld.AppendText(Environment.NewLine);
                }
            }
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            _lnet.Connect();
            _lnet.Login(fldName.Text, fldGame.Text, fldPassword.Text);
            _lnet.Tune("lnetgenie");
            _lnet.Tune("DRPrime");
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            _lnet.Disconnect();
        }

        private void privateCheck_CheckedChanged(object sender, EventArgs e)
        {
            privateFld.Visible = privateCheck.Checked;
        }

        private void sendbtn_Click(object sender, EventArgs e)
        {
            _lnet.Send("channel", fldChannel.Text, inputFld.Text);
        }
    }
}