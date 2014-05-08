using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler
{
    /// <summary>
    /// Smallest Multiple
    /// </summary>
    /// 
    /// 2520 is the smallest number that can be divided by each of 
    /// the numbers from 1 to 10 without any remainder.
    /// 
    /// What is the smallest positive number that is evenly divisible 
    /// by all of the numbers from 1 to 20?
    
    public static class Problem5
    {
        public static int Run()
        {
            for (int i = 2520; true; i += 2)
            {
                for (int j = 20; j > 2; j--)
                {
                    if (i % j != 0)
                        break;

                    if (j == 3)
                        return i;
                }
            }
        }
    }
}
