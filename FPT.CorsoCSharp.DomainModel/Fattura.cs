using System;

namespace FPT.CorsoCSharp.DomainModel
{
    public partial class Fattura : DomainObject, IDisposable, ISomma
    {
        private int _state;

        // 76.000 byte
        public byte[] LastPdf { get; set; }
        public string Numero { get; set; }
        public double Importo { get; set; }
        public string Note { get; private set; }
        public string Note2 { get; }

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

        public Fattura()
        {
            this.Note2 = "gdnkjgndkjgnfdkjgnfdkj";
        }

        public static Fattura operator +(Fattura f1, Fattura f2)
        {
            return new Fattura()
            {
                Importo = f1.Importo + f2.Importo
            };
        }

        public static class Factory
        {
            static int index = 0;
            private static Fattura[] pool =
                (Fattura[])Array.CreateInstance(typeof(Fattura), 20);

            public static Fattura Create()
            {
                return new Fattura();
            }
        }
    }
}