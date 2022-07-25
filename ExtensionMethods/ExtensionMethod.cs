using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class ExtensionMethod
    {
        public static bool isOddNumber(this int number)
        {
            return number % 2 != 0;
        }
        public static bool isEvenNumber(this int number)
        {
            return !isOddNumber(number);
        }

        public static string ConvertToTL(this int number)
        {
            decimal value = Convert.ToDecimal(number);
            return $"{value} TL";
        }
        public static int multiplybyTen(this int number)
        {
            return number * 10;
        }
    }
}
