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
        /// Reads a json file
        /// Source: https://www.delftstack.com/howto/csharp/read-json-file-in-csharp/
        /// </summary>
        public static void ReadJsonFile(string filepath)
        {
            //StreamReader stream = new(filepath);
            //string jsonStr = stream.ReadToEnd();

           
            string jsonString = File.ReadAllText(filepath);

            Isolado isolado;
            List<Isolado> isolados = new();
            Dictionary<string, Dictionary<string, string>>  all;


            all = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string,string>>>(jsonString, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });

            foreach (KeyValuePair<string, Dictionary<string,string>> dicc1 in all)
            {
                MessageBox.Show($"foreach de fora key{dicc1.Value}");
                MessageBox.Show($"foreach de fora key{dicc1.Key}");
                //pegar no value de cada key e deserializar aqui


                //foreach (KeyValuePair<string, string>dicc2 in dicc1.Value)
                //{
                //    //ordem: idEquipa -> idPessoa -> firstname -> lastname -> data -> respeitou
                //    MessageBox.Show($"foreach de dentro key{dicc2.Key}");
                //    MessageBox.Show($"foreach de dentro value: {dicc2.Value}");
                    

                //}
                
            }

            //JsonDocument docJson = JsonDocument.Parse(jsonStr);
            //MessageBox.Show($"data: {}");
        }
    }
}
