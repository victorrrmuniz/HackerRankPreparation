namespace Exercise6
{
    class Result
    {

        /*
         * Complete the 'flippingBits' function below.
         *
         * The function is expected to return a LONG_INTEGER.
         * The function accepts LONG_INTEGER n as parameter.
         */

        public static long flippingBits(long n)
        {
            var mask = uint.MaxValue;

            long result = n ^ mask; 

            return result;
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {

            int q = Convert.ToInt32(Console.ReadLine().Trim());

            for (int qItr = 0; qItr < q; qItr++)
            {
                long n = Convert.ToInt64(Console.ReadLine().Trim());

                long result = Result.flippingBits(n);

                Console.WriteLine(result);
            }
        }
    }

}