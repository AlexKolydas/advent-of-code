using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AdventOfCode2018.C01
{
    public static class Challenge01
    {
        public static void Run()
        {
            string path;
            path= Path.Combine("C:\\Users\\H350902\\source\\advent-of-code\\2018\\AdventOfCode2018\\AdventOfCode2018\\C01\\FrequencyChanges.txt");
            GetFrequencyValues(path);
        }


        public static List<int> GetFrequencyValues(string path)
        {
            List<int> freqNumbers = new List<int>();
            int[] numbers;
            foreach( string line in File.ReadLines(path))
            {
                //Get the numbers from each line using LINQ
                numbers = line.Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

                foreach(var num in numbers)
                {
                    freqNumbers.Add(num);
                }

            }
            return freqNumbers;
        }
    }
}
