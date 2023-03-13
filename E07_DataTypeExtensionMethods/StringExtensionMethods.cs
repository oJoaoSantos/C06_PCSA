using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D14_Advanced_ExtensionMethods
{
    internal static class StringExtensionMethods
    {
        internal static string ConcatenarMaiusculas(this string stg1, string stg2)
        {
            return $"{stg1} {stg2}".ToUpper();
        }

        internal static string FormatarParaEuro(this int euro, int cents)
        {
            return $"€{euro},{cents}";
        }

        internal static string FormatarParaEuro(this double euro)
        {
            return $"€{euro}";
        }
    }
}
