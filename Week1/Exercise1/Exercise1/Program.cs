namespace Exercise1
{
    class Result
    {

        /*
         * Complete the 'plusMinus' function below.
         *
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static void plusMinus(List<int> arr)
        {
            double quantity = arr.Count();
            double positive = 0;
            double negative = 0;
            double zero = 0;

            foreach (int value in arr)
            {
                if (value == 0)
                    zero++;
                else if (value > 0)
                    positive++;
                else if (value < 0)
                    negative++;
                
            }

            Console.WriteLine(String.Format("{0:F6}", positive / quantity));
            Console.WriteLine(String.Format("{0:F6}", negative / quantity));
            Console.WriteLine(String.Format("{0:F6}", zero / quantity));
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            Result.plusMinus(arr);
        }
    }

}