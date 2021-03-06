using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewApiANEPC.Models;
using MySqlConnector;
//using MySql.Data.MySqlClient;

// https://mysqlconnector.net/tutorials/connect-to-mysql/
namespace NewApiANEPC.Controllers
{
    [Route("api/cidades/")]
    [ApiController]
    public class CidadeController : Controller
    {
        /// <summary>
        /// Returns all cities in the database
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("getAll")]
        public async Task<ActionResult<IEnumerable<Cidade>>> GetAllCidadesAsync()
        {
            string sqlConStr = "Server=localhost;user=root;password=1234;Database=mydb_isi";
            using var connection = new MySqlConnection(sqlConStr);
            List<Cidade> list = new();
            //open connection
            await connection.OpenAsync();

            //cidade_nome ------> como estava antes no select
            string query = @"
                            SELECT *
                            FROM mydb_isi.cidade;";
            using var command = new MySqlCommand(query, connection);
            using var reader = await command.ExecuteReaderAsync();

            

            while (await reader.ReadAsync())
            {
                Cidade c = new();
                c.IdCidade = reader.GetInt32(0);
                c.CidadeNome = reader.GetString(1);

                list.Add(c);
              
            }


            //Close the reader
            await reader.CloseAsync();
            //Close connection
            await connection.CloseAsync();


            return Ok(list);
        }

        /// <summary>
        /// Returns the id of a city in the database, after searching for its id
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("getId")]
        public async Task<ActionResult<IEnumerable<int>>> GetCidadesIdAsync()
        {
            string sqlConStr = "Server=localhost;user=root;password=1234;Database=mydb_isi";
            using var connection = new MySqlConnection(sqlConStr);
            //open connection
            await connection.OpenAsync();

            // retorna o id da cidade, entrando o nome dela
            string query = $@"
                            SELECT idcidade FROM mydb_isi.cidade ORDER BY idcidade DESC LIMIT 1";
            using var command = new MySqlCommand(query, connection);
            using var reader = await command.ExecuteReaderAsync();




            while (await reader.ReadAsync())
            {

                var value = reader.GetValue(0);
            }


            //Close the reader
            await reader.CloseAsync();
            //Close connection
            await connection.CloseAsync();


            return Ok();
        }

        [HttpPost]
        [Route("addCity")]
        public async Task<ActionResult<IEnumerable<int>>> AddCity([FromBody]string cityName)
        {
            //TODO: verificar se a cidade já existe


            string sqlConStr = "Server=localhost;user=root;password=1234;Database=mydb_isi";
            using var connection = new MySqlConnection(sqlConStr);
            //open connection
            await connection.OpenAsync();

            // nova entrada na tabela cidades, adiciona uma cidade
            string query = $@"
                            INSERT INTO `mydb_isi`.`cidade` (`cidade_nome`) VALUES ('{cityName}'); ";
            using var command = new MySqlCommand(query, connection);
            using var reader = await command.ExecuteReaderAsync();

            var value = 0;
            while (await reader.ReadAsync())
            {

                // value = reader.GetValue(0);
            }


            //Close the reader
            await reader.CloseAsync();
            //Close connection
            await connection.CloseAsync();


            return Ok(value);
        }

        //------------------------------------------------------------------------------------

        [HttpPut]
        [Route("editCity")]
        public async Task<ActionResult<IEnumerable<int>>> EditCity([FromBody]Cidade city)
        {
            //TODO: verificar se a cidade já existe


            string sqlConStr = "Server=localhost;user=root;password=1234;Database=mydb_isi";
            using var connection = new MySqlConnection(sqlConStr);
            //open connection
            await connection.OpenAsync();

            // nova entrada na tabela cidades, adiciona uma cidade
            string query = $@"
                            UPDATE `mydb_isi`.`cidade` SET `cidade_nome` = '{city.CidadeNome}' WHERE (`idcidade` = '{city.IdCidade}'); ";
            using var command = new MySqlCommand(query, connection);
            using var reader = await command.ExecuteReaderAsync();

            var value = 0;
       

            //Close the reader
            await reader.CloseAsync();
            //Close connection
            await connection.CloseAsync();


            return Ok(value);
        }

        //---------------------------------------------------------------------------------------

        [HttpDelete]
        [Route("deleteCity/{cityId}")]
        // [FromRoute] onde vai buscar o parametro
        public async Task<ActionResult<IEnumerable<int>>> DeleteCity([FromRoute] int cityId)
        {
            //TODO: verificar se a cidade já existe


            string sqlConStr = "Server=localhost;user=root;password=1234;Database=mydb_isi";
            using var connection = new MySqlConnection(sqlConStr);
            //open connection
            await connection.OpenAsync();

            // nova entrada na tabela cidades, adiciona uma cidade
            string query = $@"
                            DELETE FROM `mydb_isi`.`cidade` WHERE(`idcidade` = '{cityId}'); ";
            using var command = new MySqlCommand(query, connection);
            using var reader = await command.ExecuteReaderAsync();

            var value = 0;
           
            //Close the reader
            await reader.CloseAsync();
            //Close connection
            await connection.CloseAsync();


            return Ok(value);
        }

    }
}
