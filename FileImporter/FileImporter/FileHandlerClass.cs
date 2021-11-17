using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;

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
                MessageBox.Show("entrei no xml");
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
        /// uploads xml files
        /// sources: https://docs.microsoft.com/en-us/dotnet/api/system.io.stream?view=net-5.0
        ///          https://docs.microsoft.com/en-us/dotnet/api/system.xml.xpath.xpathdocument?view=net-5.0
        /// </summary>
        /// <param name="filepath"></param>
        public static void xmlUploader(string filepath)
        {
            XPathDocument doc;
            XPathNavigator nav;
            XPathNodeIterator node;
            string title;

            //using (FileStream stream = File.Open(filepath, FileMode.Open))
           
            doc = new(filepath);
            nav = doc.CreateNavigator();
            title = "Read file";
            node = nav.Select("/");
            ShowNode(title,node);
           

        }

        static void ShowNode(string title, XPathNodeIterator node)
        {
            // title
            MessageBox.Show($"{title}\n  count:{ node.Count }");

            // show results
            while (node.MoveNext())
                MessageBox.Show(node.Current.OuterXml);
        }
    }
}
