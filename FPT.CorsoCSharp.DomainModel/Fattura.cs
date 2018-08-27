using System;

namespace FPT.CorsoCSharp.DomainModel
{
    public class Fattura : DomainObject, IDisposable, ISomma
    {
        // 76.000 byte
        public byte[] LastPdf { get; set; }
        public string Numero { get; set; }
        public double Importo { get; set; }

        // Garbage Collector
        public void Dispose()
        {
            this.LastPdf = null;
        }

        public double Somma(Fattura fattura)
        {
            return this.Importo + fattura.Importo;
        }

        public virtual void Test()
        {

        }

        public static Fattura operator +(Fattura f1, Fattura f2)
        {
            return new Fattura()
            {
                Importo = f1.Importo + f2.Importo
            };
        }
    }
}