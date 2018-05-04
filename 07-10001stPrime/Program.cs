using System;
using System.Collections.Generic;

namespace stPrime
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var primes = new List<long>();
            bool currentNumberIsPrime = false;

            for (int i = 2; primes.Count < 10001; i++)
            {
                currentNumberIsPrime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0) {
                        currentNumberIsPrime = false;
                        break;
                    }
                }

                if (currentNumberIsPrime) {
                    primes.Add(i);
                }
            }

            Console.WriteLine(primes[primes.Count-1]);
        }
    }
}
