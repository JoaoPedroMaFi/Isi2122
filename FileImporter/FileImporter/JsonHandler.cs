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
            Dictionary<int, Dictionary<string, string>>  all;


            all = JsonSerializer.Deserialize<Dictionary<int, Dictionary<string,string>>>(jsonString, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });
            foreach (dynamic i in all)
            {
                MessageBox.Show($"data: {i.Idisolado}");
                MessageBox.Show($"data: {i.Idequipa}");
                MessageBox.Show($"data: {i.Firstname}");
                MessageBox.Show($"data: {i.Lastname}");
                MessageBox.Show($"data: {i.Data}");
                MessageBox.Show($"data: {i.Respeitou}");
            }




            //JsonDocument docJson = JsonDocument.Parse(jsonStr);
            //MessageBox.Show($"data: {}");
        }
    }
}
