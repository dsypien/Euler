using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler
{
    /// <summary>
    /// Longest Collatz Sequence
    /// </summary>
    /// 
    /// The following iterative sequence is defined for the set of positive integers:
    /// n → n/2 (n is even)
    /// n → 3n + 1 (n is odd)
    /// 
    /// Using the rule above and starting with 13, we generate the following sequence:
    /// 13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
    /// 
    /// It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. 
    /// Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.
    /// 
    /// Which starting number, under one million, produces the longest chain?
    
    static public class Problem14
    {
        static public int Run()
        {
            int longestSequence = 13;
            int greatestNumTerms = 1;

            for (int i = 13; i <= 1000000; i++)
            {
                int numterms = 1;
                long startingSequence = i;

                while (startingSequence > 1)
                {
                    numterms++;
                    if (startingSequence % 2 == 0)
                    {
                        startingSequence = startingSequence / 2;
                    }
                    else
                    {
                        startingSequence = (startingSequence * 3) + 1;
                    }
                }

                if (greatestNumTerms < numterms)
                {
                    greatestNumTerms = numterms;
                    longestSequence = i;
                }
            }

            return longestSequence;
        }
    }
}


