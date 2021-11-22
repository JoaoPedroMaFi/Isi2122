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
    public partial class SuspectsView : Form
    {
        public SuspectsView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WCFClient.ClientClient client = new();
            List<WCFClient.Suspeito> list = new();
            list = client.GetAllSuspectsAsync().Result;
            foreach (WCFClient.Suspeito sus in list)
            {
                RTBoxSus.Text += sus.Firstname + "\t" + sus.Laststname;
            }
        }
    }
}
