using System;
using System.Collections.Generic;

namespace PrimeFactorization
{
    class Program
    {
        static void Main()
        {
            var testCases = new List<int>() { 15, 8, 40, 99, 256, 520 };

            // GOOD READABILITY: Iterates through the test-cases in given list.
            foreach (var testCase in testCases)
            {
                var consoleOutput = string.Format("Prime factorization for {0}:{1}{2}{1}",
                                                    testCase,
                                                    Environment.NewLine,
                                                    string.Join(Environment.NewLine, GetPrimes(testCase)));
                Console.WriteLine(consoleOutput);
            }

            // BAD READABILITY BUT SHORTER: Iterates through the test-cases in given list.
            // testCases.ForEach(number => Console.WriteLine($"Prime factorization for {number}, all primes are:\n{string.Join(Environment.NewLine, GetPrimes(number))}\n"));
        }

        public static IEnumerable<int> GetPrimes(int input)
        {
            // Iterates over possible dividers.
            for (int prime = 2; input != 1; prime++)
            {
                // Iterates over divider until it is not possible anymore.
                while (input % prime == 0 && input != 1)
                {
                    input /= prime;
                    yield return prime;
                    // FYI: There are alternatives to yielding (which do not result in an IEnumerable<int> like in this case), but I wanted to test/fiddle around since I compare it to Pythons version.
                }
            }
        }
    }
}