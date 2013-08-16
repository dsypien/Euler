using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Euler
{
    /// <summary>
    /// 100001st prime number
    /// </summary>
    /// 
    /// By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, 
    /// we can see that the 6th prime is 13.
    /// 
    /// What is the 10 001st prime number?
    
    public static class Problem7
    {
        public static int Run()
        {
            BitArray ary = new BitArray(int.MaxValue, true);

            // Had to tweak this value: if its too small not enough bits will be marked
            // If its too high, it takes a toll on execution time
            // TODO : Comeback and figure out a better solution
            int sqrt = (int) Math.Ceiling(Math.Sqrt((double)int.MaxValue)) *10;

            int i = 1;
            for (int numPrimes = 0; numPrimes != 10001; ++i)
            {
                if (ary[i] == true)
                {
                    numPrimes++;

                    // mark all multiples of the prime number
                    for (int j = i; j < sqrt; j += i)
                    {
                        ary[j] = false;
                    }
                }
            }

            return i;
        }
    }
}
