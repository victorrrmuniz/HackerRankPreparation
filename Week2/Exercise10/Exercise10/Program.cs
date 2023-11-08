﻿namespace Exercise10
{
    class Result
    {

        /*
         * Complete the 'balancedSums' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static string balancedSums(List<int> arr)
        {
            var finalAnswer = "NO";
            var sumLeft = 0;
            var sumRight = arr.Sum();

            for (var i = 0; i < arr.Count; i++)
            {
                if (i > 0)
                    sumLeft += arr[i - 1];

                sumRight -= arr[i];

                if (sumLeft == sumRight)
                {
                    finalAnswer = "YES";
                    break;
                }
            }

            return finalAnswer;
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            int T = Convert.ToInt32(Console.ReadLine().Trim());

            for (int TItr = 0; TItr < T; TItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine().Trim());

                List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

                string result = Result.balancedSums(arr);

                Console.WriteLine(result);
            }
        }
    }

}