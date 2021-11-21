using FileImporter.DbContext;
using FileImporter.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileImporter.Handlers
{
    class FileHandlerClass
    {
        public readonly string filepath;
        /// <summary>
        /// Constructor for class FileHandler. 
        /// </summary>
        public FileHandlerClass(string filePath)
        {
            this.filepath = filePath;
            FileReader(filePath);
        }


        /// <summary>
        /// determines selected file extension by looking at the end of the path
        /// </summary>
        /// <param name="fp"></param>
        public static void FileReader(string fp)
        {
            string ext;
            int result;
            List<Isolado> listIsolados = new List<Isolado>();
            // DataBase Context
            Mydb_filesexportEntities db = new Mydb_filesexportEntities();
            isolado isoladoBD = new isolado();

            //Returns extension of file
            ext = Path.GetExtension(fp);

            if (ext == ".json")
            {
                JsonHandler jsonFile = new JsonHandler();
                listIsolados = jsonFile.ReadJsonFile(fp);

                foreach (Isolado iso in listIsolados)
                {
                    isoladoBD.data = iso.Data;
                    isoladoBD.utentNumber = iso.UtentNumber;
                    isoladoBD.firstname = iso.Firstname;
                    isoladoBD.lastname = iso.Lastname;
                    isoladoBD.idequipa = iso.Idequipa;
                    isoladoBD.respeito = Convert.ToSByte(iso.Respeitou);
                    db.isolado.Add(isoladoBD);
                    result = db.SaveChanges();

                    if (result > 0)
                    {
                        MessageBox.Show("Dados Json Carregados e Guardados");
                    }

                }
                //foreach (Isolado iso in listIsolados)
                //{
                //    MessageBox.Show(iso.Data + "  " + iso.Firstname + "  " + iso.Lastname + "  " + iso.UtentNumber + "  " + iso.Respeitou);
                //}
            }
            else if (ext == ".xml")
            {
                XmlHandler xmlfile = new XmlHandler();


                listIsolados = xmlfile.XmlGetIsoladoObject(fp);

                foreach (Isolado iso in listIsolados)
                {
                    //isoladoBD.idisolado = HasDefaul;
                    isoladoBD.data = iso.Data;
                    isoladoBD.utentNumber = iso.UtentNumber;
                    isoladoBD.firstname = iso.Firstname;
                    isoladoBD.lastname = iso.Lastname;
                    isoladoBD.idequipa = iso.Idequipa;
                    isoladoBD.respeito = Convert.ToSByte(iso.Respeitou);
                    db.isolado.Add(isoladoBD);
                    result=db.SaveChanges();
                    
                    if (result>0)
                    {
                        MessageBox.Show("Dados XML Carregados e Guardados");
                    }

                }
                //foreach (Isolado iso in listIsolados)
                //{
                //    MessageBox.Show(iso.Data + "  " + iso.Firstname + "  " + iso.Lastname + "  " + iso.UtentNumber + "  " + iso.Respeitou);
                //}

            }
            else
            {
                MessageBox.Show("File Extension:" + ext);
                MessageBox.Show("File Extension not supported");

            }
        }
    }
}
