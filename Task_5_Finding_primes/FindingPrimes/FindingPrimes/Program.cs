using System;
using System.Collections;

namespace FindingPrimes
{
    class Program
    {
        public struct Pair {
            public int m, n;
            public Pair(int m, int n)
            {
                this.m = n;
                this.n = m;
            }
            public Pair(int[] arr)
            {
                this.m = arr[0];
                this.n = arr[1];
            }
        }
        static void Main(string[] args)
        {
            int T;
            Pair[] pairs;
            //Input

            T = int.Parse(Console.ReadLine());
            pairs = new Pair[T];
            for (int i = 0; i < T; i++)
            {
                pairs[i] = new Pair(Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse));
            }
            //Output
            for (int i = 0; i < T; i++)
            {
                Console.WriteLine(Eratosthenes_Sieve(pairs[i]));
            }
            Console.Read();
        }
        static int Eratosthenes_Sieve(Pair pair)
        {
            int primes = 0;
            BitArray array = new BitArray(pair.n);
            int sqrt = (int)Math.Sqrt(pair.n);
            for (int p = 2; p <= sqrt; p++)
            {
                //Crossed off
                if (array[p]) continue;
                //Not crossed -> prime
                if(p >= pair.m)primes++;

                //Cross off multiples of this prime
                for (int i = p * p; i < pair.n; i += p)
                    array[i] = true;
            }
            //The remaining numbers not crossed off are also prime.
            for (int p = sqrt + 1; p < pair.n; p++)
            {
                if (!array[p] && p >= pair.m) primes++;
            }

            return primes;
        }
    }
}
