using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;
using FileImporter.Models;


namespace FileImporter
{
    public class FileHandlerClass
    {
        private readonly string filepath;
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
            string ext, date;
            List<int> idsIsolado;
            List<int> idsEquipa;
            List<string> firstNames;
            List<string> lastNames;
            List<bool> respeito;
            int count;
            Isolado isolado = new();

            //Returns extension of file
            ext = Path.GetExtension(fp);

            if (ext == ".json")
            {
                MessageBox.Show("entrei no json");
                JsonHandler.ReadJsonFile(fp);
                
            }
            else if (ext == ".xml")
            {
                MessageBox.Show("entrei no xml");
                date = XmlHandler.XmlGetDate(fp);
                idsIsolado = XmlHandler.XmlWriteToIdIsoladoList(fp);
                idsEquipa = XmlHandler.XmlWriteToIdEquipaList(fp);
                firstNames = XmlHandler.XmlWriteToFirstnameList(fp);
                lastNames = XmlHandler.XmlWriteToLastnameList(fp);
                respeito = XmlHandler.XmlWriteToRespeitouList(fp);
                count = XmlHandler.XmlGetIsoladoCount(fp);

                isolado.Data = date;
                for (int i = 0; i < count; i++)
                {
                    isolado.Idisolado = idsIsolado[i];
                    isolado.Idequipa = idsEquipa[i];
                    isolado.Firstname = firstNames[i];
                    isolado.Lastname = lastNames[i];
                    isolado.Respeitou = respeito[i];

                    //Mandar para base de dados;
                }
            }
            else
            {
                MessageBox.Show("File Extension:" + ext);
                MessageBox.Show("File Extension not supported");
 
            }  
        }     
    }
}
