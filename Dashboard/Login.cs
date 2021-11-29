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
using System.Diagnostics;

namespace Dashboard
{
    public partial class Login : Form
    {
        private static string host = "localhost";
        private static int port = 44373;
        private static string mediaType = "application/json";
        private static HttpClient client = new();
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TODO: login tokens etc
            /*
            string requestURI;
            HttpResponseMessage response;            
            ListView listview = new();
            //requestURI = $"https://{host}:{port.ToString().Trim()}/api/users/google-login";
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "https://localhost:44373/api/users/google-login",
                    UseShellExecute = true

                });
                var request = (HttpWebRequest)WebRequest.Create("https://localhost:44373/api/users/google-response");
                var responsee = (HttpWebResponse)request.GetResponse();
                MessageBox.Show(responsee.ToString());

                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            requestURI = $"https://localhost:44373/api/users/google-login";

            try
            {
                response = client.GetAsync(requestURI).Result;
                if (!response.StatusCode.Equals(HttpStatusCode.OK))
                {
                    throw new Exception(response.Content.ReadAsStringAsync().Result);
                    
                }
                


                //get data as Json string 
                //string data = response.Content.ReadAsStringAsync().Result;
                //citys = JsonSerializer.Deserialize<List<Cidade>>(data, new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
                //listview.Items.Clear();
                //foreach (Cidade c in citys)
                //{
                //    string[] row = { c.IdCidade.ToString(), c.CidadeNome };
                //    ListViewItem item = new ListViewItem(row);


                //    listBox1.Items.Add(c.CidadeNome);
                //    listBox1.Refresh();
                //    listViewCidades.Items.Add(item);
                //}
                //listViewCidades = listview;
                //response.Content.ReadAsStringAsync();
                ////MessageBox.Show(response.Content.ReadAsStringAsync().Result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }*/

            this.Hide();
            Menu menu = new();
            menu.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateUser cu = new();
            cu.Show();
        }
    }
}
