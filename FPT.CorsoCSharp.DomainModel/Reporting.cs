using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FPT.CorsoCSharp.DomainModel
{
    public class Reporting
    {
        public void Print<T>(T daStampare) where T : DomainObject
        {

        }

        public void Print<T1, T2>() where T1 : DomainObject
            where T2 : IDisposable
        {
            Stack<int> stack1;
            List<Fattura> fatt = new List<Fattura>();
            Dictionary<string, Fattura> dict = fatt.ToDictionary(f => f.Numero);
        }
    }
}