using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToText
{
    class NumberToText
    {
        private Dictionary<int, string> dictionary;
        private int number;

        public NumberToText(int number)
        {
            this.number = number;
        }
        public void convertNumber()
        {
            dictionary = File.ReadLines("Dictionary.txt").Select(line => line.Split('\t')).Where(arr => arr.Length == 2).ToDictionary(arr => Convert.ToInt32(arr[0]), arr => arr[1]);

            foreach (var dict in dictionary)
            {
                if (dict.Key == number)
                    Console.WriteLine(dict.Key + " - " + dict.Value);
            }

        }
    }
}
