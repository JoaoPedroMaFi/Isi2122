﻿using ClientANEPC.Models;
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

        private void buttonListarCidades_Click(object sender, EventArgs e)
        {
            //Program.getAllCities();

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
                labelCidadeId.Text = dados[0];
                labelCidadeNome.Text = dados[1];
                
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
    }
}
