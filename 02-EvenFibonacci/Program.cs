using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_EvenFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstFibon = 0;
            var secondFibon = 1;
            var temp = 0;
            var total = 0;
            while (secondFibon <= 4000000)
            {
                temp = secondFibon;
                secondFibon += firstFibon;
                firstFibon = temp;
                if (firstFibon % 2 == 0) total += firstFibon;
            }
            Console.WriteLine(total);
            Console.ReadLine();
        }
    }
}
