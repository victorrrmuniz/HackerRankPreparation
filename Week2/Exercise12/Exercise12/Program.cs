using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exercise12
{
    class Result
    {

        /*
         * Complete the 'counterGame' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts LONG_INTEGER n as parameter.
         */

        public static string counterGame(long n)
        {
            string winner = "Richard";
            long subtractNumber;

            if (n == 1)
                return winner;

            while (n > 1)
            {
                winner = winner == "Louise" ? "Richard" : "Louise";

                if ((n & (n - 1)) == 0)
                    n /= 2;
                else
                {
                    long largestPowerOfTwo = (long)Math.Pow(2, (int)Math.Log2(n));
                    n -= largestPowerOfTwo;
                }
            }

            return winner;
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {

            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int tItr = 0; tItr < t; tItr++)
            {
                long n = Convert.ToInt64(Console.ReadLine().Trim());

                string result = Result.counterGame(n);

                Console.WriteLine(result);
            }

        }
    }
}