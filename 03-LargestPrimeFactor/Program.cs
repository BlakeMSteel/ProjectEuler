using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_LargestPrimeFactor
{
    class Program
    {
        static void Main(string[] args)
        {
            var isntPrime = false;
            var numbers = new List<long>() { 20 };
            do
            {
                isntPrime = false;
                for (int i = 2; i < numbers[0]; i++)
                    if (numbers[0] % i == 0)
                    {
                        numbers.Add(i);
                        numbers[0] /= i;
                        isntPrime = true;
                        break;
                    }
            } while (isntPrime);
            foreach (int x in numbers)
            {
                Console.WriteLine(x);

            }
            Console.ReadLine();
        }
    }
}
