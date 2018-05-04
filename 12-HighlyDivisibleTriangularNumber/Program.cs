using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

public class Challenge12
{
    public static void Main(String[] args)
    {
        HashSet<long> factorSet = new HashSet<long>();
        long result = 0;
        long counter = 1;
        for (long i = 1; factorSet.Count() < 501; i += counter)
        {
            factorSet.Clear();
            factorSet.Add(i);
            for (long j = Convert.ToInt64(Math.Ceiling(Math.Sqrt(i))); j > 0; j--)
            {
                if (i % j == 0)
                {
                    factorSet.Add(j);
                    factorSet.Add(i / j);
                }
            }
            result = i;
            Console.WriteLine(result + " --- " + factorSet.Count());
            counter++;
        }
        Console.WriteLine(result);
    }
}