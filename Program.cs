﻿using System;
using System.Linq;

namespace ConsoleLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 21654984;
            char[] snum = num.ToString().ToCharArray();
            foreach (var x in snum.Reverse())
            {
                Console.WriteLine(x);
            }
            int[] nums = { 1, 2, 6, 7, 5, 1, -2, -3, -2, -1 };
            int possum = nums.Where(n => n > 0).Sum();
            int nossum = nums.Where(n => n < 0).Sum();
            Console.WriteLine("+ " + possum);
            Console.WriteLine("+ " + nossum);
            string[] names = { "Aziz", "Amin", "Firdavs", "Shahzod", "Karim", "Akmal" };
            names = names.OrderBy(n => n.Length).ToArray();
            foreach (var x in names)
            {
                Console.Write(x + " ");
            }
            Console.ReadKey();
        }
    }
}
