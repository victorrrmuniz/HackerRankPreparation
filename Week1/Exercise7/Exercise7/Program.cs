namespace Exercise7
{
    class Result
    {

        /*
         * Complete the 'diagonalDifference' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts 2D_INTEGER_ARRAY arr as parameter.
         */

        public static int diagonalDifference(List<List<int>> arr)
        {
            var columns = arr[0].Count;
            var diagonal1 = 0;
            var diagonal2 = 0;

            for (int i = 0; i < columns; i++)
            {
                diagonal1 += arr[i][i];
                diagonal2 += arr[i][columns - i - 1];
            }

            return Math.Abs(diagonal1 - diagonal2);
           
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = Result.diagonalDifference(arr);

            Console.WriteLine(result);
        }
    }
}