using Microsoft.Owin.Hosting;
using System;

namespace Repligram
{
    public class Process
    {
        public static void Main(string[] args)
        {
            using (WebApp.Start<Start>("http://127.0.0.1:8080"))
            {
                Console.Title = "Repligram";
                Console.WriteLine("Repligram Backend v1.0\nAuthor: @karmakittenx\nAPI Running on Port 8080");
                Console.WriteLine("");
                Console.ReadKey();
            }
        }
    }
}