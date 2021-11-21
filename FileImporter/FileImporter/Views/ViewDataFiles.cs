using FileImporter.DbContext;
using FileImporter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileImporter.Views
{
    public class ViewDataFiles
    {
        Mydb_filesexportEntities db = new Mydb_filesexportEntities();

        public List<Isolado> GetAllIsolats()
        {
            List<Isolado> isoladosList = new List<Isolado>();
            // DB Context
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
            return isoladosList;
        }

        public RichTextBox ShowAllIsolates(List<Isolado> isolados)
        {
            RichTextBox bx = new RichTextBox();
            foreach (Isolado iso in isolados)
            {
                bx.Text += iso.Data + "\t" + iso.Firstname + "\t" + iso.Lastname + "\t" + iso.UtentNumber +
                    "\t" + iso.Respeitou.ToString() ;
                //MessageBox.Show(bx.Text);
            }
            return bx;
        }
    }
}
