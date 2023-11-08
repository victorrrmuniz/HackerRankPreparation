namespace Exercise8
{
    class Result
    {

        /*
         * Complete the 'countingSort' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static List<int> countingSort(List<int> arr)
        {
            var frequencyList = Enumerable.Repeat(0, 100).ToList();

            foreach (var item in arr)
                frequencyList[item]++;

            return frequencyList;
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            List<int> result = Result.countingSort(arr);

            Console.WriteLine("\n\n" + String.Join(" ", result));

        }
    }
}