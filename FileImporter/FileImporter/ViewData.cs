using FileImporter.DbContext;
using FileImporter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FileImporter
{
    public partial class ViewData : Form
    {
        public ViewData()
        {
            InitializeComponent();

        }

        private void DisplayInfo()
        {
            List<Isolado> isoladosList = new List<Isolado>();
            // DB Context
            Mydb_filesexportEntities db = new Mydb_filesexportEntities();
            ListView listview = new ListView();
            //ListViewItem item = new ListViewItem();
            ListViewFile.Items.Clear();
            string estado;
            List<isolado> isolados = db.isolado.ToList();
            //MessageBox.Show(isolados.ToString());
            foreach (isolado iso in isolados)
            {
               
                Isolado isoladonovo = new Isolado();
                if (iso.respeito == 1)
                {
                     estado = "Sim";
                }
                else
                {
                    estado = "Não";
                }
                string[] row = {
                 iso.data,
                 iso.firstname,
                 iso.lastname,
                 iso.utentNumber.ToString(),
                 estado,
                 iso.idequipa.ToString()
                };
               

                ListViewItem item = new ListViewItem(row);
                
                ListViewFile.Items.Add(item);
            }

            //foreach (Isolado iso in isoladosList)
            //{
            //    RtBView.Text += iso.Data + "\t\t" + iso.Firstname + "\t\t" + iso.Lastname + "\t\t" + iso.UtentNumber +
            //        "\t\t" + iso.Respeitou.ToString() + "\n";
            //    //MessageBox.Show(bx.Text);
            //}


        }

        private void btnShowData_Click(object sender, EventArgs e)
        {
            DisplayInfo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenProg openProg = new OpenProg();
            openProg.Show();
            this.Close();
        }
    }
}
