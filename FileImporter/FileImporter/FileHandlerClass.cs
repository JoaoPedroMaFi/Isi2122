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
                
            }
            else if (ext == ".xml")
            {
                MessageBox.Show("entrei no xml");
                date = XmlGetDate(fp);
                idsIsolado = XmlWriteToIdIsoladoList(fp);
                idsEquipa = XmlWriteToIdEquipaList(fp);
                firstNames = XmlWriteToFirstnameList(fp);
                lastNames = XmlWriteToLastnameList(fp);
                respeito = XmlWriteToRespeitouList(fp);
                count = XmlGetIsoladoCount(fp);

                isolado.Data = date;
                for (int i = 0; i < count; i++)
                {
                    isolado.Idisolado = idsIsolado[i];
                    isolado.Idequipa = idsEquipa[i];
                    isolado.Firstname = firstNames[i];
                    isolado.Lastname = lastNames[i];
                    isolado.Respeitou = respeito[i];

                    //return isolado;
                }
            }
            else
            {
                MessageBox.Show("File Extension:" + ext);
                MessageBox.Show("File Extension not supported");
 
            }  
        }
        
        /// <summary>
        /// Gets the number of entries from the xml document
        /// </summary>
        /// <param name="fp"></param>
        /// <returns></returns>
        public static int XmlGetIsoladoCount(string fp)
        {
            int count;
            XPathDocument doc;
            XPathNavigator nav;
            XPathNodeIterator node;

            doc = new XPathDocument(fp);
            nav = doc.CreateNavigator();
            node = nav.Select("//isolado");
            count = node.Count;

            MessageBox.Show($"{count}");
            return count;
        }

        /// <summary>
        /// retrieves all isolado ids and returns a list with them
        /// </summary>
        /// <param name="filepath"></param>
        /// <returns></returns>
        public static List<int> XmlWriteToIdIsoladoList(string filepath)
        {
            XPathDocument doc;
            XPathNavigator nav;
            XPathNodeIterator node;
            string title;
            List<int> idsIsolado = new();
            int idIsolado;

           
            doc = new XPathDocument(filepath);
            nav = doc.CreateNavigator();
            node = nav.Select("//isolado/@id");
            title = "Select idisolado:";
            MessageBox.Show($"{title}\n  count:{ node.Count }");

            while (node.MoveNext())
            {
                //------------------
                //Retirar id isolado
                //------------------

                //Obter id e fazer magia para entrar no object
                
                idIsolado = Int32.Parse((node.Current.Value));

                //Adicionar à lista
                idsIsolado.Add(idIsolado);
                
                MessageBox.Show($"idisolado: {idIsolado}");
            }
           

            return idsIsolado;

        }

        /// <summary>
        /// retrieves all team ids and returns a list with them
        /// </summary>
        /// <param name="filepath"></param>
        /// <returns></returns>
        public static List<int> XmlWriteToIdEquipaList(string filepath)
        {
            XPathDocument doc;
            XPathNavigator nav;
            XPathNodeIterator node;
            string title;
            List<int> idsEquipa = new();
            int idEquipa;


            doc = new XPathDocument(filepath);
            nav = doc.CreateNavigator();
            node = nav.Select("//isolado/idequipa");
            title = "Select idEquipa:";
            MessageBox.Show($"{title}\n  count:{ node.Count }");

            while (node.MoveNext())
            {
                //------------------
                //Retirar id equipas
                //------------------

                //Obter id e fazer magia para entrar no object

                idEquipa = Int32.Parse((node.Current.Value));

                //Adicionar à lista
                idsEquipa.Add(idEquipa);

                MessageBox.Show($"idEquipa: {idEquipa}");
            }
            return idsEquipa;
        }

        /// <summary>
        /// retrieves all first names and returns a list with them
        /// </summary>
        /// <param name="filepath"></param>
        /// <returns></returns>
        public static List<string> XmlWriteToFirstnameList(string filepath)
        {
            XPathDocument doc;
            XPathNavigator nav;
            XPathNodeIterator node;
            string title;
            List<string> firstNames = new();
            string firstName;


            doc = new XPathDocument(filepath);
            nav = doc.CreateNavigator();
            node = nav.Select($"//isolado/firstname");
            title = "Select idEquipa:";
            MessageBox.Show($"{title}\n  count:{ node.Count }");

            while (node.MoveNext())
            {
                //------------------
                //Retirar first names
                //------------------

                firstName = node.Current.Value;

                //Adicionar à lista
                firstNames.Add(firstName);

                MessageBox.Show($"Firstname: {firstName}");
            }
            return firstNames;
        }

        /// <summary>
        /// retrieves all last names and returns a list with them
        /// </summary>
        /// <param name="filepath"></param>
        /// <returns></returns>
        public static List<string> XmlWriteToLastnameList(string filepath)
        {
            XPathDocument doc;
            XPathNavigator nav;
            XPathNodeIterator node;
            string title;
            List<string> lastNames = new();
            string lastName;


            doc = new XPathDocument(filepath);
            nav = doc.CreateNavigator();
            node = nav.Select($"//isolado/lastname");
            title = "Select lastname:";
            MessageBox.Show($"{title}\n  count:{ node.Count }");

            while (node.MoveNext())
            {
                //------------------
                //Retirar last names
                //------------------

                lastName = node.Current.Value;

                //Adicionar à lista
                lastNames.Add(lastName);

                MessageBox.Show($"lastname: {lastName}");
            }
            return lastNames;
        }

        /// <summary>
        /// Retrieves the date in the xml file
        /// </summary>
        /// <param name="filepath"></param>
        /// <returns></returns>
        public static string XmlGetDate(string filepath)
        {
            XPathDocument doc;
            XPathNavigator nav;
            XPathNodeIterator node;
            string title, date;


            doc = new XPathDocument(filepath);
            nav = doc.CreateNavigator();

            node = nav.Select($"/*/@data");
            title = "Select date:";
            MessageBox.Show($"{title}\n  count:{ node.Count }");
            node.MoveNext();
            date = node.Current.Value;
            MessageBox.Show($"date: {date}");

            return date;
        }


        /// <summary>
        /// retrieves all booleans of respeitou and returns a list with them
        /// </summary>
        /// <param name="filepath"></param>
        /// <returns></returns>
        public static List<bool> XmlWriteToRespeitouList(string filepath)
        {
            XPathDocument doc;
            XPathNavigator nav;
            XPathNodeIterator node;
            string title;
            List<bool> respeito = new();
            bool respeitou;


            doc = new XPathDocument(filepath);
            nav = doc.CreateNavigator();
            node = nav.Select($"//isolado/respeitou");
            title = "Select lastname:";
            MessageBox.Show($"{title}\n  count:{ node.Count }");

            while (node.MoveNext())
            {
                //------------------
                //Retirar last names
                //------------------

                respeitou = Boolean.Parse(node.Current.Value);

                //Adicionar à lista
                respeito.Add(respeitou);

                MessageBox.Show($"lastname: {respeitou}");
            }
            return respeito;
        }
        //------------------------------------------------------------------------------------------------------



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

        //    // percorrer as varias entradas de isolado
        //    while (node.MoveNext())
        //    {
        //        node = nav.Select("//*");
        //        node.MoveNext();
        //        isolado.Data = node.Current.Value;
        //        MessageBox.Show($"tudo no objeto: {isolado.Data}");

        //        //-----------------------------------------------------------------
        //        // Retirar a data, vai ser a mesma para todas as entradas
        //        //-----------------------------------------------------------------

        //        node = nav.Select("/*/@data");
        //        node.MoveNext();
        //        isolado.Data = node.Current.Value;
        //        MessageBox.Show($"data no objeto: {isolado.Data}");

        //        //------------------
        //        //Retirar id isolado
        //        //------------------

        //        //Obter id e fazer magia para entrar no object 
        //        node = nav.Select("//isolado/@id");
        //        node.MoveNext();
        //        isolado.Idisolado = Int32.Parse((node.Current.Value));
        //        MessageBox.Show($"idisolado no objeto: {isolado.Idisolado}");


        //        //-----------------
        //        //Retirar id equipa
        //        //-----------------

        //        //title = "Select id equipa";
        //        node = nav.Select($"//isolado[@id={isolado.Idisolado}]/idequipa");
        //        node.MoveNext();
        //        //Obter id e fazer magia para entrar no object
        //        isolado.Idequipa = Int32.Parse((node.Current.Value)); //remove pq xpath ta bugado, esta a ir buscar tudo apos o idequipa, incluindo o ideq
        //        MessageBox.Show($"idequipa no objeto: {isolado.Idequipa}");
        //        //MessageBox.Show(node.Current.OuterXml);


        //        //-----------------
        //        //retirar firstname
        //        //-----------------

        //        node = nav.Select($"//isolado[@id={isolado.Idisolado}]/firstname");
        //        node.MoveNext();
        //        isolado.Firstname = (node.Current.Value);
        //        MessageBox.Show($"firstname no objeto: {isolado.Firstname}");

        //        //-----------------
        //        //retirar lastname
        //        //-----------------

        //        node = nav.Select($"//isolado[@id={isolado.Idisolado}]/lastname");
        //        node.MoveNext();
        //        isolado.Lastname = (node.Current.Value);
        //        MessageBox.Show($"lastname no objeto: {isolado.Lastname}");


        //        //-----------------
        //        //retirar data
        //        //-----------------

        //        //node = nav.Select("/*/@data");
        //        //node.MoveNext();
        //        //isolado.Firstname = (node.Current.Value);
        //        //MessageBox.Show($"data no objeto: {isolado.Data}");

        //        //-----------------
        //        //retirar respeito
        //        //-----------------

        //        node = nav.Select($"//isolado[@id={isolado.Idisolado}]/respeitou");
        //        node.MoveNext();
        //        isolado.Respeitou = Boolean.Parse(node.Current.Value);
        //        MessageBox.Show($"estado de cumprimento no objeto: {isolado.Respeitou}");

        //        nav.MoveToNext(XPathNodeType.Attribute);
        //        //node.CurrentPosition++;

        //    }
        //}
    }
}
