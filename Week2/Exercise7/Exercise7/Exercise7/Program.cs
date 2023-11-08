namespace Exercise7
{
    internal class Program
    {
        class Result
        {

            /*
             * Complete the 'dynamicArray' function below.
             *
             * The function is expected to return an INTEGER_ARRAY.
             * The function accepts following parameters:
             *  1. INTEGER n
             *  2. 2D_INTEGER_ARRAY queries
             */

            public static List<int> dynamicArray(int n, List<List<int>> queries)
            {
                List<int> result = new List<int>();
                List<List<int>> arr = new List<List<int>>();
                int lastAnswer = 0;

                for (int i = 0; i < n; i++)
                {
                    arr.Add(new List<int>());
                }

                foreach (List<int> query in queries)
                {
                    int queryType = query[0];
                    int x = query[1];
                    int y = query[2];
                    int idx = ((x ^ lastAnswer) % n);

                    if (queryType == 1)
                    {
                        arr[idx].Add(y);
                    }
                    else if (queryType == 2)
                    {
                        int size = arr[idx].Count;
                        lastAnswer = arr[idx][y % size];
                        result.Add(lastAnswer);
                    }
                }

                return result;
            }

        }

        class Solution
        {
            public static void Main(string[] args)
            {
                string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                int n = Convert.ToInt32(firstMultipleInput[0]);

                int q = Convert.ToInt32(firstMultipleInput[1]);

                List<List<int>> queries = new List<List<int>>();

                for (int i = 0; i < q; i++)
                {
                    queries.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
                }

                List<int> result = Result.dynamicArray(n, queries);

                Console.WriteLine(String.Join("\n", result));
            }
        }
    }
}