using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewApiANEPC.Models;
using MySql.Data.MySqlClient;
// https://mysqlconnector.net/tutorials/connect-to-mysql/
namespace NewApiANEPC.Controllers
{
    [Route("api/cidades/")]
    [ApiController]
    public class CidadeController : Controller
    {

        [HttpGet]
        [Route("getAll")]
        public async Task<ActionResult<IEnumerable<Cidade>>> GetAllCidadesAsync()
        {
            string sqlConStr = "Server=localhost;user=root;password=1234;Database=mydb_isi";
            using var connection = new MySqlConnection(sqlConStr);
            await connection.OpenAsync();

            string query = @"
                            SELECT cidade_nome 
                            FROM mydb_isi.cidade;";
            using var command = new MySqlCommand(query, connection);
            using var reader = await command.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                var value = reader.GetValue(0);
                return Ok(value);
            }


            return Ok();
        }
    }
}
