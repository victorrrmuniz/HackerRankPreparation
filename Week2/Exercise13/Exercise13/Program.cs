namespace Exercise13
{
    class Result
    {

        /*
         * Complete the 'palindromeIndex' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts STRING s as parameter.
         */

        public static int palindromeIndex(string s)
        {
            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                if (s[left] != s[right])
                {
                    if (IsPalindrome(s, left + 1, right))
                    {
                        return left;
                    }
                    else if (IsPalindrome(s, left, right - 1))
                    {
                        return right;
                    }
                    else
                    {
                        return -1;
                    }
                }

                left++;
                right--;
            }

            return -1;
        }

        private static bool IsPalindrome(string s, int start, int end)
        {
            while (start < end)
            {
                if (s[start] != s[end])
                {
                    return false;
                }
                start++;
                end--;
            }
            return true;
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

                int result = Result.palindromeIndex(s);

                Console.WriteLine(result);
            }

        }
    }
}