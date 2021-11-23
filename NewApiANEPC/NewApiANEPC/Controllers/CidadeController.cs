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
            //open connection
            await connection.OpenAsync();

            string query = @"
                            SELECT cidade_nome 
                            FROM mydb_isi.cidade;";
            using var command = new MySqlCommand(query, connection);
            using var reader = await command.ExecuteReaderAsync();

            List<string> list = new();
            string val2;
            while (await reader.ReadAsync())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    var value = reader.GetValue(i);
                    val2 = value.ToString();
                    list.Add(val2);
                }
            }
            

            //Close the reader
            await reader.CloseAsync();
            //Close connection
            await connection.CloseAsync();


            return Ok(list);
        }
    }
}
