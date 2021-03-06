using FileImporter.Handlers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileImporter
{
    public partial class FilesImport : Form
    {
        public FilesImport()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            GetFilePath();
        }

        public static string GetFilePath()
        {
            //string fileContent, filePath;

            //https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.openfiledialog?view=windowsdesktop-5.0

            var fileContent = string.Empty;
            var filePath = string.Empty;

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            //Filter file types
            openFileDialog1.Filter = "Json files (.json)|*.json|XML files (.xml)|*.xml";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.FilterIndex = 2;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = openFileDialog1.FileName;
               
                //Passing path to FileHandlerClass
                FileHandlerClass fh = new FileHandlerClass(filePath);
                //fh.filePATH = filePath;

                ////Read the contents of the file into a stream
                //var fileStream = openFileDialog1.OpenFile();

                //using (StreamReader reader = new StreamReader(fileStream))
                //{
                //    fileContent = reader.ReadToEnd();
                //}
            }

            //debug
            //MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);
            //openFileDialog1.ShowDialog();


            return filePath;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenProg openProg = new OpenProg();
            openProg.Show();
            this.Close();
        }
    }
}
