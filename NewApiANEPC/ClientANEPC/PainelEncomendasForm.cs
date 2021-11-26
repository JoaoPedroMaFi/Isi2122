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
    public partial class PainelEncomendasForm : Form
    {
        private static string host = "localhost";
        private static int port = 44359;
        private static string mediaType = "application/json";
        private static HttpClient client = new();

        public PainelEncomendasForm()
        {
            InitializeComponent();
        }

        //list view hist encomendas
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonBuscarHistorico_Click(object sender, EventArgs e)
        {
            string requestURI;
            HttpResponseMessage response;
            List<Encomenda> encomendas;
            requestURI = $"https://{host}:{port.ToString().Trim()}/api/encomendas/getAll";

            try
            {
                response = client.GetAsync(requestURI).Result;
                if (!response.StatusCode.Equals(HttpStatusCode.OK))
                {
                    throw new Exception(response.Content.ReadAsStringAsync().Result);
                }


                //get data as Json string 
                string data = response.Content.ReadAsStringAsync().Result;
                encomendas = JsonSerializer.Deserialize<List<Encomenda>>(data, new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
                listView1.Items.Clear();
                foreach (Encomenda enc in encomendas)
                {
                    string[] row = { enc.IdEncomenda.ToString(), enc.IdEquipa.ToString(), enc.Entregue.ToString() };
                    ListViewItem item = new ListViewItem(row);

                    listView1.Items.Add(item);
                }
             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        //-----------------------------------------------------------------------
        private void buttonDetalhesEncomenda_Click(object sender, EventArgs e)
        {
            string requestURI;

            HttpResponseMessage response;
            List<EncPro> encPros;
            requestURI = $"https://{host}:{port.ToString().Trim()}/api/encomendas/getEncomendaDetailsById/{textBoxIdEnc.Text.ToString().Trim()}";

            try
            {
                response = client.GetAsync(requestURI).Result;
                if (!response.StatusCode.Equals(HttpStatusCode.OK))
                {
                    throw new Exception(response.Content.ReadAsStringAsync().Result);
                }


                //get data as Json string 
                string data = response.Content.ReadAsStringAsync().Result;
                encPros = JsonSerializer.Deserialize<List<EncPro>>(data, new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
                listView2.Items.Clear();
                foreach (EncPro encPro in encPros)
                {
                    string[] row = { encPro.IdProduto.ToString(), encPro.QuantidadeProduto.ToString() };
                    ListViewItem item = new ListViewItem(row);


                    listView2.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
