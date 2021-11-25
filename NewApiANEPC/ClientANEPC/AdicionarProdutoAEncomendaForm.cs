using ClientANEPC.Models;
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
    public partial class AdicionarProdutoAEncomendaForm : Form
    {
        public AdicionarProdutoAEncomendaForm()
        {
            InitializeComponent();
        }

        private void buttonAdicionarARequisicao_Click(object sender, EventArgs e)
        {
            


        }

        public void AdicionarProdutoEncomenda()
        {
            
            EncPro encPro = new();

            encPro.IdProduto = Int32.Parse(textBoxIdProduto.Text);
            encPro.QuantidadeProduto = Int32.Parse(textBoxQuantidadeProduto.Text);


        }
    }
}
