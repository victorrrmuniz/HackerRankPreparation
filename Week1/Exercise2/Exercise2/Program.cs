using System.Numerics;

namespace Exercise2
{
    class Result
    {

        /*
         * Complete the 'miniMaxSum' function below.
         *
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static void miniMaxSum(List<int> arr)
        {
             Int64 minSum = 0;
             Int64 maxSum = 0;
             var cont = 0;

            foreach (var item in arr.OrderBy(x => x))
            {
                if (cont < 4)
                {
                    minSum += item;
                    cont++;
                }
            }

            cont = 0;
            foreach (var item in arr.OrderByDescending(x => x))
            {
                if (cont < 4)
                {
                    maxSum += item;
                    cont++;
                }
            }

            Console.WriteLine(minSum + " " + maxSum);
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            Result.miniMaxSum(arr);
        }
    }
}