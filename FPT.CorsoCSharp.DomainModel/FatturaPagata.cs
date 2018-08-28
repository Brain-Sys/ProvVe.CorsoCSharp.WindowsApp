using FPT.CorsoCSharp.DomainModel.CustomEventArgs;
using FPT.CorsoCSharp.DomainModel.CustomExceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace FPT.CorsoCSharp.DomainModel
{
    // public delegate void FatturaPagataEventHandler(object sender, FatturaPagataEventArgs args);

    public class FatturaPagata : Fattura
    {
        // Avvisa "qualcuno di esterno" che una fattura
        // è stata appena pagata
        public event EventHandler<FatturaPagataEventArgs> FatturaAppenaPagata;
        // public event FatturaPagataEventHandler FatturaAppenaPagata;

        public DateTime DataPagamento { get; set; }

        public override void Test()
        {
            this.DataPagamento = DateTime.Now;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="InvalidOperationException">........</exception>
        /// <exception cref="InvalidProgramException">........</exception>
        public void Paga()
        {
            if (this.DataPagamento != DateTime.MinValue)
            {
                // throw new InvalidOperationException("La fattura è già stata pagata!");
                throw new FPTException("La fattura è già stata pagata!");
            }

            this.DataPagamento = DateTime.Now;
            // Database

            // Scateno l'evento, ma prima controllo se c'è qualcuno
            // di registrato all'evento
            if (this.FatturaAppenaPagata != null)
            {
                this.FatturaAppenaPagata(this,
                    new FatturaPagataEventArgs(this.DataPagamento, this));
            }
        }
    }
}