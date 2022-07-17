using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;

namespace KanyeREST
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();

            var quote = new QuoteGenerator(client);

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Kanye: {quote.Kanye()}");
                Console.WriteLine("-----");
                Console.WriteLine($"Ron: {quote.Ron()}");
                Console.WriteLine("-----");
            }
        }
    }
}
