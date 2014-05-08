using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler
{
    /// <summary>
    /// Special Pythagorean triplet
    /// </summary>
    /// 
    /// A Pythagorean triplet is a set of three natural numbers, 
    /// a < b < c, for which, a2 + b2 = c2
    /// 
    /// For example, 32 + 42 = 9 + 16 = 25 = 52.
    /// There exists exactly one Pythagorean triplet for which a + b + c = 1000.
    /// 
    /// Find the product abc.
    
    public class Problem9
    {
        /// <summary>
        /// More efficient Run, executes in O n^2 time
        /// </summary>
        /// <returns></returns>
        public static int Run()
        {
            for (int a = 1; a < 998; a++)
            {
                for (int b = a + 1; b < 999; b++)
                {
                    int aSqrd = (int)Math.Pow(a, 2.0);
                    int bSqrd = (int)Math.Pow(b, 2.0);
                    int cSqrd = aSqrd + bSqrd;
                    double c = Math.Sqrt(cSqrd);

                    if (c % 1 == 0 && (a + b + c == 1000))
                    {
                        return a * b * (int)c;
                    }
                }
            }
            return -1;
        }

        /// <summary>
        /// This was the first Run Method I wrote.  It has been depricated as it was inneficient:
        /// O n^3 time
        /// </summary>
        public static int OldRun()
        {
            for (int c = 1000; c > 18; c--)
            {
                for (int b = c - 1; b > 1; b--)
                {
                    for (int a = b - 1; a > 0; a--)
                    {
                        int aSqrd = (int)Math.Pow(a, 2.0);
                        int bSqrd = (int)Math.Pow(b, 2.0);
                        int cSqrd = (int)Math.Pow(c, 2.0);

                        if ((aSqrd + bSqrd == cSqrd) && (a + b + c == 1000))
                        {
                            return a * b * c;
                        }
                    }
                }
            }
            return -1;
        }
    }
}
