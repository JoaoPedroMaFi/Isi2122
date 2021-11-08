using Dashboard.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace Dashboard.Methods
{
    public static class RestHelper
    {
        private static readonly string baseURL = "https://covid19-api.vost.pt/Requests/";

        #region get_counties
        public static async Task<String> Get_counties()
        {
            using (HttpClient client = new())
            {
                using (HttpResponseMessage res = await client.GetAsync(baseURL + "get_county_list/"))
                {
                    if (res.IsSuccessStatusCode)
                    {

                        using (HttpContent content = res.Content)
                        {
                            string data = await content.ReadAsStringAsync();
                            if (data != null)
                            {
                                return data;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show(((int)res.StatusCode) + " " + res.StatusCode.ToString());
                        return string.Empty;

                    }
                }


            }
            return string.Empty;

        }

        public static RichTextBox BeautyJson(string jsonstr, RichTextBox txtBox)
        {

            City city = new City();

            city.Name = System.Text.Json.JsonSerializer.Deserialize<string[]>(jsonstr, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });

            foreach (string s in city.Name)
            {
                txtBox.Text += s + "\n";
            }
            return txtBox;
        }
        #endregion

        #region get_entry_two_dates
        public static async Task<String> Get_Entry_Two_Dates(string date1, string date2)
        {
            using (HttpClient client = new())
            {
                string urlFinal = $"get_entry/{date1}_until_{date2}";

                using (HttpResponseMessage res = await client.GetAsync(baseURL + urlFinal))
                {
                    if (res.IsSuccessStatusCode)
                    {
                        using (HttpContent content = res.Content)
                        {
                            string data = await content.ReadAsStringAsync();
                            if (data != null)
                            {
                                return data;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show(((int)res.StatusCode) + " " + res.StatusCode.ToString());
                        return string.Empty;
                    }
                }
            }
            return string.Empty;
        }

        public static RichTextBox BeautyJsonDate(string jsonstr, RichTextBox txtBox)
        {

            if (string.IsNullOrEmpty(jsonstr))
            {
                return txtBox;
            }
            else
            {
                var deserialized = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, string>>>(jsonstr);

                foreach (KeyValuePair<string, Dictionary<string, string>> dictionary1 in deserialized)
                {

                    txtBox.Text += dictionary1.Key + "\n";
                    foreach (KeyValuePair<string, string> dictionary2 in dictionary1.Value)
                    {
                        txtBox.Text += "\t";
                        txtBox.Text += dictionary2.Key + ":";
                        if (dictionary2.Value == null)
                        {
                            txtBox.Text += "null\n";
                        }
                        else
                        {
                            txtBox.Text += dictionary2.Value + "\n";
                        }

                    }

                }
            }

            return txtBox;
        }
        #endregion

        #region entry_one_date
        public static async Task<String> Get_Entry_One_Date(string date1)
        {
            using (HttpClient client = new())
            {
                string urlFinal = $"get_entry/{date1}";

                using (HttpResponseMessage res = await client.GetAsync(baseURL + urlFinal))
                {
                    if (res.IsSuccessStatusCode)
                    {
                        using (HttpContent content = res.Content)
                        {
                            string data = await content.ReadAsStringAsync();
                            if (data != null)
                            {
                                return data;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show(((int)res.StatusCode) + " " + res.StatusCode.ToString());
                        return string.Empty;
                    }
                }
            }
            return string.Empty;
        }
        #endregion

        #region get_entry_counties
        public static async Task<String> Get_Entry_Counties(string date1, string date2)
        {
            using (HttpClient client = new())
            {
                string urlFinal = $"get_entry_counties/{date1}_until_{date2}";

                using (HttpResponseMessage res = await client.GetAsync(baseURL + urlFinal))
                {
                    if (res.IsSuccessStatusCode)
                    {
                        using (HttpContent content = res.Content)
                        {
                            string data = await content.ReadAsStringAsync();
                            if (data != null)
                            {
                                return data;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show(((int)res.StatusCode) + " " + res.StatusCode.ToString());
                        return string.Empty;
                    }
                }
            }
            return string.Empty;
        }

        public static RichTextBox BeautyJsonCounties(string jsonstr, RichTextBox txtBox)
        {
            if (string.IsNullOrEmpty(jsonstr))
            {
                return txtBox;
            }
            else
            {
                var deserialized = JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(jsonstr);

                foreach (var list in deserialized)
                {

                    foreach (KeyValuePair<string, string> dictionary in list)
                    {
                        txtBox.Text += dictionary.Key + ":";
                        if (dictionary.Value == null)
                        {
                            txtBox.Text += "null\n";
                        }
                        else
                        {
                            txtBox.Text += dictionary.Value + "\n";
                        }
                    }
                    txtBox.Text += "\n";

                }
            }

            return txtBox;
        }
        #endregion

        #region get_entry_one_county

        public static async Task<String> Get_Entry_One_County(string date1, string date2, string county)
        {
            using (HttpClient client = new())
            {
                string urlFinal = $"get_entry_counties/{date1}_until_{date2}_{county}";

                using (HttpResponseMessage res = await client.GetAsync(baseURL + urlFinal))
                {
                    if (res.IsSuccessStatusCode)
                    {
                        using (HttpContent content = res.Content)
                        {
                            string data = await content.ReadAsStringAsync();
                            if (data != null)
                            {
                                return data;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show(((int)res.StatusCode) + " " + res.StatusCode.ToString());
                        return string.Empty;
                    }
                }
            }
            return string.Empty;
        }

        #endregion

        #region dataSet
        public static async Task<String> Get_Dataset()
        {
            using (HttpClient client = new())
            {
                using (HttpResponseMessage res = await client.GetAsync(baseURL + "get_full_dataset"))
                {
                    if (res.IsSuccessStatusCode)
                    {
                        using (HttpContent content = res.Content)
                        {
                            string data = await content.ReadAsStringAsync();
                            if (data != null)
                            {
                                return data;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show(((int)res.StatusCode) + " " + res.StatusCode.ToString());
                        return string.Empty;
                    }
                }


            }
            return string.Empty;

        }
        #endregion


        #region get_status
        public static async Task<String> Get_StatusApi()
        {
            using (HttpClient client = new())
            {
                string urlFinal = "get_status";

                using (HttpResponseMessage res = await client.GetAsync(baseURL + urlFinal))
                {
                    if (res.IsSuccessStatusCode)
                    {
                        using (HttpContent content = res.Content)
                        {
                            string data = await content.ReadAsStringAsync();
                            if (data != null)
                            {
                                return data;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show(((int)res.StatusCode) + " " + res.StatusCode.ToString());
                        return string.Empty;
                    }
                }
            }
            return string.Empty;
        }

        public static RichTextBox BeautyJsonStatus(string jsonstr, RichTextBox txtBox)
        {

            if (string.IsNullOrEmpty(jsonstr))
            {
                return txtBox;
            }
            else
            {
                var deserialized = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonstr);

                foreach (KeyValuePair<string, string> dictionary in deserialized)
                {
                    txtBox.Text += dictionary.Key + " : ";
                    txtBox.Text += dictionary.Value + "\n";

                }
     
            }

            return txtBox;
        }
        #endregion
    }


}
