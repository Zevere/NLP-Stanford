using Console = System.Console;
using Microsoft.Owin.Hosting;
using System;

namespace StanfordNLP
{
    class Program
    {
        static void Main(string[] args)
        {
            var port = Environment.GetEnvironmentVariable("PORT") ?? "8080";
            string baseAddress = $"http://*:{port}/";

            // Start OWIN host 
            using (WebApp.Start<Startup>(baseAddress))
            {
                Console.WriteLine($"Running server at: {baseAddress}");
                Console.WriteLine("Press any key to terminate.");
                Console.ReadLine();
            }
        }
    }
}
