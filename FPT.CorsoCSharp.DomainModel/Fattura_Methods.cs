using System;
using System.Collections.Generic;
using System.Text;

namespace FPT.CorsoCSharp.DomainModel
{
    public partial class Fattura
    {
        public bool Pagata { get; set; }

        public Fattura()
        {
            
        }

        //public override string ToString()
        //{
        //    return "n.fat. " + this.Numero;
        //}
    }
}