using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileImporter.Models;
using System.Windows.Forms;
//using Newtonsoft.Json;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FileImporter
{
    public static class JsonHandler
    {
        /// <summary>
        /// Reads a json file, transforms it into isolado objects
        /// Source: https://www.delftstack.com/howto/csharp/read-json-file-in-csharp/
        /// </summary>
        public static void ReadJsonFile(string filepath)
        {
           
            // Reads the json file into a string
            string jsonString = File.ReadAllText(filepath);

            // Variables
            Dictionary<string, Dictionary<string, string>>  all;
            List<string> diccValues = new(); 
            Isolado isolado = new();
            int count;

            // Deserialize the json string
            all = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string,string>>>(jsonString, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });

            // Getting to the values inside the json
            foreach (KeyValuePair<string, Dictionary<string,string>> dicc1 in all)
            {

                foreach (KeyValuePair<string, string> dicc2 in dicc1.Value)
                {
                    //ordem: idEquipa -> idPessoa -> firstname -> lastname -> data -> respeitou
                    MessageBox.Show($"foreach de dentro value: {dicc2.Value}");
                    diccValues.Add(dicc2.Value);
                }

            }

            // Counter for size of list containing json information
            count = diccValues.Count;

            // Fills the object 1 by 1 using the list
            for (int i = 0; i < count; i = i + 6)
            {
                isolado.Idequipa = Int32.Parse(diccValues[i]);
                isolado.Idisolado = Int32.Parse(diccValues[i + 1]);
                isolado.Firstname = diccValues[i + 2];
                isolado.Lastname = diccValues[i + 3];
                isolado.Data = diccValues[i + 4];
                isolado.Respeitou = Boolean.Parse(diccValues[i + 5]);

                //pegar em objeto e mandar p base de dados
            }
            
        }
    }
}
