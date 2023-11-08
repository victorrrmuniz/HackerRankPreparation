namespace Exercise9
{
    class Result
    {
        /*
         * Complete the 'pangrams' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts STRING s as parameter.
         */

        public static string pangrams(string s)
        {
            var formattedString = s.ToLower();

            var asciiList = new List<int>();
            for (int i = 97; i <= 122; i++)
                asciiList.Add(1);

            foreach (char letter in formattedString)
            {
                if ((int)letter >= 97 && (int)letter <= 122)
                asciiList[(int)letter - 97]--;
            }

            return asciiList.Any(x => x == 1) ? "nor pangram" : "pangram";
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {

            string s = Console.ReadLine();

            string result = Result.pangrams(s);

            Console.WriteLine(result);

        }
    }
}