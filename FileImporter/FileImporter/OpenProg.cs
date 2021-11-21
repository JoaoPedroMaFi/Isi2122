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
    public partial class OpenProg : Form
    {
        public OpenProg()
        {
            InitializeComponent();
        }

        private void BtnImportFiles_Click(object sender, EventArgs e)
        {
            FilesImport filesImport = new FilesImport();
            filesImport.ShowDialog();
            filesImport.Hide();
        }

        private void BtnViewData_Click(object sender, EventArgs e)
        {
            ViewData view = new ViewData();
            view.ShowDialog();
            view.Hide();
        }
    }
}
