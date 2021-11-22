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
    public partial class Suspetcs : Form
    {
        public Suspetcs()
        {
            InitializeComponent();
        }
        public Suspetcs(string idequipa):this()
        {
            TxIdInf.Text = idequipa;
        }

        private void BtnInsereSuspeito_Click(object sender, EventArgs e)
        {
            WCFClient.ClientClient client = new();
            WCFClient.Suspeito suspeito = new();
           
            suspeito.Firstname = firstNameSuspeito.Text;
            suspeito.Laststname = lastNameSuspeito.Text;
            //suspeito.Idinfectado = TxIdInf.Text;
            client.IndicateSuspectAsync(TxIdInf.Text, suspeito);
            firstNameSuspeito.Text = "";
            lastNameSuspeito.Text = "";

        }
    }
}
