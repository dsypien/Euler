using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler
{
    /// <summary>
    /// Multiples of 3 and 5
    /// </summary>
    /// 
    /// If we list all the natural numbers below 10 that are multiples of 3 or 5,
    /// we get 3, 5, 6 and 9. The sum of these multiples is 23.
    ///
    /// Find the sum of all the multiples of 3 or 5 below 1000.
    
    static class Problem1
    {
        public static int Run()
        {
            int sum = 0;

            for (int i = 3; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}
