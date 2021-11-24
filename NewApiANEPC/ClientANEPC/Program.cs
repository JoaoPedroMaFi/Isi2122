using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientANEPC
{
    public static class Program
    {
        private static string host = "localhost";
        private static int port = 44359;
        private static string mediaType = "application/json";
        private static HttpClient client = new();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Client headers preparation
            client.DefaultRequestHeaders.Accept.Clear(); //clears all headers
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(mediaType));

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
           

        }

        //public static void getAllCities()
        //{
        //    string requestURI;
        //    HttpResponseMessage response;

        //    requestURI = $"https://{host}:{port.ToString().Trim()}/api/cidades/getAll";

        //    try
        //    {
        //        response = client.GetAsync(requestURI).Result;
        //        if (!response.StatusCode.Equals(HttpStatusCode.OK))
        //        {
        //            throw new Exception(response.Content.ReadAsStringAsync().Result);
        //        }
                
        //        listBox1.Items.Clear();
        //        foreach (var message in messages)
        //        {
        //            listBox1.Items.Add($"SenderId: {message.sender_id}: {message.content} (MsgId = {message.message_id})");
        //            listBox1.Refresh();
        //        }

        //        response.Content.ReadAsStringAsync();
        //        //MessageBox.Show(response.Content.ReadAsStringAsync().Result);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        MessageBox.Show(ex.StackTrace);
        //    }
        //}
    }
}
