using System;

namespace SumSquareDifference
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            long sumOfSquares = 0;
            long squareOfSums = 0;
            for (int i = 1; i <= 100; i++) {
                sumOfSquares += Convert.ToInt64(Math.Pow(i, 2));
                squareOfSums += i;
            }

            squareOfSums = Convert.ToInt64(Math.Pow(squareOfSums, 2));

            Console.WriteLine(squareOfSums - sumOfSquares);
        }
    }
}
