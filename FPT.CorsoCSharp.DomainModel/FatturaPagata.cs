using System;
using System.Collections.Generic;
using System.Text;

namespace FPT.CorsoCSharp.DomainModel
{
    public class FatturaPagata : Fattura
    {
        public DateTime DataPagamento { get; set; }

        public override void Test()
        {
            this.DataPagamento = DateTime.Now;
        }
    }
}