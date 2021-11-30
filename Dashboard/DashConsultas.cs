using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
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
    public partial class DashConsultas : Form
    {        
        public DashConsultas()
        {
            InitializeComponent();

            _ = LoadTop5();
            _ = LoadTop10Teams();
            _ = LoadVisitasDia();
        }

        public async Task<ActionResult<IEnumerable<int>>> LoadTop5()
        {
            string sqlConStr = "Server=localhost;user=root;password=1234;Database=mydb_isi";
            using var connection = new MySqlConnection(sqlConStr);
            //open connection
            await connection.OpenAsync();

            // retorna o id da ultima encomenda feita
            string query = $@"
                            SELECT idproduct, descricao, SUM(quantidade) as 'Total' from encpro inner join produto on idproduct = produto.idproduto group by(idproduct) order by SUM(quantidade) DESC Limit 5;";
            using var command = new MySqlCommand(query, connection);
            using var reader = await command.ExecuteReaderAsync();

            top5lstview.Items.Clear();
            while (await reader.ReadAsync())
            {
                string[] row =
                {
                    reader.GetInt32(0).ToString(),
                    reader.GetString(1),
                    reader.GetInt32(2).ToString()
             
                };
                ListViewItem item = new ListViewItem(row);
                top5lstview.Items.Add(item);
            }
            
            //Close the reader
            await reader.CloseAsync();
            //Close connection
            await connection.CloseAsync();

            return null;
        }

        public async Task<ActionResult<IEnumerable<int>>> LoadTop10Teams()
        {
            string sqlConStr = "Server=localhost;user=root;password=1234;Database=mydb_isi";
            using var connection = new MySqlConnection(sqlConStr);
            //open connection
            await connection.OpenAsync();

            // retorna o id da ultima encomenda feita
            string query = $@"SELECT * from view2;";
            using var command = new MySqlCommand(query, connection);
            using var reader = await command.ExecuteReaderAsync();

            //top10lstView.Items.Clear();
            while (await reader.ReadAsync())
            {
                string[] row =
                {
                    reader.GetInt32(0).ToString(),
                    reader.GetString(1),
                    reader.GetFloat(2).ToString()

                };
                
                ListViewItem item = new ListViewItem(row);
                top10lstView.Items.Add(item);
            }
            //value =reader.GetInt32(0);

            //Close the reader
            await reader.CloseAsync();
            //Close connection
            await connection.CloseAsync();

            return null;
        }

        public async Task<ActionResult<IEnumerable<int>>> LoadVisitasDia()
        {
            string sqlConStr = "Server=localhost;user=root;password=1234;Database=mydb_filesexport";
            using var connection = new MySqlConnection(sqlConStr);
            //open connection
            await connection.OpenAsync();

            // retorna o id da ultima encomenda feita
            string query = $@"select * from view_final";
            using var command = new MySqlCommand(query, connection);
            using var reader = await command.ExecuteReaderAsync();

            //top10lstView.Items.Clear();
            while (await reader.ReadAsync())
            {
                string[] row =
                {
                    reader.GetString(0),
                    reader.GetInt32(1).ToString(),
                    reader.GetInt32(2).ToString(),
                    reader.GetFloat(3).ToString()

                };

                ListViewItem item = new ListViewItem(row);
                visitaslstView.Items.Add(item);
            }
            //value =reader.GetInt32(0);

            //Close the reader
            await reader.CloseAsync();
            //Close connection
            await connection.CloseAsync();

            return null;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void DashConsultas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
