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
    public partial class InserirSuspeitos : Form
    {
        public InserirSuspeitos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InserirSuspeitos inserirSuspeitos = new();
            inserirSuspeitos.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new();
            f1.Show();
            this.Hide();
        }
    }
}
