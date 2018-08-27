using System;
using System.Collections.Generic;
using System.Text;

namespace FPT.CorsoCSharp.DomainModel
{
    public static class ExtensionMethods
    {
        public static bool IsValid(this string codiceFiscale)
        {
            if (!string.IsNullOrEmpty(codiceFiscale) &&
                codiceFiscale.Length == 16)
                return true;
            else
                return false;
        }

        public static bool Maggiorenne(this string codiceFiscale)
        {
            return false;
        }

        public static bool Maggiorenne
            (this string codiceFiscale, string country)
        {
            return false;
        }

        public static List<DateTime> DammiPagamenti(this List<Fattura> fatture)
        {
            return null;
        }

        public static string ToString(this string value)
        {
            return value.ToString();
        }
    }
}