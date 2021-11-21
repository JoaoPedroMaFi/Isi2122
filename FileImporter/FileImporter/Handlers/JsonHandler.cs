using FileImporter.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FileImporter.Handlers
{
    public class JsonHandler
    {
        //public object JsonConvert { get; private set; }

        /// <summary>
        /// Reads a json file, transforms it into isolado objects
        /// Source: https://www.delftstack.com/howto/csharp/read-json-file-in-csharp/
        /// </summary>
        public List<Isolado> ReadJsonFile(string filepath)
        {

            // Reads the json file into a string
            string jsonString = File.ReadAllText(filepath);
            // variáveis
            Dictionary<int, Isolado> dictIsolados = new Dictionary<int, Isolado>();
            List<Isolado> isoladoslist = new List<Isolado>();

            // deserialize
            dictIsolados = JsonConvert.DeserializeObject<Dictionary<int, Isolado>>(jsonString);

            // Getting to the values inside the json
            foreach (KeyValuePair<int, Isolado> dicc2 in dictIsolados)
            {
                Isolado personIsolated = new Isolado();

                //MessageBox.Show($"foreach de dentro key:  {dicc2.Key}");

                //// get the utent number from do dicionary deserialized
                //MessageBox.Show($"foreach utentNumber:  {dicc2.Value.UtentNumber}");
                personIsolated.UtentNumber = dicc2.Value.UtentNumber;

                //// get the team id from do dicionary deserialized
                //MessageBox.Show($"foreach idequipa:  {dicc2.Value.Idequipa}");
                personIsolated.Idequipa = dicc2.Value.Idequipa;

                //// get the firstname of that person from do dicionary deserialized
                //MessageBox.Show($"foreach firstname:  {dicc2.Value.Firstname}");
                personIsolated.Firstname = dicc2.Value.Firstname;

                //// get the laststname of that person from do dicionary deserialized
                //MessageBox.Show($"foreach lastname:  {dicc2.Value.Lastname}");
                personIsolated.Lastname = dicc2.Value.Lastname;

                //// get the date of inspection from do dicionary deserialized
                //MessageBox.Show($"foreach lastname:  {dicc2.Value.Data}");
                personIsolated.Data = dicc2.Value.Data;

                //// get the status of the respect of isolation from do dicionary deserialized
                //MessageBox.Show($"foreach lastname:  {dicc2.Value.Respeitou}");
                personIsolated.Respeitou = dicc2.Value.Respeitou;

                // Add to a list
                isoladoslist.Add(personIsolated);

            }
            return isoladoslist;

        }


    }
}
