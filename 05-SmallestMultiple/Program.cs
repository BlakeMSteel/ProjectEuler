using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_SmallestMultiple
{
    class Program
    {
        static void Main(string[] args)
        {
            var multiple = 0;
            var found = false;
            for (int i = 1; !found; i++)
            {
                found = true;
                for (int j = 1; j < 21; j++)
                {
                    if (i % j != 0)
                    {
                        found = false;
                        break;
                    }
                }
                multiple = i;
            }
            Console.WriteLine(multiple);
            Console.ReadLine();
        }
    }
}
