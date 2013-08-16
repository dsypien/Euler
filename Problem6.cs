using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler
{
    public static class Problem6
    {
        public static double Run()
        {
            double sumOfSquares = 0;
            double squareOfSums = 0;

            for (double i = 1; i <= 100; i++)
            {
                sumOfSquares += Math.Pow(i, 2.0);
            }

            for (double i = 1; i <= 100; i++)
            {
                squareOfSums += i;
            }

            squareOfSums = Math.Pow(squareOfSums, 2.0);

            return squareOfSums - sumOfSquares;
        }
    }
}
