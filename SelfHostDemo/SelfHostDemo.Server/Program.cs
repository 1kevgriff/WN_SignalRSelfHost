using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfHostDemo.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            string localAddress = "http://localhost:8080";
            using (WebApp.Start(localAddress))
            {
                Console.WriteLine("Listening at " + localAddress);
                Console.ReadLine();
            }
        }
    }
}
