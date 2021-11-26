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
        public async Task<ActionResult<IEnumerable<int>>> AddEncPro([FromBody] EncPro encpro)
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

        //------------------------------------------------------------------------------------

        [HttpGet]
        [Route("getEncomendaDetailsById/{idEnc}")]
        public async Task<ActionResult<IEnumerable<int>>> GetEncomendaDetails([FromRoute] string idEnc)
        {
            //TODO: verificar se a encomends já existe
            int intIdEnc;
            intIdEnc = Int32.Parse(idEnc);

            string sqlConStr = "Server=localhost;user=root;password=1234;Database=mydb_isi";
            using var connection = new MySqlConnection(sqlConStr);
            //open connection
            await connection.OpenAsync();

            // busca detalhes das encomendas por id destas
            string query = $@"
                            SELECT * FROM mydb_isi.encpro
                            WHERE idencomend = '{intIdEnc}'; ";
            using var command = new MySqlCommand(query, connection);
            using var reader = await command.ExecuteReaderAsync();

            List<EncPro> list = new();
            var value = 0;
            while (await reader.ReadAsync())
            {
                EncPro encPro = new();
                encPro.IdEncPro = reader.GetInt32(0);
                encPro.IdProduto = reader.GetInt32(1);
                encPro.IdEncomenda = reader.GetInt32(2);
                encPro.QuantidadeProduto = reader.GetInt32(3);

                list.Add(encPro);

            }


            //Close the reader
            await reader.CloseAsync();
            //Close connection
            await connection.CloseAsync();


            return Ok(list);
        }

    }
}
