using System;
using System.Linq;
namespace Digit_Sum
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
            Console.WriteLine(BiggestDigitSum(array, N));
            Console.Read();
        }
        static int BiggestDigitSum(int[] arr, int N)
        {
            int[] temp = new int[N];
            //Calculate digit sum for every element in array
            for(int i = 0; i < N; i++)
            {
                temp[i] = DigitSum(arr[i]);
            }

            //Find max digit sum
            int max = temp.Max();

            //Find indexes of max digit sum
            int maxIndex = -1;
            int[] indexes = temp.Select((value, index) => value == max ? index : -1).Where(index => index != -1).ToArray();


            //Find index with biggest number
            if (indexes.Length == 1) return indexes[0];
            for (int i = 0; i < indexes.Length-1; i++)
            {
                if (arr[indexes[i]] > arr[indexes[i + 1]])
                    maxIndex = indexes[i];
                else
                    maxIndex = indexes[i + 1];
            }
            return maxIndex;

        }
        static int DigitSum(int number)
        {
            int sum = 0;
            while(number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }
    }
}
