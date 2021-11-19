using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;
using FileImporter.Models;
using System.Windows.Forms;

namespace FileImporter
{
    public static class XmlHandler
    {
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
    }
}
