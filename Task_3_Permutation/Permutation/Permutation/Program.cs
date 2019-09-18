using System;
using System.Linq;
namespace Permutation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[11];
            int[] array2 = new int[11];
            try
            {
                array1 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                array2 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
                return;
            }
            //Output
            Console.WriteLine(IsPermutation(array1, array2));
            Console.ReadKey();
        }
        public static string IsPermutation(int[] array1, int[] array2)
        {
            Array.Sort(array1);
            Array.Sort(array2);
            if (array1.SequenceEqual(array2))
                return "YES";
            return "NO";
        }
    }
}
