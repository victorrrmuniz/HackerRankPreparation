namespace Exercise15
{
    class Result
    {

        /*
         * Complete the 'anagram' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts STRING s as parameter.
         */

        public static int anagram(string s)
        {
            if (s.Length % 2 != 0)
            {
                return -1;
            }

            int mid = s.Length / 2;
            string s1 = s.Substring(0, mid);
            string s2 = s.Substring(mid);

            int[] freqS1 = new int[26];
            int[] freqS2 = new int[26];

            foreach (char c in s1)
            {
                freqS1[c - 'a']++;
            }

            foreach (char c in s2)
            {
                freqS2[c - 'a']++;
            }

            int changesNeeded = 0;
            for (int i = 0; i < 26; i++)
            {
                changesNeeded += Math.Abs(freqS1[i] - freqS2[i]);
            }

            return changesNeeded / 2;
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine().Trim());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s = Console.ReadLine();

                int result = Result.anagram(s);

                Console.WriteLine(result);
            }
        }
    }
}