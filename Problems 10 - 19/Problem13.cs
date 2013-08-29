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
            
            return 1;
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
