using System;
using System.Collections.Generic;
using System.Text;

namespace FPT.CorsoCSharp.DomainModel
{
    // Reference Type
    public class Cliente : DomainObject, IDisposable
    {
        public int Codice { get; set; }

        public void Dispose()
        {
            
        }
    }
}