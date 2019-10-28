using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethod
{
    public static class Utils
    {
        public static string addRp(int price)
        {
            return "Rp. "+ price+",00";
        }
        public static string makeToBeString(this IEnumerable<int> queue)
        {
            string toBeString = "";
            if (queue!=null)
            {
                foreach (int item in queue)
                {
                    toBeString += item+", ";
                }
            }
            return toBeString;
        }
        //IComparable
        public static long? changeStringToBeLong(this string number)
        {
            if (number==null || number=="")
            {
                return null;
            }
            return Convert.ToInt64(number);
        }

        public static string TakeLeft(this string text, int length)
        {
            if (text == string.Empty)
                return text;

            if (text.Length <= length)
                return text;

            var result = text.Substring(0, length);
            return result;
        }
    }
}
