using ClientANEPC.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace ClientANEPC
{
    public partial class NovaEncomendaForm : Form
    {
        private static string host = "localhost";
        private static int port = 44359;
        private static string mediaType = "application/json";
        private static HttpClient client = new();

        public NovaEncomendaForm()
        {
            InitializeComponent();
        }

        private void NovaEncomendaForm_Load(object sender, EventArgs e)
        {

        }

        //-------------------------------------------------------------------
        private void buttonEscolherProds_Click(object sender, EventArgs e)
        {
            
            // criar encomenda
            Encomenda encomenda = new();

            encomenda.IdEquipa = Int32.Parse(textBoxIdEquipaReq.Text);
            encomenda.Entregue = false;


            // lista de ids dos produtos e quantidades
            //List<EncPro> encPros = new();

            AdicionarProdutoAEncomendaForm apaef = new();
            apaef.Show();
            this.Hide();

        }

        private void buttonRequisitar_Click(object sender, EventArgs e)
        {
            //AdicionarARequisicao();
        }
    }
}
