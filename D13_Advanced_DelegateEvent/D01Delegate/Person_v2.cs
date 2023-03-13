using System;
using System.Collections.Generic;

namespace D13_Advanced_DelegateEvent
{

    // v2 - Delegate Func
    class Person_v2
    {

        #region Método com delegate Func
        // public delegate bool LengthFilter(string item, int length);  // O delegate é substituido pelo Func

        public static bool GreaterThanLengthFilter(string item, int length)
        {
            return item.Length > length;
        }

        public static List<string> ExtractNames_ComDelegateFunc(string[] array,
                                        Func<string, int, bool> filter, int length)
        {
            var result = new List<string>();

            foreach (var t in array)
                if (filter(t, length))
                    result.Add(t);

            return result;
        }
        #endregion

    }

}
