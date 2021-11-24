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
using System.Net.Http.Json;

namespace ClientANEPC
{
    public partial class CidadesForm : Form
    {
        private static string host = "localhost";
        private static int port = 44359;
        private static string mediaType = "application/json";
        private static HttpClient client = new();
        public CidadesForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Refreshes text boxes
        /// </summary>
        private void RefreshInfo() 
        {
            listViewCidades.Items.Clear();
            listViewCidades.Refresh();

            listBox1.Items.Clear();
            listBox1.Refresh();
        }


        /// <summary>
        /// what happens when we press listar cidades button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonListarCidades_Click(object sender, EventArgs e)
        {
            //Program.getAllCities();
            RefreshInfo();

            string requestURI;
            HttpResponseMessage response;
            List<Cidade>citys = new();
            ListView listview = new();
            requestURI = $"https://{host}:{port.ToString().Trim()}/api/cidades/getAll";

            try
            {
                response = client.GetAsync(requestURI).Result;
                if (!response.StatusCode.Equals(HttpStatusCode.OK))
                {
                    throw new Exception(response.Content.ReadAsStringAsync().Result);
                }



                //get data as Json string 
                string data = response.Content.ReadAsStringAsync().Result;
                citys = JsonSerializer.Deserialize<List<Cidade>>(data, new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
                listview.Items.Clear();
                foreach (Cidade c in citys)
                {
                    string[] row = { c.IdCidade.ToString(), c.CidadeNome};
                    ListViewItem item = new ListViewItem(row);
                    
                    
                    listBox1.Items.Add(c.CidadeNome);
                    listBox1.Refresh();
                    listViewCidades.Items.Add(item);
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

        public void PreencheCampoTabEdit()
        {
            string[] dados = new string[8];
            try
            {
                //
                for (int i = 0; i < listViewCidades.SelectedItems[0].SubItems.Count; i++)
                {
                    dados[i] = listViewCidades.SelectedItems[0].SubItems[i].Text;
                }
                //labelCidadeId.Text = dados[0];
                //labelCidadeNome.Text = dados[1];
                
                //return lv.SelectedItems[0].SubItems[0].Text;

            }
            catch (Exception ee)
            {
                throw new Exception(ee.Message);
            }

        }

        private void listViewCidades_MouseClick(object sender, MouseEventArgs e)
        {
            PreencheCampoTabEdit();
        }

        //----------------------------------------------------------------------------

        private void buttonAddCity_Click(object sender, EventArgs e)
        {
            string requestURI, cityName;
            
            HttpResponseMessage response;
            
            requestURI = $"https://{host}:{port.ToString().Trim()}/api/cidades/addCity";

            cityName = textBoxAddCity.Text;
            try
            {
                response = client.PostAsJsonAsync(requestURI, cityName).Result;

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

            RefreshInfo();
        }

        private void textBoxAddCity_TextChanged(object sender, EventArgs e)
        {

        }

        //----------------------------------------------------------------------------------

        /// <summary>
        /// dado o ID de uma cidade, edita o nome desta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditarCidade_Click(object sender, EventArgs e)
        {
            string requestURI;
            HttpResponseMessage response;
            Cidade cidade = new();

            cidade.IdCidade = Int32.Parse(textBoxEditarCidadeId.Text);
            cidade.CidadeNome = textBoxEditarCidadeNome.Text;

           

            requestURI = $"https://{host}:{port.ToString().Trim()}/api/cidades/editCity";

            try
            {
                response = client.PutAsJsonAsync(requestURI, cidade).Result;

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

            RefreshInfo();
        }


        //-------------------------------------------------------------------------------------

        //button apagar cidade
        private void button1_Click(object sender, EventArgs e)
        {

            string requestURI;
            HttpResponseMessage response;
            int cidadeId;

            cidadeId = Int32.Parse(textBoxApagarCidade.Text);
            

            requestURI = $"https://{host}:{port.ToString().Trim()}/api/cidades/deleteCity/{cidadeId}";

            try
            {
                response = client.DeleteAsync(requestURI).Result;

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

            RefreshInfo();

        }
    }
}
