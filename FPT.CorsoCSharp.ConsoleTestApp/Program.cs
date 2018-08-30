using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FPT.CorsoCSharp.ConsoleTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-FR");
            Console.WriteLine(DateTime.Now.ToString("dddd dd MMMM yyyy"));

            Task.Run(() => {
                Console.WriteLine("Dal thread secondario:");
                Console.WriteLine(DateTime.Now.ToString("dddd dd MMMM yyyy"));
            });

            Console.ReadLine();
        }
    }
}