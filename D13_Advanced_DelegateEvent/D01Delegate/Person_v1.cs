using System;
using System.Collections.Generic;

namespace D13_Advanced_DelegateEvent
{

    // v1 - Delegate clássico
    class Person_v1
    {

        #region Método sem delegate
        // ExtractNames_SemDelegate
        public static List<string> ExtractNames_SemDelegate(string[] array, int nameLength)
        {
            var result = new List<string>();

            foreach (var t in array)
                if (t.Length == nameLength)
                    result.Add(t);

            return result;
        }
        #endregion

        #region Método com delegate
        public delegate bool LengthFilter(string item, int length);

        public static bool GreaterThanLengthFilter(string item, int length)
        {
            return item.Length > length;
        }

        public static List<string> ExtractNames_ComDelegate(string[] array, LengthFilter filter, int length)
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
