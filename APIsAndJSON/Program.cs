using Newtonsoft.Json.Linq;
using System.Runtime.CompilerServices;
using static System.Net.WebRequestMethods;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 0; i < 5; i++)
            {
                QuoteGenerator.KanyeQuote();

                Console.WriteLine();

                QuoteGenerator.RonQuote();

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("========== Calling the OpenWeatherMap API for the current weather ==========");

            var weather = new OpenWeatherMapAPI();

            Console.WriteLine("Please select a city");
            var city = Console.ReadLine();
            Console.WriteLine("Please enter your api_Key");
            var apiKey = Console.ReadLine();
            weather.GetCurrentWeather(apiKey, city);

        }


        
    }
}
