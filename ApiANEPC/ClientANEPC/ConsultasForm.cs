using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
;

namespace ClientANEPC.Models
{
    public partial class ConsultasForm : Form
    {
        public ConsultasForm()
        {
            InitializeComponent();
        }

        private void ConsultasForm_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadCities();
        }

        private async void LoadCities()
        {
            await ApiCalls.ListCities();
            var cities = await ApiCalls.ListCities();
            listBoxCidades.Items.Clear();
            foreach (var city in cities)
            {
                listBoxCidades.Items.Add($"Cidade: {city.cidade_nome} Equipas: {city.equipas}");
                listBoxCidades.Refresh();
            }
        }
    }
}
