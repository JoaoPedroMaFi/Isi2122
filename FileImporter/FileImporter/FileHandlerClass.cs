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
           
            doc = new XPathDocument(filepath);
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
            ShowNode(title, node);

            ////Assign date to the object
            //isolado.data = (node.Current.Value).ToString();
            ////debug
            //MessageBox.Show($"Data no objeto: {isolado.data}");

            //-----------------------------------------
            //Limpar/Resetar o node ou utilizar outro, para iterar sobre cada um
            //-----------------------------------------
            //nav.DeleteSelf();

            title = "Select id isolado";
            node2 = nav.Select("//isolado");
            //node2.MoveNext();
            //MessageBox.Show(node2.Current.Value);
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

        //static void WorkAllNodes(string title, XPathNodeIterator node, Isolado isolado, XPathNavigator nav)
        //{

        //    // title
        //    MessageBox.Show($"{title}\n  count:{ node.Count }");

        //    // percorrer as varias entradas de isolado
        //    while (node.MoveNext())
        //    {
        //        //------------------
        //        //Retirar id isolado
        //        //------------------

        //        //Obter id e fazer magia para entrar no object 
        //        isolado.Idisolado = Int32.Parse((node.Current.Value).Replace('"', '\0').Trim());
        //        MessageBox.Show($"idisolado no objeto: {isolado.Idisolado}");


        //        //-----------------
        //        //Retirar id equipa
        //        //-----------------

        //        //title = "Select id equipa";
        //        node = nav.Select($"//isolado/idequipa");
        //        MessageBox.Show(node.Current.ToString());
        //        //Obter id e fazer magia para entrar no object
        //        isolado.Idequipa = Int32.Parse((node.Current.Value).Replace('"', '\0').Trim().Remove(1)); //remove pq xpath ta bugado, esta a ir buscar tudo apos o idequipa, incluindo o ideq

        //        MessageBox.Show($"idequipa no objeto: {isolado.Idequipa}");
        //        //MessageBox.Show(node.Current.OuterXml);


        //        //-----------------
        //        //retirar firstname
        //        //-----------------

        //        node = nav.Select($"//isolado/firstname"); 
        //        MessageBox.Show(node.Current.ToString());
        //        isolado.Firstname = (node.Current.Value);
        //        MessageBox.Show($"firstname no objeto: {isolado.Firstname}");

        //        //-----------------
        //        //retirar lastname
        //        //-----------------

        //        node = nav.Select($"//isolado/laststname");
        //        isolado.Lastname = (node.Current.Value);
        //        MessageBox.Show($"firstname no objeto: {isolado.Lastname}");
        //    }
        //}

        static void WorkAllNodes(string title, XPathNodeIterator node, Isolado isolado, XPathNavigator nav)
        {

            // percorrer as varias entradas de isolado
            while (node.MoveNext())
            {
                //------------------
                //Retirar id isolado
                //------------------

                //Obter id e fazer magia para entrar no object 
                node = nav.Select("//isolado/@id");
                node.MoveNext();
                isolado.Idisolado = Int32.Parse((node.Current.Value));
                MessageBox.Show($"idisolado no objeto: {isolado.Idisolado}");


                //-----------------
                //Retirar id equipa
                //-----------------

                //title = "Select id equipa";
                node = nav.Select($"//isolado/idequipa");
                node.MoveNext();
                //Obter id e fazer magia para entrar no object
                isolado.Idequipa = Int32.Parse((node.Current.Value)); //remove pq xpath ta bugado, esta a ir buscar tudo apos o idequipa, incluindo o ideq
                MessageBox.Show($"idequipa no objeto: {isolado.Idequipa}");
                //MessageBox.Show(node.Current.OuterXml);


                //-----------------
                //retirar firstname
                //-----------------

                node = nav.Select($"//isolado/firstname");
                node.MoveNext();
                isolado.Firstname = (node.Current.Value);
                MessageBox.Show($"firstname no objeto: {isolado.Firstname}");

                //-----------------
                //retirar lastname
                //-----------------

                node = nav.Select($"//isolado/lastname");
                node.MoveNext();
                isolado.Lastname = (node.Current.Value);
                MessageBox.Show($"lastname no objeto: {isolado.Lastname}");


                //-----------------
                //retirar data
                //-----------------

                node = nav.Select("/*/@data");
                node.MoveNext();
                isolado.Firstname = (node.Current.Value);
                MessageBox.Show($"data no objeto: {isolado.Data}");

                //-----------------
                //retirar respeito
                //-----------------

                node = nav.Select($"//isolado/respeitou");
                node.MoveNext();
                isolado.Lastname = (node.Current.Value);
                MessageBox.Show($"estado de cumprimento no objeto: {isolado.Respeitou}");
            }
        }
    }
}
