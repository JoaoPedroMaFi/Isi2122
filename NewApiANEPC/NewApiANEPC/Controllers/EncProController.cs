using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using NewApiANEPC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewApiANEPC.Controllers
{
    [Route("api/encpro/")]
    [ApiController]
    public class EncProController : Controller
    {
        [HttpPost]
        [Route("addEncPro")]
        public async Task<ActionResult<IEnumerable<int>>> AddCity([FromBody] EncPro encpro)
        {
            string sqlConStr = "Server=localhost;user=root;password=1234;Database=mydb_isi";
            using var connection = new MySqlConnection(sqlConStr);
            //open connection
            await connection.OpenAsync();

            // nova entrada na tabela de relacao encpro
            string query = $@"
                            INSERT INTO `mydb_isi`.`encpro` (`idproduct`, `idencomend`, `quantidade`) VALUES ('{encpro.IdProduto}', '{encpro.IdEncomenda}', '{encpro.QuantidadeProduto}'); ";
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
