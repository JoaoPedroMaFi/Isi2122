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

        private void DisplayInfo(RichTextBox txtBox)
        {
            List<Isolado> isoladosList = new List<Isolado>();
            // DB Context
            Mydb_filesexportEntities db = new Mydb_filesexportEntities();
            List<isolado> isolados = db.isolado.ToList();
            MessageBox.Show(isolados.ToString());
            foreach (isolado iso in isolados)
            {
                Isolado isoladonovo = new Isolado();
                isoladonovo.Data = iso.data;
                isoladonovo.Firstname = iso.firstname;
                isoladonovo.Lastname = iso.lastname;
                isoladonovo.Respeitou = Convert.ToBoolean(iso.respeito);
                isoladonovo.UtentNumber = iso.utentNumber;
                isoladosList.Add(isoladonovo);
            }

            foreach (Isolado iso in isoladosList)
            {
                RtBView.Text += iso.Data + "\t\t" + iso.Firstname + "\t\t" + iso.Lastname + "\t\t" + iso.UtentNumber +
                    "\t\t" + iso.Respeitou.ToString() + "\n";
                //MessageBox.Show(bx.Text);
            }
        

        }

        private void btnShowData_Click(object sender, EventArgs e)
        {
            DisplayInfo(RtBView);
        }
    }
}
