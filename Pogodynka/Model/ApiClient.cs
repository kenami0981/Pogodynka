using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Pogodynka.Model
{
    internal class ApiClient
    {
        private static readonly HttpClient client = new HttpClient();
        private readonly string apiKey;

        public ApiClient()
        {
            var json = File.ReadAllText("C:\\Users\\HP\\Desktop\\Programowanie I\\WPF\\Pogodynka\\Pogodynka\\appsettings.json");
            var config = JObject.Parse(json);
            apiKey = config["OpenWeatherMapApiKey"]?.ToString();
        }

        public async Task<Weather> GetWeatherData(string city) { 
            string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric&lang=pl";
            
            HttpResponseMessage response = await client.GetAsync(url);
            if(response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                Weather weather = JsonConvert.DeserializeObject<Weather>(result);
                return weather;
            }
            else
            {
                throw new Exception(response.StatusCode.ToString());
            }
            
        }

    }
}
