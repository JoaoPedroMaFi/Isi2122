using SoapDgs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SoapDgs.Sevices
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "Client" no arquivo de código, svc e configuração ao mesmo tempo.
    // OBSERVAÇÃO: Para iniciar o cliente de teste do WCF para testar esse serviço, selecione Client.svc ou Client.svc.cs no Gerenciador de Soluções e inicie a depuração.
    public class Client : IClient
    {
        public Person Get()
        {
            throw new NotImplementedException();
        }

        public List<Person> GetAll(int idPerson)
        {
            throw new NotImplementedException();
        }

        public void IndicateInfetion(string firstName, string lastName, int idEquipa)
        {
            InsertNewInfected(firstName, lastName, idEquipa);
            //string strCon = @"server=localhost;user id=root;database=mydb_isi";


            //try
            //{
            //    MySqlConnection connection = new MySqlConnection(strCon);
            //    string strSQL = "INSERT INTO INFECTADO (FIRSTNAME,LASTNAME, IDEQUIPA) VALUES(@FIRSTNAME,@LASTANAME, @IDEQUIPA)";

            //    MySqlCommand command = new MySqlCommand(strSQL, connection);
            //    command.Parameters.AddWithValue("@FIRSTNAME", firstName);
            //    command.Parameters.AddWithValue("@LASTNAME", lastName);
            //    command.Parameters.AddWithValue("@IDEQUIPA", idEquipa);

            //    connection.Open();
            //    command.ExecuteNonQuery();
            //    connection.Close();
            //}
            //catch (Exception ex)
            //{
            //    throw new Exception("Error: " + ex);

            //}



        }

        public void IndicateInfetionList(List<Person> list)
        {
            throw new NotImplementedException();
        }

        private bool InsertNewInfected(string name, string lastname, int idEquipa)
        {

            return true;
        }
    }
}

