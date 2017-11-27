using System;

namespace LongestCollatzSequence
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int largestCollatzNumber = 1;
            int longestCollatzCount = 1;
            for (int i = 1; i <= 1000000; i++) {
                int collatzCount = 1;
                long collatzNumber = i;
                while (collatzNumber != 1){
                    if (collatzNumber % 2 == 0) {
                        collatzNumber /= 2;
                        collatzCount++;
                    }
                    else {
                        collatzNumber = collatzNumber * 3 + 1;
                        collatzCount++;
                    }
                }
                if (collatzCount >= longestCollatzCount)
                {
                    largestCollatzNumber = i;
                    longestCollatzCount = collatzCount;
                    Console.WriteLine("New longest collatz number: " + largestCollatzNumber + ", " + longestCollatzCount);
                }
            }
        }
    }
}
