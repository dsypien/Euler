using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Euler
{
    static public class Problem13
    {
        static private List<ulong> First17NumbersList = new List<ulong>();
        static private List<ulong> Second17NumbersList = new List<ulong>();
        static private List<ulong> Last16NumbersList = new List<ulong>();

        static public ulong Run()
        {
            PopulateLists();

            ulong sumOfFirstList = GetSumOfList(First17NumbersList);
            ulong firstCarryOver = GetNumToCarryOver(sumOfFirstList);

            // Get the sum of the second list and add the number that carries over from the first list
            ulong sumOfSecondList = GetSumOfList(Second17NumbersList) + firstCarryOver;
            ulong secondCarryOver = GetNumToCarryOver(sumOfSecondList);

            // carry over number from previous sum
            ulong sumOfLastList = GetSumOfList(Last16NumbersList) + secondCarryOver;
            string first10Digits = sumOfLastList.ToString().Substring(0, 10);

            return ulong.Parse(first10Digits);
        }

        static private ulong GetNumToCarryOver(ulong num)
        {
            string strNum = num.ToString();
            strNum = strNum.Substring(0, strNum.Length - 17);

            return ulong.Parse(strNum);
        }

        static private ulong GetSumOfList(List<ulong> list)
        {
            ulong sum = 0;

            foreach (var num in list)
            {
                sum += num;
            }

            return sum;
        }

        static private void PopulateLists()
        {
            using (StreamReader reader = new StreamReader(new FileStream(@"..\..\LargeSum.txt", FileMode.Open, FileAccess.Read)))
            {
                string line ;

                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    string last16 = line.Substring(0, 16);
                    string second17 = line.Substring(16, 17);
                    string first17 = line.Substring(33, 17);

                    Last16NumbersList.Add(ulong.Parse(last16));
                    Second17NumbersList.Add(ulong.Parse(second17));
                    First17NumbersList.Add(ulong.Parse(first17));
                }
            }
        }
    }
}
