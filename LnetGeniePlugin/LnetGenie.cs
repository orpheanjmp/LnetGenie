using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using GeniePlugin.Interfaces;
using LNetwork;

namespace LnetGeniePlugin
{
    class LnetGenie : IPlugin
    {
        public string Name => "LnetGenie";

        public string Version => "0.0.1";

        public string Description => "Connect to LNet without having Lich installed.";

        public string Author => "Orphean aka Neryndil <orpheanjmp@gmail.com> ";

        public bool Enabled { get; set; } = true;

        private Lnet _lnet = new Lnet();
        private IHost _host;

        public void Initialize(IHost Host)
        {
            _host = Host;
        }


        public void ParentClosing()
        {
            throw new NotImplementedException();
        }

        public string ParseInput(string Text)
        {
            throw new NotImplementedException();
        }

        public string ParseText(string Text, string Window)
        {
            throw new NotImplementedException();
        }

        public void ParseXML(string XML)
        {
            throw new NotImplementedException();
        }

        public void Show()
        {
            throw new NotImplementedException();
        }

        public void VariableChanged(string Variable)
        {
            throw new NotImplementedException();
        }
    }
}
