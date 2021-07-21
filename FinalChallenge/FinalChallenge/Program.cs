using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var stx = new StudentContext())
            {
                var stud = new Student() { StudentName = "Jakob Barnett", DateOfBirth=DateTime.Today, Grade = 5 };

                stx.Students.Add(stud);
                stx.SaveChanges();
            }




            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
