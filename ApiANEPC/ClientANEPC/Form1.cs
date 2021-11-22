using ClientANEPC.Models;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConsultas_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsultasForm cf = new();
            cf.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Show();
        }
    }
}
