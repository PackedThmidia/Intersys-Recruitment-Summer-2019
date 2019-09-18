using System;
using System.Collections.Generic;
using System.Linq;
namespace PowersOf2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<UInt32> list = new List<UInt32>();
            UInt32 number;
            string line = ".";
            while(line != "")
            {
                line = Console.ReadLine();
                try
                {
                    UInt32.TryParse(line, out number);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    break;
                }
                list.Add(number);
            }
            Console.WriteLine("Input collected!");
            Console.WriteLine(PowersOf2(list));
            Console.Read();
        }
        public static string PowersOf2(List<UInt32> list)
        {
            string sequence = "";
            UInt32 max = list.Max();
            if (max % 2 != 0 && max != 1) max--;
            while(max > 0)
            {
                sequence = String.Join(',', max, sequence);
                max /= 2;
            }

            return sequence.Remove(sequence.Length-1);
        }
    }
}
