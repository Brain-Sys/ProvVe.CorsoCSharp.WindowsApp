using System;
using System.Collections.Generic;
using System.Text;

namespace FPT.CorsoCSharp.DomainModel.CustomEventArgs
{
    public class FatturaPagataEventArgs : EventArgs
    {
        public DateTime Timestamp { get; set; }
        public FatturaPagata Fattura { get; set; }

        public FatturaPagataEventArgs(DateTime dt, FatturaPagata fattura)
        {
            if (dt != DateTime.MinValue)
            {
                this.Timestamp = dt;
                this.Fattura = fattura;
            }
        }
    }
}