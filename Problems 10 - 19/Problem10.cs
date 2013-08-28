using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Euler
{
    /// <summary>
    /// Summation of primes
    /// </summary>
    ///
    /// The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
    /// 
    /// Find the sum of all the primes below two million.
    
    public static class Problem10
    {
        public static long Run()
        {
            BitArray array = new BitArray(int.MaxValue, true);
            long sum = 0;

            for (int i = 2; i < 2000000; i++)
            {
                if (array[i] == true)
                {
                    sum += i;

                    for (int j = i; j < 2000000; j += i)
                    {
                        array[j] = false;
                    }
                }
            }

            return sum;
        }
    }
}
