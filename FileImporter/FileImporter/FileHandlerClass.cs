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
            //MessageBox.Show("File Content at path: " + filePath);
        }

        /// <summary>
        /// determines selected file extension by looking at the end of the path
        /// </summary>
        /// <param name="fp"></param>
        public static void FileReader(string fp)
        {
            string ext;
            //string[] text = File.ReadAllLines($"{fp}");

            //Returns extension of file
            ext = Path.GetExtension(fp);

            if (ext == ".json")
            {
                MessageBox.Show("entrei no json");
            }
            else if (ext == ".xml")
            {
                //MessageBox.Show("entrei no xml");
                xmlUploader(fp);
            }
            else
            {
                MessageBox.Show("File Extension:" + ext);
                MessageBox.Show("File Extension not supported");
            }
            //MessageBox.Show("File Extension:" + ext);
        }
        //debug
        //MessageBox.Show("File Content at path: " + fp);

        /// <summary>
        /// uploads xml files to wherever
        /// sources: aulas
        ///          https://docs.microsoft.com/en-us/dotnet/api/system.xml.xpath.xpathdocument?view=net-5.0
        /// </summary>
        /// <param name="filepath"></param>
        public static void xmlUploader(string filepath)
        {
            XPathDocument doc;
            XPathNavigator nav;
            XPathNodeIterator node, node2;
            string title;
            Isolado isolado = new();


            //using (FileStream stream = File.Open(filepath, FileMode.Open))
           
            doc = new(filepath);
            nav = doc.CreateNavigator();

            //Read the whole file
            //title = "Read file";
            //node = nav.Select("/");
            //ShowNode(title,node);

            //-----------------------------------------------------------------
            // Retirar a data, vai ser a mesma para todas as entradas
            //-----------------------------------------------------------------

            //select date
            title = "Select date";
            node = nav.Select("/*/@data");
            ShowNode(title,node);

            //Assign date to the object
            isolado.data = (node.Current.Value).ToString();
            //debug
            MessageBox.Show($"Data no objeto: {isolado.data}");

            //-----------------------------------------
            //Limpar/Resetar o node ou utilizar outro, para iterar sobre cada um
            //-----------------------------------------
            //nav.DeleteSelf();

            title = "Select id isolado";
            node2 = nav.Select("/isolados/isolado/@id");

            WorkAllNodes(title, node2, isolado, nav);


            //pegar no valor do id e fazer xpath dentro do id para retirar o resto dos valores


        }

        static void ShowNode(string title, XPathNodeIterator node)
        {
            // title
            MessageBox.Show($"{title}\n  count:{ node.Count }");

            // show results
            while (node.MoveNext())
                MessageBox.Show(node.Current.OuterXml);
        }

        static void WorkAllNodes(string title, XPathNodeIterator node, Isolado isolado, XPathNavigator nav)
        {
            
            // title
            MessageBox.Show($"{title}\n  count:{ node.Count }");

            // percorrer as varias entradas de isolado
            while (node.MoveNext())
            {
                //------------------
                //Retirar id isolado
                //------------------

                //Obter id e fazer magia para entrar no object 
                isolado.idisolado = Int32.Parse((node.Current.Value).Replace('"', '\0').Trim());
                MessageBox.Show($"idisolado no objeto: {isolado.idisolado}");


                //-----------------
                //Retirar id equipa
                //-----------------

                //title = "Select id equipa";
                node = nav.Select($"//isolado[@id='{isolado.idisolado}']/idequipa"); 
                //Obter id e fazer magia para entrar no object
                isolado.idequipa = Int32.Parse((node.Current.Value).Replace('"', '\0').Trim().Remove(1)); //remove pq xpath ta bugado, esta a ir buscar tudo apos o idequipa, incluindo o ideq
                
                MessageBox.Show($"idequipa no objeto: {isolado.idequipa}");
                MessageBox.Show(node.Current.OuterXml);


                //-----------------
                //retirar firstname
                //-----------------

                node = nav.Select($"//isolado[@id='{isolado.idisolado}']/firstname");
                isolado.firstname = (node.Current.Value).ToString();
                MessageBox.Show($"firstname no objeto: {isolado.firstname}");
            }
        }
    }
}
