using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler
{
    /// <summary>
    /// Largest palindrome product
    /// </summary>
    /// 
    /// A palindromic number reads the same both ways. The largest palindrome made 
    /// from the product of two 2-digit numbers is 9009 = 91 × 99.
    /// 
    /// Find the largest palindrome made from the product of two 3-digit numbers.
    
    class Problem4
    {
        public static int Run()
        {
            int largestPalindromeProd = 0;

            for (int i = 999; i > 100; i--)
            {
                for (int j = 999; j > 100; j--)
                {
                    var product = i * j;

                    if (IsPalindrome(product.ToString()))
                    {
                        largestPalindromeProd = product > largestPalindromeProd ? product : largestPalindromeProd;
                    }
                }
            }

            return largestPalindromeProd;
        }

        private static bool IsPalindrome(string txt)
        {
            for (int i = 0, j = txt.Length - 1; i <= j; i++, j--)
            {
                if (txt[i] != txt[j])
                    return false;
            }

            return true;
        }
    }
}
