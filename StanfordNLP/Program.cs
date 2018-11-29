using Console = System.Console;
using Microsoft.Owin.Hosting;

namespace StanfordNLP
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseAddress = "http://localhost:9000/";

            // Start OWIN host 
            using (WebApp.Start<Startup>(url: baseAddress))
            {
                Console.WriteLine($"Running server at: {baseAddress}");
                Console.WriteLine("Press any key to terminate.");
                Console.ReadLine();
            }
        }
    }
}
