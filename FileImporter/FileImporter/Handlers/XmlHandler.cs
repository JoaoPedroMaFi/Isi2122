using FileImporter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace FileImporter.Handlers
{
    public class XmlHandler
    {
        /// <summary>
        /// Gets the number of entries of isolado from the xml document
        /// </summary>
        /// <param name="fp"></param>
        /// <returns></returns>
        public List<Isolado> XmlGetIsoladoObject(string fp)
        {
            List<Isolado> isolados = new List<Isolado>();
            XPathDocument document;
            XPathNavigator navigator;
            XPathNodeIterator nodes, node;

            document = new XPathDocument(fp);
            navigator = document.CreateNavigator();
            nodes = navigator.Select("//isolado");

            while (nodes.MoveNext())
            {
                Isolado isolado = new Isolado();
                //Retrieves the date in the xml file
                node = navigator.Select("/*/@data");
                node.MoveNext();
                //MessageBox.Show("data   " + node.Current.Value);
                isolado.Data = node.Current.Value;

                //Retrieves the utente number of current "isolado" node
                node = nodes.Current.Select("@utentNumber");
                node.MoveNext();
                //MessageBox.Show("utentNumber   " + node.Current.Value);
                isolado.UtentNumber = Int32.Parse(node.Current.Value);

                //Retrieves the equipa id number of current "isolado" node
                node = nodes.Current.Select("idequipa");
                node.MoveNext();
                //MessageBox.Show("idequipa   " + node.Current.Value);
                isolado.Idequipa = Int32.Parse(node.Current.Value);

                //Retrieves the firstname of current "isolado" node
                node = nodes.Current.Select("firstname");
                node.MoveNext();
                //MessageBox.Show("firstname   " + node.Current.Value);
                isolado.Firstname = node.Current.Value;

                //Retrieves the lasstname of current "isolado" node
                node = nodes.Current.Select("lastname");
                node.MoveNext();
                //MessageBox.Show("lastname   " + node.Current.Value);
                isolado.Lastname = node.Current.Value;

                //Retrieves the the status of isolation of current "isolado" node
                node = nodes.Current.Select("respeitou");
                node.MoveNext();
                //MessageBox.Show("respeitou   " + node.Current.Value);
                isolado.Respeitou = bool.Parse(node.Current.Value);
                // Add to list
                isolados.Add(isolado);

            }
            // return list
            return isolados;
        }

    }
}
