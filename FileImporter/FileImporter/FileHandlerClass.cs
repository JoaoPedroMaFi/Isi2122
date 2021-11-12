using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.

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
    
    }
}
