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
    public partial class NovaEncomendaForm : Form
    {
        private static string host = "localhost";
        private static int port = 44359;
        private static string mediaType = "application/json";
        private static HttpClient client = new();

        public NovaEncomendaForm(int idE)
        {
            InitializeComponent();
            labelIdEq.Text = idE.ToString();
        }

        private void NovaEncomendaForm_Load(object sender, EventArgs e)
        {

        }

        //-------------------------------------------------------------------
        private void buttonEscolherProds_Click(object sender, EventArgs e)
        {
            // lista de ids dos produtos e quantidades
            //List<EncPro> encPros = new();


            AdicionarProdutoAEncomendaForm apaef = new();
            apaef.Show();
            this.Hide();

        }

        private void buttonRequisitar_Click(object sender, EventArgs e)
        {
            int idE;
            idE = Int32.Parse(labelIdEq.Text);
            List<EncPro> list = new();

            // criar encomenda
            CreateEncomenda(idE);
            EnviarEncPro(list);

        }

        public void CreateEncomenda(int idE)
        {
            int idEq;
            string requestURI;

            HttpResponseMessage response;

            requestURI = $"https://{host}:{port.ToString().Trim()}/api/encomendas/addEncomenda";

            idEq = idE;
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

        public void EnviarEncPro(List<EncPro> list)
        {

            foreach (EncPro item in list)
            {
                string requestURI;

                HttpResponseMessage response;

                requestURI = $"https://{host}:{port.ToString().Trim()}/api/encpro/addEncPro";

                try
                {
                    response = client.PostAsJsonAsync(requestURI, item).Result;

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
        }


    }
}
