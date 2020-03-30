using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using LNetwork;

namespace LnetGenieClient
{
    public partial class LnetGenieClient : Form
    {
        private LNetwork.LNetwork lnet;
        public LnetGenieClient()
        {
            InitializeComponent();

            lnet = new LNetwork.LNetwork();
        }

        private void testBtn_click(object sender, EventArgs e)
        {
            lnet.Test();
        }
    }
}
