using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientANEPC
{
    public partial class EncomendasForm : Form
    {
        private static string host = "localhost";
        private static int port = 44359;
        private static string mediaType = "application/json";
        private static HttpClient client = new();


        public EncomendasForm()
        {
            InitializeComponent();
        }

        private void buttonNovaEncomenda_Click(object sender, EventArgs e)
        {
            NovaEncomendaForm nef = new();
            nef.Show();
            this.Hide();
        }
    }
}
