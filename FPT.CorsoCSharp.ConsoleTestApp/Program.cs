using FPT.CorsoCSharp.DomainModel;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
// using System.Dynamic;

namespace FPT.CorsoCSharp.ConsoleTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Yahoo
            // dynamic meteo = svc.Get(42, 9.85);
            // meteo.Forecast[1].Pressure

            dynamic obj2 = new DinamicoCustom();
            Console.WriteLine(obj2.NonEsiste);

            dynamic obj1 = new ExpandoObject();
            obj1.TipoPagamento = "subito!";
            obj1.DataFattura = DateTime.Now.AddDays(-1);
            obj1.GoalHomeTeam = 9;
            Console.WriteLine(obj1.GoalHomeTeam);

            IDictionary<string, object> dict = (IDictionary<string, object>)obj1;
            dict.Remove("GoalHomeTeam");
            Console.WriteLine(dict["TipoPagamento"]);
            




            dynamic obj = new Fattura();
            Type t = obj.GetType();
            obj.Numero = "900/2018";
            //obj.TipoPagamento = "subito!";
            //Console.WriteLine(obj.TipoPagamento);
            double r1 = obj.Somma(5);
            double r2 = obj.Somma(5, 9.0, "");

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