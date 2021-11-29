using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using NewApiANEPC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewApiANEPC.Controllers
{
    [Route("api/encomendas")]
    [ApiController]
    public class EncomendaController : Controller
    {
        /// <summary>
        /// Returns all cities in the database
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("getAll")]
        public async Task<ActionResult<IEnumerable<Cidade>>> GetAllEncomendasAsync()
        {
            string sqlConStr = "Server=localhost;user=root;password=1234;Database=mydb_isi";
            using var connection = new MySqlConnection(sqlConStr);
            List<Encomenda> list = new();
            //open connection
            await connection.OpenAsync();

            //cidade_nome ------> como estava antes no select
            string query = @"
                            SELECT * FROM mydb_isi.encomenda;";
            using var command = new MySqlCommand(query, connection);
            using var reader = await command.ExecuteReaderAsync();



            while (await reader.ReadAsync())
            {
                Encomenda enc = new();
                enc.IdEncomenda = reader.GetInt32(0);
                enc.IdEquipa = reader.GetInt32(1);
                enc.Entregue = reader.GetBoolean(2);

                list.Add(enc);

            }


            //Close the reader
            await reader.CloseAsync();
            //Close connection
            await connection.CloseAsync();


            return Ok(list);
        }

        /// <summary>
        /// Returns the id of the last encomenda
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("getLastId")]
        public async Task<ActionResult<IEnumerable<int>>> GetLastEncomendaIdAsync()
        {
            string sqlConStr = "Server=localhost;user=root;password=1234;Database=mydb_isi";
            using var connection = new MySqlConnection(sqlConStr);
            //open connection
            await connection.OpenAsync();

            // retorna o id da ultima encomenda feita
            string query = $@"
                            SELECT idencomenda FROM mydb_isi.encomenda ORDER BY idencomenda DESC LIMIT 1";
            using var command = new MySqlCommand(query, connection);
            using var reader = await command.ExecuteReaderAsync();

            int value=0;

            while (await reader.ReadAsync())
            {
                //value = reader.GetValue(0);
                //Value(int) of the last encomenda id
                value = reader.GetInt32(0);

            }
            //value =reader.GetInt32(0);

            //Close the reader
            await reader.CloseAsync();
            //Close connection
            await connection.CloseAsync();


            return Ok(value);
        }

        [HttpPost]
        [Route("addEncomenda")]
        public async Task<ActionResult<IEnumerable<int>>> AddEncomenda([FromBody] int equipaId)
        {
            //TODO: verificar se a encomends já existe


            string sqlConStr = "Server=localhost;user=root;password=1234;Database=mydb_isi";
            using var connection = new MySqlConnection(sqlConStr);
            //open connection
            await connection.OpenAsync();

            // nova entrada na tabela cidades, adiciona uma cidade
            string query = $@"
                            INSERT INTO `mydb_isi`.`encomenda` (`idequipa`, `entregue`) VALUES ('{equipaId}', '0'); ";
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
        [Route("editEncomenda")]
        public async Task<ActionResult<IEnumerable<int>>> EditEncomenda([FromBody] Encomenda enco)
        {
            //TODO: verificar se a encomenda existe


            string sqlConStr = "Server=localhost;user=root;password=1234;Database=mydb_isi";
            using var connection = new MySqlConnection(sqlConStr);
            //open connection
            await connection.OpenAsync();

            // nova entrada na tabela encomenda, altera o estado de entrega de uma encomenda
            string query = $@"
                            UPDATE `mydb_isi`.`encomenda` SET `entregue` = '1' WHERE (`idencomenda` = {enco.IdEncomenda}); ";
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
