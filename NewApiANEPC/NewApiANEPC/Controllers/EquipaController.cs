using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using NewApiANEPC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewApiANEPC.Controllers
{
    [Route("api/equipas")]
    [ApiController]
    public class EquipaController : Controller
    {
        /// <summary>
        /// Returns all teams in the database
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("getAll")]
        public async Task<ActionResult<IEnumerable<Equipa>>> GetAllTeamsAsync()
        {
            string sqlConStr = "Server=localhost;user=root;password=1234;Database=mydb_isi";
            using var connection = new MySqlConnection(sqlConStr);
            List<Equipa> list = new();
            //open connection
            await connection.OpenAsync();

            //equipa_nome ------> como estava antes no select
            string query = @"
                            SELECT *
                            FROM mydb_isi.equipa;";
            using var command = new MySqlCommand(query, connection);
            using var reader = await command.ExecuteReaderAsync();



            while (await reader.ReadAsync())
            {
                Equipa e = new();
                e.IdEquipa = reader.GetInt32(0);
                e.IdCidade = reader.GetInt32(1);
                e.NomeEquipa = reader.GetString(2);

                list.Add(e);

            }


            //Close the reader
            await reader.CloseAsync();
            //Close connection
            await connection.CloseAsync();


            return Ok(list);
        }

        /// <summary>
        /// Returns the id of a team in the database, after searching for its id
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("getByName")]
        public async Task<ActionResult<IEnumerable<int>>> GetTeamByNameAsync(string teamName)
        {
            string sqlConStr = "Server=localhost;user=root;password=1234;Database=mydb_isi";
            using var connection = new MySqlConnection(sqlConStr);
            //open connection
            await connection.OpenAsync();

            // retorna o id da equipa, entrando o nome dela
            string query = $@"
                            SELECT idequipa 
                            FROM mydb_isi.equipa
                            Where equipa_nome like '{teamName}'";
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
        public async Task<ActionResult<IEnumerable<int>>> AddTeam([FromBody] string teamName)
        {
            //TODO: verificar se a equipa já existe


            string sqlConStr = "Server=localhost;user=root;password=1234;Database=mydb_isi";
            using var connection = new MySqlConnection(sqlConStr);
            //open connection
            await connection.OpenAsync();

            // nova entrada na tabela equipa, adiciona uma equipa
            string query = $@"
                            INSERT INTO `mydb_isi`.`equipa` (`equipa_nome`) VALUES ('{teamName}'); ";
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
        public async Task<ActionResult<IEnumerable<int>>> EditTeam([FromBody] Equipa team)
        {
            //TODO: verificar se a equipa já existe


            string sqlConStr = "Server=localhost;user=root;password=1234;Database=mydb_isi";
            using var connection = new MySqlConnection(sqlConStr);
            //open connection
            await connection.OpenAsync();

            // nova entrada na tabela equipa, adiciona uma equipa
            string query = $@"
                            UPDATE `mydb_isi`.`equipa` SET `equipa_nome` = '{team.NomeEquipa}' WHERE (`idequipa` = '{team.IdEquipa}'); ";
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
        [Route("deleteTeam/{teamId}")]
        // [FromRoute] onde vai buscar o parametro
        public async Task<ActionResult<IEnumerable<int>>> DeleteTeam([FromRoute] int teamId)
        {
            //TODO: verificar se a equipa já existe


            string sqlConStr = "Server=localhost;user=root;password=1234;Database=mydb_isi";
            using var connection = new MySqlConnection(sqlConStr);
            //open connection
            await connection.OpenAsync();

            // nova entrada na tabela equipa, adiciona uma equipa
            string query = $@"
                            DELETE FROM `mydb_isi`.`equipa` WHERE(`idequipa` = '{teamId}'); ";
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
