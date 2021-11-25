using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using NewApiANEPC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewApiANEPC.Controllers
{
    [Route("api/produtos")]
    [ApiController]
    public class ProdutoController : Controller
    {
        /// <summary>
        /// Returns all products in the database
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("getAll")]
        public async Task<ActionResult<IEnumerable<Produto>>> GetAllTeamsAsync()
        {
            string sqlConStr = "Server=localhost;user=root;password=1234;Database=mydb_isi";
            using var connection = new MySqlConnection(sqlConStr);
            List<Produto> list = new();
            //open connection
            await connection.OpenAsync();

            
            string query = @"
                            SELECT *
                            FROM mydb_isi.produto;";
            using var command = new MySqlCommand(query, connection);
            using var reader = await command.ExecuteReaderAsync();



            while (await reader.ReadAsync())
            {
                Produto p = new();
                p.IdProduto = reader.GetInt32(0);
                p.Descricao = reader.GetString(1);
                p.Preco = reader.GetFloat(2);

                list.Add(p);

            }


            //Close the reader
            await reader.CloseAsync();
            //Close connection
            await connection.CloseAsync();


            return Ok(list);
        }

        /// <summary>
        /// Returns the id of a product in the database, after searching for its id
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("getByName")]
        public async Task<ActionResult<IEnumerable<int>>> GetTeamByNameAsync(string productDescription)
        {
            string sqlConStr = "Server=localhost;user=root;password=1234;Database=mydb_isi";
            using var connection = new MySqlConnection(sqlConStr);
            //open connection
            await connection.OpenAsync();

            // retorna o id do produto, entrando o nome dele
            string query = $@"
                            SELECT idproduto 
                            FROM mydb_isi.produto
                            Where descricao like '{productDescription}'";
            using var command = new MySqlCommand(query, connection);
            using var reader = await command.ExecuteReaderAsync();

            var value = reader.GetInt32(0); ;


            //Close the reader
            await reader.CloseAsync();
            //Close connection
            await connection.CloseAsync();


            return Ok(value);
        }

        [HttpPost]
        [Route("addTeam")]
        public async Task<ActionResult<IEnumerable<int>>> AddTeam([FromBody] string productDescription, float price)
        {
            //TODO: verificar se o produto já existe


            string sqlConStr = "Server=localhost;user=root;password=1234;Database=mydb_isi";
            using var connection = new MySqlConnection(sqlConStr);

            string num = price.ToString();
            num = num.Replace(',', '.');   // na base de dados só aceita com ponto em vez de virgula
            float preco = float.Parse(num);
            //open connection
            await connection.OpenAsync();

            // nova entrada na tabela produto, adiciona um produto
            string query = $@"
                            INSERT INTO `mydb_isi`.`produto` (`descricao`, `preco`) VALUES ('{productDescription}', '{preco}'); ";
            using var command = new MySqlCommand(query, connection);
            using var reader = await command.ExecuteReaderAsync();




            //Close the reader
            await reader.CloseAsync();
            //Close connection
            await connection.CloseAsync();


            return Ok();
        }

        //------------------------------------------------------------------------------------

        [HttpPut]
        [Route("editTeam")]
        public async Task<ActionResult<IEnumerable<int>>> EditTeam([FromBody] Produto product)
        {
            //TODO: verificar se o produto já existe


            string sqlConStr = "Server=localhost;user=root;password=1234;Database=mydb_isi";
            using var connection = new MySqlConnection(sqlConStr);
            //open connection
            await connection.OpenAsync();

            // nova entrada na tabela produto, edita um produto
            string query = $@"
                            UPDATE `mydb_isi`.`produto` SET `preco` = '{product.Preco}' WHERE (`idproduto` = '{product.IdProduto}'); ";
            using var command = new MySqlCommand(query, connection);
            using var reader = await command.ExecuteReaderAsync();




            //Close the reader
            await reader.CloseAsync();
            //Close connection
            await connection.CloseAsync();


            return Ok();
        }

        //---------------------------------------------------------------------------------------

        [HttpDelete]
        [Route("deleteTeam/{productId}")]
        // [FromRoute] onde vai buscar o parametro
        public async Task<ActionResult<IEnumerable<int>>> DeleteTeam([FromRoute] int productId)
        {
            //TODO: verificar se a cidade já existe


            string sqlConStr = "Server=localhost;user=root;password=1234;Database=mydb_isi";
            using var connection = new MySqlConnection(sqlConStr);
            //open connection
            await connection.OpenAsync();

            // nova entrada na tabela equipa, adiciona uma equipa
            string query = $@"
                            DELETE FROM `mydb_isi`.`produto` WHERE(`idproduto` = '{productId}'); ";
            using var command = new MySqlCommand(query, connection);
            using var reader = await command.ExecuteReaderAsync();



            //Close the reader
            await reader.CloseAsync();
            //Close connection
            await connection.CloseAsync();


            return Ok();
        }
    }
}
