using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler
{
    /// <summary>
    /// Largest Prime Factor
    /// </summary>
    /// 
    /// The prime factors of 13195 are 5, 7, 13 and 29.
    /// 
    /// What is the largest prime factor of the number 600851475143
    /// 
    static public class Problem3
    {
        static public long? Run()
        {
            long n = 600851475143;

            for (long i = 2; i <= n; i++)
            {
                if (n % i != 0)
                    continue;

                long factor = n / i;

                if (isPrime(factor))
                    return factor;
            }
            return null;
        }

        static public bool isPrime(long num)
        {
            if (num < 2)
                return false;

            int sqrt = (int)Math.Ceiling(Math.Sqrt(num));

            for (int i = 2; i <= sqrt; i++)
            {
                if (num % i == 0)
                    return false;
            }

            return true;
        }
    }
}
