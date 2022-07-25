using System;
using System.Collections.Generic;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(2);
            list.Add(1);
            list.Add(3);
            list.Add(4);
            Console.WriteLine("Lütfen bir sayı giriniz.");

            int number = Convert.ToInt32(Console.ReadLine());
            bool odd = number.isOddNumber();
            bool even = number.isEvenNumber();
            int multiplybyTen = number.multiplybyTen();

            Console.WriteLine("Tek Sayı :" + odd );
            Console.WriteLine("Çift Sayı :" + even );
            Console.WriteLine("10 Katı :" + multiplybyTen.ToString() );
            Console.WriteLine("TL :" + number.ConvertToTL());

            Console.ReadLine();
        }
    }
}
