using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using GeniePlugin.Interfaces;

namespace LnetGeniePlugin
{
    class LnetGenie : IPlugin
    {
        private bool _enabled = true;

        public string Name
        {
            get { return "LnetGenie"; }
        }

        public string Version
        {
            get { return "0.0.1"; }
        }

        public string Description
        {
            get { return "Connect to LNet without having Lich installed."; }
        }

        public string Author
        {
            get { return "Orphean aka Neryndil <orpheanjmp@gmail.com> "; }
        }

        public bool Enabled
        {
            get { return _enabled; }
            set { _enabled = value; }
        }


        public void Initialize(IHost Host)
        {
            throw new NotImplementedException();
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
