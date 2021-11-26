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
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientANEPC
{
    public partial class AdicionarProdutoAEncomendaForm : Form
    {
        private static string host = "localhost";
        private static int port = 44359;
        private static string mediaType = "application/json";
        private static HttpClient client = new();

        public AdicionarProdutoAEncomendaForm()
        {
            InitializeComponent();
        }

        public void buttonAdicionarARequisicao_Click(object sender, EventArgs e)
        {

            AdicionarARequisicao();
            NovaEncomendaForm nef = new();
            this.Hide();
            nef.Show();
        }

        public EncPro AdicionarProdutoEncomenda()
        {
            
            EncPro encPro = new();

            encPro.IdProduto = Int32.Parse(textBoxIdProduto.Text);
            encPro.QuantidadeProduto = Int32.Parse(textBoxQuantidadeProduto.Text);
            encPro.IdEncomenda = GetEncomendaId();

            return encPro;
        }

        public List<EncPro> AdicionarARequisicao()
        {
            List<EncPro> encPros = new();

            encPros.Add(AdicionarProdutoEncomenda());

            return encPros;
        }

        private void AdicionarProdutoAEncomendaForm_Load(object sender, EventArgs e)
        {

        }

        public int GetEncomendaId()
        {
            int lastEncomendaId, currentEncomendaId;
            // get id of current encomenda
            string requestURI;

            HttpResponseMessage response;

            requestURI = $"https://{host}:{port.ToString().Trim()}/api/encomendas/getLastId";


            try
            {

                response = client.GetAsync(requestURI).Result;


                if (!response.StatusCode.Equals(HttpStatusCode.OK))
                {
                    throw new Exception(response.Content.ReadAsStringAsync().Result);
                }


                string data = response.Content.ReadAsStringAsync().Result;
                lastEncomendaId = JsonSerializer.Deserialize<int>(data, new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
                currentEncomendaId = lastEncomendaId + 1;

                return currentEncomendaId;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
            return -1;
        }
    }
}
