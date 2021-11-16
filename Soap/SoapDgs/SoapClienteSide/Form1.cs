using System;
using System.Windows.Forms;

namespace SoapClienteSide
{
    public partial class Ocorrencia : Form
    {
        public Ocorrencia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
       

            InserirSuspeitos inserirSuspeitos = new();


            inserirSuspeitos.Show();

            this.Hide();
        }
    }
}
