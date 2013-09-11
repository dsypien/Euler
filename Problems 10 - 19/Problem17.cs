using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler
{
    /// <summary>
    /// Number Letter Counts
    /// </summary>
    /// 
    /// If the numbers 1 to 5 are written out in words: one, two, three, four, five, then 
    /// there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.
    /// 
    /// If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, 
    /// how many letters would be used?
    /// 
    /// NOTE: Do not count spaces or hyphens. For example, 342 (three hundred and forty-two) 
    /// contains 23 letters and 115 (one hundred and fifteen) contains 20 letters. The use of
    /// "and" when writing out numbers is in compliance with British usage.

    static public class Problem17
    {
        static Dictionary<int, string> _wordDictionary = new Dictionary<int, string>();

        public static uint Run()
        {
            uint sum = 0;
            populateWordDictionary();

            for (int i = 1; i < 1000; i++)
            {
                string curWord = string.Empty;
                int iCopy = i;
                                
                if ((i / 100) > 0)
                {
                    curWord += _wordDictionary[i / 100] + "hundred";
                    
                    if (i % 100 == 0)
                    {
                        System.Console.WriteLine(curWord);
                        continue;
                    }

                    curWord += "and";
                }

                int onesPlace = (i % 10);
                int twosPlace = (i % 100) - onesPlace;

                if(twosPlace > 0)
                {
                    if ( twosPlace == 10) 
                    {
                        twosPlace += onesPlace;
                        curWord += _wordDictionary[twosPlace];
                        System.Console.WriteLine(curWord);
                        continue;
                    }
                    curWord += _wordDictionary[twosPlace];
                }

                if( onesPlace > 0)
                {
                    curWord += _wordDictionary[onesPlace];
                }

                System.Console.WriteLine(curWord);
            }

            System.Console.WriteLine("one thousand");

            return sum;
        }

        private static void populateWordDictionary()
        {
            _wordDictionary.Add(1, "one");
            _wordDictionary.Add(2, "two");
            _wordDictionary.Add(3, "three");
            _wordDictionary.Add(4, "four");
            _wordDictionary.Add(5, "five");
            _wordDictionary.Add(6, "six");
            _wordDictionary.Add(7, "seven");
            _wordDictionary.Add(8, "eight");
            _wordDictionary.Add(9, "nine");
            _wordDictionary.Add(10, "ten");
            _wordDictionary.Add(11, "eleven");
            _wordDictionary.Add(12, "twelve");
            _wordDictionary.Add(13, "thirteen");
            _wordDictionary.Add(14, "fourteen");
            _wordDictionary.Add(15, "fifteen");
            _wordDictionary.Add(16, "sixteen");
            _wordDictionary.Add(17, "seventeen");
            _wordDictionary.Add(18, "eighteen");
            _wordDictionary.Add(19, "nineteen");
            _wordDictionary.Add(20, "twenty");
            _wordDictionary.Add(30, "thirty");
            _wordDictionary.Add(40, "forty");
            _wordDictionary.Add(50, "fifty");
            _wordDictionary.Add(60, "sixty");
            _wordDictionary.Add(70, "seventy");
            _wordDictionary.Add(80, "eighty");
            _wordDictionary.Add(90, "ninety");
        }

        static uint GetLetterCount(int num)
        {
            
            return 0;
        }
    }
}
