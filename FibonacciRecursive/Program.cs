using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciRecursive
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 11; i++)
            {
                Console.WriteLine(FibonacciRecursive(i));
            }
            Console.ReadLine();
        }

        public static long FibonacciRecursive(int N)
        {
            long[] cache = new long[N + 1];
            return Fibo(N, cache);
        }
        public static long Fibo(int N, long[] cache)
        {
            if(N == 0)
            {
                return 0;
            }
            if(N == 1)
            {
                return 1;
            }
            if(cache[N] == 0)
            {
                long fibVal = Fibo(N - 1, cache) + Fibo(N - 2, cache);

                cache[N] = fibVal;
            }
            return cache[N];
        }
    }
}
