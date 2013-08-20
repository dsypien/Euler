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
            Console.WriteLine(String.Format("Euler Problem 1 result \t\t {0}", Problem1.Run()));
            Console.WriteLine(String.Format("Euler Problem 2 result \t\t {0}", Problem2.Run()));
            Console.WriteLine(String.Format("Euler Problem 3 result \t\t {0}", Problem3.Run()));
            Console.WriteLine(String.Format("Euler Problem 4 result \t\t {0}", Problem4.Run()));
            Console.WriteLine(String.Format("Euler Problem 5 result \t\t {0}", Problem5.Run()));
            Console.WriteLine(String.Format("Euler Problem 6 result \t\t {0}", Problem6.Run()));
            Console.WriteLine(String.Format("Euler Problem 7 result \t\t {0}", Problem7.Run()));
            Console.WriteLine(String.Format("Euler Problem 8 result \t\t {0}", Problem8.Run()));
            Console.WriteLine(String.Format("Euler Problem 9 result \t\t {0}", Problem9.Run()));
            Console.WriteLine(String.Format("Euler Problem 10 result \t {0}", Problem10.Run()));

            Console.ReadLine();
        }
    }
}
