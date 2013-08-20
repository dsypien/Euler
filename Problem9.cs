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
        public static int Run()
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
