using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler
{
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


