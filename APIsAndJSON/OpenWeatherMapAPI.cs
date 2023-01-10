using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    internal class OpenWeatherMapAPI
    {
        public void GetCurrentWeather(string api_Key, string city)
        {
            HttpClient client = new HttpClient();

            //var apiKey = "4e91788ad7afad2568e9ffdb2ebc2d4d";

            //Console.WriteLine("Please enter a city");
            //var cityName = Console.ReadLine();

            var weatherMapURL = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={api_Key}&units=imperial";

            var weatherResponse = client.GetStringAsync(weatherMapURL).Result;

            var weatherObject = JObject.Parse(weatherResponse);

            var temp = weatherObject["main"]["temp"];

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"The current temperature is {temp}");
        }
    }
}
