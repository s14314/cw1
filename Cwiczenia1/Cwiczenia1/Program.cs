using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Cwiczenia1
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var client = new HttpClient();
            var result = await client.GetAsync("https://www.pja.edu.pl");

            if(result.IsSuccessStatusCode)
            {
                var html = await result.Content.ReadAsStringAsync();
            }
        }
    }
}
