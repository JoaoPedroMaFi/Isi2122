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
            ListViewSuspeitos.Items.Clear();
            //MessageBox.Show(isolados.ToString());
            foreach (WCFClient.Suspeito sus in list)
            {
                string[] row = {
                 sus.Firstname,
                 sus.Laststname,
   
                };


                ListViewItem item = new ListViewItem(row);

                ListViewSuspeitos.Items.Add(item);
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Form1 form = new();
            form.Show();
            this.Close();

        }
    }
}
