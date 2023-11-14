namespace Exercise14
{
    class Result
    {

        /*
         * Complete the 'getTotalX' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY a
         *  2. INTEGER_ARRAY b
         */

        public static int getTotalX(List<int> a, List<int> b)
        {
            int maxA = a.Max();
            int minB = b.Min();
            int count = 0;

            for (int i = maxA; i <= minB; i++)
            {
                bool factorOfB = b.All(num => num % i == 0);
                bool factorOfA = a.All(num => i % num == 0);

                if (factorOfA && factorOfB)
                {
                    count++;
                }
            }

            return count;
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int m = Convert.ToInt32(firstMultipleInput[1]);

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            List<int> brr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();

            int total = Result.getTotalX(arr, brr);

            Console.WriteLine(total);
        }
    }
}