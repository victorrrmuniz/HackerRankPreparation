﻿namespace Exercise4
{
    class Result
    {

        /*
         * Complete the 'towerBreakers' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER n
         *  2. INTEGER m
         */

        public static int towerBreakers(int n, int m)
        {
            if (n % 2 == 0 || m == 1)
            {
                return 2;
            }
            else
            {
                return 1;
            }
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                int n = Convert.ToInt32(firstMultipleInput[0]);

                int m = Convert.ToInt32(firstMultipleInput[1]);

                int result = Result.towerBreakers(n, m);

                Console.WriteLine(result);
            }
        }
    }

}