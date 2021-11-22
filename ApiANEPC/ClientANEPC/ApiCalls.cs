using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientANEPC.Models;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;

namespace ClientANEPC
{
    public class ApiCalls
    {
        public static async Task<List<cidade>> ListCities()
        {
            //// Token Header
            //var authToken = new AuthenticationHeaderValue("Bearer", globalToken.token);
            //ApiHelper.ApiClient.DefaultRequestHeaders.Authorization = authToken;

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync("http://localhost:44356/cidades"))
            {
                if (response.IsSuccessStatusCode)
                {
                    //var messages = JsonConvert.DeserializeObject<Messages>(await response.Content.ReadAsStringAsync());//only retrieves from json response what is in our model
                    try
                    {
                        List<cidade> cidades = JsonConvert.DeserializeObject<List<cidade>>(await response.Content.ReadAsStringAsync());
                        return cidades;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                    return null;
                }
                else
                {
                    var code = response.StatusCode;
                    MessageBox.Show($"Something went wrong: HTTP Status: {code}");
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
