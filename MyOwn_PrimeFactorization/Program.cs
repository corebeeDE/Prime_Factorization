using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOwn_PrimeFactorization
{
    class Program
    {
        static void Main()
        {
            int[] output = GetPrimes(15);
            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------");

            output = GetPrimes(8);
            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------");

            output = GetPrimes(40);
            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------");

            output = GetPrimes(99);
            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------");

            output = GetPrimes(256);
            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------");

            output = GetPrimes(520);
            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        public static int[] GetPrimes(int input)
        {
            List<int> allPrimes = new List<int>();
            for (int prime = 2; input != 1; prime++)
            {
                while (input % prime == 0 && input != 1)
                {
                    input /= prime;
                    allPrimes.Add(prime);
                }
            }
            return allPrimes.ToArray();
        }
    }
}
