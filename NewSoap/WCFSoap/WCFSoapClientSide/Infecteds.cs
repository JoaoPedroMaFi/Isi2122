using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WCFSoapClientSide
{
    public partial class Infecteds : Form
    {
        public Infecteds()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            WCFClient.ClientClient client = new();
            List<WCFClient.Infectado> list = new();
            client.GetAllInfectedAsync();
           
        }
    }
}
