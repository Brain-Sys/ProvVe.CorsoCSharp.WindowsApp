using FPT.CorsoCSharp.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPT.CorsoCSharp.WindowsApp
{
    class Calcolatrice<T> where T : Fattura, IDisposable, new()
    {
        public double Somma(T x, T y)
        {
            T result = new T();

            return 0.0;
        }

        public T Somma(T x, T y, bool unisci)
        {
            var somma = x + y;
            x.Dispose();
            // x = null;

            return default(T);
        }

        public void Set(Fattura fattura)
        {
            if(fattura is FatturaPagata)
            {
                ((FatturaPagata)fattura).DataPagamento = DateTime.Now;
            }

            fattura.Test();
        }
    }
}