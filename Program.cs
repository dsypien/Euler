using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Format("Euler Problem 1 result \t {0}", Problem1.Run()));
            Console.WriteLine(String.Format("Euler Problem 2 result \t {0}", Problem2.Run()));
            Console.WriteLine(String.Format("Euler Problem 4 result \t {0}", Problem4.Run()));

            Console.ReadLine();
        }
    }
}
