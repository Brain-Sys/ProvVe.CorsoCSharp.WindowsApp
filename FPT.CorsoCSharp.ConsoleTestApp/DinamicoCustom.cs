using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPT.CorsoCSharp.ConsoleTestApp
{
    public class DinamicoCustom : DynamicObject
    {
        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            string propName = binder.Name;

            return base.TryGetMember(binder, out result);
        }
    }
}