﻿namespace Exercise6
{
    class Result
    {

        /*
         * Complete the 'maxMin' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER k
         *  2. INTEGER_ARRAY arr
         */

        public static int maxMin(int k, List<int> arr)
        {
            arr.Sort();
            int minUnfairness = int.MaxValue;

            for (int i = 0; i <= arr.Count - k; i++)
            {
                int unfairness = arr[i + k - 1] - arr[i];
                if (unfairness < minUnfairness)
                    minUnfairness = unfairness;
            }

            return minUnfairness;
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            int k = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int arrItem = Convert.ToInt32(Console.ReadLine().Trim());
                arr.Add(arrItem);
            }

            int result = Result.maxMin(k, arr);

            Console.WriteLine(result);
        }
    }
}