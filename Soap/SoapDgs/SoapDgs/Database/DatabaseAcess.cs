using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoapDgs.Database
{
    public class DatabaseAcess
    {
        string strCon = @"server=localhost; user id=root; database=mydb_isi";

        public void InsertNewInfected(string firstName, string lastName, int idEquipa)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(strCon);
                string strSQL = "INSERT INTO INFECTADO (FIRSTNAME, LASTNAME, IDEQUIPA) VALUES(@FIRSTNAME, @LASTANAME, @IDEQUIPA)";

                MySqlCommand command = new MySqlCommand(strSQL, connection);
                command.Parameters.AddWithValue("@FIRSTNAME", firstName);
                command.Parameters.AddWithValue("@LASTNAME", lastName);
                command.Parameters.AddWithValue("@IDEQUIPA", idEquipa);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex);

            }


        }

        public void InsertNewSuspect(string firstName, string lastName, int id, int idInfetado)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(strCon);
                string strSQL = "INSERT INTO suspeito (FIRSTNAME, LASTNAME, id, idinfetado) VALUES(@FIRSTNAME, @LASTANAME, @idsuspeito, @idinfetado)";

                MySqlCommand command = new MySqlCommand(strSQL, connection);
                command.Parameters.AddWithValue("@FIRSTNAME", firstName);
                command.Parameters.AddWithValue("@LASTNAME", lastName);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@IDinfetado", idInfetado);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex);

            }


        }
    }
}