using System;
using System.Collections.Generic;
using DailyCode.classes;

namespace DailyCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var multi = new Multiplicar(new List<int>{3,2,1});
            Console.WriteLine(multi.ToString());

            var addition = new ListAddition();
            Console.WriteLine($"The value can be sum:{addition.CanItBeSum(20, new List<int>{10, 15, 3, 7})}");

        }
    }
}
