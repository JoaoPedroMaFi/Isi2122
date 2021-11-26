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
            CreateEncomenda();

            // lista de ids dos produtos e quantidades
            //List<EncPro> encPros = new();


            AdicionarProdutoAEncomendaForm apaef = new();
            apaef.Show();
            this.Hide();

        }

        private void buttonRequisitar_Click(object sender, EventArgs e)
        {
            

        }

        public void CreateEncomenda()
        {
            int idEq;
            string requestURI;

            HttpResponseMessage response;

            requestURI = $"https://{host}:{port.ToString().Trim()}/api/encomendas/addEncomenda";

            idEq = Int32.Parse(textBoxIdEquipaReq.Text);
            try
            {
                response = client.PostAsJsonAsync(requestURI, idEq).Result;

                if (!response.StatusCode.Equals(HttpStatusCode.OK))
                {
                    throw new Exception(response.Content.ReadAsStringAsync().Result);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        public void EnviarEncPro()
        {
            List<EncPro> list;
            AdicionarProdutoAEncomendaForm apaef = new();
            list = apaef.AdicionarARequisicao();

            foreach (EncPro item in list)
            {
                //mandar p bd um a um, pegar no id da encomenda
                
            }
        }


    }
}
