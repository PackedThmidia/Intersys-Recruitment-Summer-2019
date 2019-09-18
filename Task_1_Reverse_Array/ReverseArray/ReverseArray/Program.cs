using System;

namespace ReverseArray
{
    class Program
    {
        #region main
        static void Main(string[] args)
        {
            int N;
            int[] array;

            //Input
            try
            {
                int.TryParse(Console.ReadLine(), out N);
            }
            catch(Exception e)
            {
                Console.WriteLine("The N must be a number");
                return;
            }
            array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            if (array.Length != N)
            {
                Console.WriteLine("The specified N value and array length are not the same");
                Console.ReadKey();
                return;
            }
            //Output
            Console.WriteLine(string.Join(" ", ReverseArray(array, N)));
            Console.ReadKey();
        }
        #endregion
        public static int[] ReverseArray(int[] array, int n)
        {
            for (int i = 0; i < n / 2; i++)
            {
                var temp = array[i];
                array[i] = array[n - i - 1];
                array[n - i - 1] = temp;
            }
            return array;
        }
    }
}

