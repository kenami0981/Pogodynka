using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Pogodynka.Model
{
    internal class ApiClient
    {
        private static readonly HttpClient client = new HttpClient();
        private readonly string apiKey = "b318089b504f0e720c03b77d53a4cc41";

        public async Task<string> GetWeatherData(string city) { 
            string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric&lang=pl";
            
            HttpResponseMessage response = await client.GetAsync(url);
            if(response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                return result;
            }
            else
            {
                return $"Błąd: {response.StatusCode}";
            }
            
        }

    }
}
