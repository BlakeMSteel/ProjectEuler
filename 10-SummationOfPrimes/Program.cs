using System;
using System.Collections.Generic;

namespace SummationOfPrimes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            bool currentNumberIsPrime = false;
            long sum = 0;

            for (int i = 2; i < 2000000; i++)
            {
                currentNumberIsPrime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        currentNumberIsPrime = false;
                        break;
                    }
                }

                if (currentNumberIsPrime)
                {
                    sum += i;

                }
            }

            Console.WriteLine(sum);
        }
    }
}
