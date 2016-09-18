using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World - web");

            var host = new WebHostBuilder()
            .UseKestrel()
            .Configure(app => 
                {app.Run(c => c.Response.WriteAsync("Hello"));
                })
            .Build();
            host.Run();
        }
    }
}
