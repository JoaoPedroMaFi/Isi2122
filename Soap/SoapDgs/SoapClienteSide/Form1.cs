using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoapClienteSide
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //InsertNewInfected();
            InserirSuspeitos inserirSuspeitos = new();
            inserirSuspeitos.Show();
            this.Hide();
        }

        private void idEquipa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
