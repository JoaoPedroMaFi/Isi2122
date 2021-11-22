using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCFSoapClientSide.Models;

namespace WCFSoapClientSide
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WCFClient.ClientClient client = new();
            WCFClient.Equipa equipa = new();
            equipa.Nome = nomeEquipa.Text;
            equipa.Idequipa = Int32.Parse(idEquipaLabel.Text);
            WCFClient.Infectado infectado = new();
            infectado.Firstname = firstNameInfetado.Text;
            infectado.Laststname = lastNameInfetado.Text;
            infectado.Idequipa = Int32.Parse(idEquipaLabel.Text);
            client.IndicateInfetionAsync(equipa, infectado);

        }

        private void ButtonAllInfecteds_Click(object sender, EventArgs e)
        {
            Infecteds newform = new();
            newform.ShowDialog();
            this.Hide();

        }

        private void BtnInsertListSuspects_Click(object sender, EventArgs e)
        {
            Suspetcs newformSus = new(idInfetado.Text);
            newformSus.ShowDialog();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
