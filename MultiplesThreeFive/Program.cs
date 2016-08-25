using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplesThreeFive
{
    class Program
    {
        static void Main(string[] args)
        {
            var total = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    total += i;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine(total);
            Console.ReadLine();
        }
    }
}
