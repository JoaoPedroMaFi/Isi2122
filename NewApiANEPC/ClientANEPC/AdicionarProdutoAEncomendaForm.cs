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

        public void buttonAdicionarARequisicao_Click(object sender, EventArgs e)
        {
            AdicionarARequisicao();            
        }

        public EncPro AdicionarProdutoEncomenda()
        {
            
            EncPro encPro = new();

            encPro.IdProduto = Int32.Parse(textBoxIdProduto.Text);
            encPro.QuantidadeProduto = Int32.Parse(textBoxQuantidadeProduto.Text);

            return encPro;
        }

        public List<EncPro> AdicionarARequisicao()
        {
            List<EncPro> encPros = new();

            encPros.Add(AdicionarProdutoEncomenda());

            return encPros;
        }
    }
}
