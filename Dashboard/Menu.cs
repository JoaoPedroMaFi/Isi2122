using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Final_dash fd = new();
            fd.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashConsultas dc = new();
            dc.Show();
        }
    }
}
