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
            


        }


        
    }
}
