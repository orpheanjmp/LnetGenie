using System;
using System.Windows.Forms;
using LNetwork;

namespace LnetGenieClient
{
    public partial class LnetGenieClient : Form
    {
        private readonly Lnet _lnet;
        private delegate void AddLineHandler(LNetwork.Message message);

        public LnetGenieClient()
        {
            InitializeComponent();

            _lnet = new Lnet();
            _lnet.MessageReceived += _lnet_MessageReceived;
        }

        private void _lnet_MessageReceived(object source, MessageEventArgs args)
        {
            AddLine(args.Message);
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

        private void testBtn_click(object sender, EventArgs e)
        {
            _lnet.Test();
        }
    }
}