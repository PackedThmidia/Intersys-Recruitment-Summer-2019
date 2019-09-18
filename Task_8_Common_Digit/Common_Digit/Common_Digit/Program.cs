using System;
using System.Linq;
namespace Common_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int[] array;

            //Input
            N = int.Parse(Console.ReadLine());
            array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            //Output
            Console.WriteLine(CommonDigit(array, N));
        }

        static int CommonDigit(int[] array, int N)
        {
            int[] digits = new int[10];
            for(int i = 0; i < N; i++)
            {
                while (array[i] > 0)
                {
                    digits[array[i] % 10]++;
                    array[i] /= 10;
                }
            }
            int digit = Array.LastIndexOf(digits, digits.Max());
            return digit;
        }

    }
}
