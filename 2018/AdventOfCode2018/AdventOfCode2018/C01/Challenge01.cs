using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace AdventOfCode2018.C01
{
    public static class Challenge01
    {
        public static IEnumerable<int> allValues { get; private set; }

        public static void Run()
        {
            allValues = GetFrequencyValues("C01/FrequencyChanges.txt");

            foreach(var i in allValues)
            {
                Console.WriteLine(i);
            }
        }


        public static IEnumerable<int> GetFrequencyValues(string path)
        {

            IEnumerable<int> freqValues =File.ReadLines(path).Select(line=> Convert.ToInt32(line)).ToList(); //https://stackoverflow.com/questions/28859074/read-all-lines-in-text-file-with-separator
            return freqValues;
        }
    }
}