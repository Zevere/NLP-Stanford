using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using java.util;
using java.io;
using edu.stanford.nlp.pipeline;
using Console = System.Console;
using System.Text.RegularExpressions;
using Microsoft.Owin.Hosting;
using System.Net.Http;

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
                // Create HttpCient and make a request to api/values 
              //  HttpClient client = new HttpClient();

              //  var response = client.GetAsync(baseAddress + "api/values/" + "Please create a task in the name of Mamun").Result;

              ////  Console.WriteLine(response);
              //  Console.WriteLine(response.Content.ReadAsStringAsync().Result);
                Console.ReadLine();
            }
        }

       
    }
}
