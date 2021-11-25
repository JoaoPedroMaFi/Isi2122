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
    public partial class ProdutosForm : Form
    {
        private static string host = "localhost";
        private static int port = 44359;
        private static string mediaType = "application/json";
        private static HttpClient client = new();

        public ProdutosForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Refreshes text boxes
        /// </summary>
        private void RefreshInfo()
        {
            listViewProdutos.Items.Clear();
            listViewProdutos.Refresh();

        }
        //------------------------------------------------------------------------
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonListarProdutos_Click(object sender, EventArgs e)
        {
            RefreshInfo();

            string requestURI;
            HttpResponseMessage response;
            List<Produto> produtos = new();
            ListView listview = new();
            requestURI = $"https://{host}:{port.ToString().Trim()}/api/produtos/getAll";

            try
            {
                response = client.GetAsync(requestURI).Result;
                if (!response.StatusCode.Equals(HttpStatusCode.OK))
                {
                    throw new Exception(response.Content.ReadAsStringAsync().Result);
                }



                //get data as Json string 
                string data = response.Content.ReadAsStringAsync().Result;
                produtos = JsonSerializer.Deserialize<List<Produto>>(data, new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
                listview.Items.Clear();
                foreach (Produto p in produtos)
                {
                    string[] row = { (p.IdProduto).ToString(), p.Descricao };
                    ListViewItem item = new ListViewItem(row);
     
                    listViewProdutos.Items.Add(item);
                }
                //listViewCidades = listview;
                //response.Content.ReadAsStringAsync();
                ////MessageBox.Show(response.Content.ReadAsStringAsync().Result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        //-------------------------------------------------------------------------------
    }
}
