using System;

namespace Exercise16
{
    class Result
    {

        /*
         * Complete the 'sumXor' function below.
         *
         * The function is expected to return a LONG_INTEGER.
         * The function accepts LONG_INTEGER n as parameter.
         */

        public static long sumXor(long n)
        {
            string binary = Convert.ToString(n, 2);
            var zeroes = 0;
            for (var i = 0; i < binary.Length; i++)
            {
                if (binary[i] == '0')
                    zeroes++;
            }
            if (n == 0)
                zeroes = 0;

            return (long)Math.Pow(2, zeroes);
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            long n = Convert.ToInt64(Console.ReadLine().Trim());

            long result = Result.sumXor(n);

            Console.WriteLine(result);
        }
    }
}