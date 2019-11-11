/*###############################################################
 *  File:           Program.cs
 *  Project :       NAD Assignment 4
 *  Programmer :    John Hall, James Milne
 *  Date :          11/10/2019
 *  
 *  Name:           Program
 *  Purpose:        Handles the entry point of the application
 * ##############################################################*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace IABRS
{
    public class Program
    {
        /// <summary>
        /// Application entry point
        /// </summary>
        /// <param name="args">arguments passed into the application</param>
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
