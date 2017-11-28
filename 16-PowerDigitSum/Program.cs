using System;
using System.Numerics;

namespace PowerDigitSum
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var twoTo50 = new BigInteger(Math.Pow(2, 50));
            var twoTo1000 = BigInteger.Pow(twoTo50, 20);
            int digitSum = 0;
            string twoTo1000String = twoTo1000.ToString();
            foreach (char character in twoTo1000String) {
                digitSum += Int32.Parse(character.ToString());
            }
            Console.WriteLine(twoTo1000); 
            Console.WriteLine(digitSum);
        }
    }
}
