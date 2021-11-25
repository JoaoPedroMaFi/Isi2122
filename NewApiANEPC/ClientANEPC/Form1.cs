using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientANEPC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cidadesButton_Click(object sender, EventArgs e)
        {
            CidadesForm cf = new();
            cf.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        //----------------------------------------------------------------------------------
        private void buttonEncomendas_Click(object sender, EventArgs e)
        {
            EncomendasForm ef = new();
            ef.Show();
            this.Hide();
        }


        //----------------------------------------------------------------------------------
        private void buttonEquipas_Click(object sender, EventArgs e)
        {
            EquipasForm eqf = new();
            eqf.Show();
            this.Hide();
        }

        

        //-----------------------------------------------------------------------------------
        private void buttonProdutos_Click(object sender, EventArgs e)
        {
            ProdutosForm pf = new();
            pf.Show();
            this.Hide();
        }
    }
}
