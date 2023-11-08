namespace Exercise8
{
    class Result
    {

        /*
         * Complete the 'gridChallenge' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts STRING_ARRAY grid as parameter.
         */

        public static string gridChallenge(List<string> grid)
        {
            var arrayColumnSorted = new List<List<char>>();
            var greaterValue = 0;
            var finalAnswer = "NO";
            var breakAll = false;


            for (var i = 0; i < grid.Count; i++)
            {
                arrayColumnSorted.Add(new List<char>());
                foreach (char c in grid[i])
                    arrayColumnSorted[i].Add(c);
                arrayColumnSorted[i].Sort();
            }

            for (var i = 0; i < arrayColumnSorted[0].Count; i++)
            {
                greaterValue = 0;
                for (var k = 0; k < arrayColumnSorted.Count; k++)
                {
                    if (arrayColumnSorted[k][i] >= greaterValue)
                        greaterValue = arrayColumnSorted[k][i];
                    else
                    {
                        breakAll = true;
                        break;
                    }

                    if (breakAll)
                        break;
                }
            }

            if (!breakAll)
                finalAnswer = "YES";
            

            return finalAnswer;
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine().Trim());

                List<string> grid = new List<string>();

                for (int i = 0; i < n; i++)
                {
                    string gridItem = Console.ReadLine();
                    grid.Add(gridItem);
                }

                string result = Result.gridChallenge(grid);

                Console.WriteLine(result);
            }
        }
    }
}