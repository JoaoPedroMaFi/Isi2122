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

        private void button1_Click(object sender, EventArgs e)
        {
            WCFClient.ClientClient client = new();
            List<WCFClient.Infectado> list = new();
            list = client.GetAllInfectedAsync().Result;
            ListViewInfectados.Items.Clear();
            //MessageBox.Show(isolados.ToString());
            foreach (WCFClient.Infectado inf in list)
            {
                string[] row = {
                 inf.Idpessoa.ToString(),
                 inf.Firstname,
                 inf.Laststname,
                 inf.Idequipa.ToString()
                };


                ListViewItem item = new ListViewItem(row);

                ListViewInfectados.Items.Add(item);
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
