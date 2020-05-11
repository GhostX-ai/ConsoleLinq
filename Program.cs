using System;
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
            Console.ReadKey();
        }
    }
}
