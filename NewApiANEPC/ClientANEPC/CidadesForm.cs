using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientANEPC
{
    public partial class CidadesForm : Form
    {
        public CidadesForm()
        {
            InitializeComponent();
        }

        private void buttonListarCidades_Click(object sender, EventArgs e)
        {
            Program.getAllCities();
        }
    }
}
