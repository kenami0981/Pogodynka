using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Pogodynka.Model
{
    internal class Weather
    {
        [JsonProperty("main")]
        public MainData Main { get; set; }

        [JsonProperty("weather")]
        public WeatherDescribe[] WeatherD { get; set; }

        public class MainData {
            [JsonProperty("temp")]
            public double temperature { get; set; }
            [JsonProperty("pressure")]
            public double pressure { get; set; }
            [JsonProperty("humidity")]
            public double humidity { get; set; }
        }
        public class WeatherDescribe
        {
            [JsonProperty("description")]
            public string Description { get; set; }
        }

        }
}
