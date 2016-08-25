using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_LargestPalindromeProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            var largest = 0;
            var current = 0;
            var currentString = "";
            var currentStringReversed = "";
            for (int i = 999; i > 100; i--)
            {
                for (int j = 999; j > 100; j--)
                {
                    if((current = i * j) > largest)
                    {
                        currentString = current.ToString();
                        currentStringReversed = Reverse(currentString);
                        if (currentString == currentStringReversed)
                        {
                            largest = current;
                            Console.WriteLine(largest);
                        }
                    }
                }
            }
            Console.ReadLine();
        }
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
