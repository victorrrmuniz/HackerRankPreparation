namespace Exercise5
{
    class Result
    {

        /*
         * Complete the 'caesarCipher' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts following parameters:
         *  1. STRING s
         *  2. INTEGER k
         */

        public static string caesarCipher(string s, int k)
        {
            var newString = "";
            int newChar;

            foreach (char c in s)
            {
                newChar = (int)c;
                if (char.IsLetter(c))
                {
                    var isLower = char.IsLower(c);
                    newChar += (k % 26);
                    if (!char.IsLetter((char)newChar) || char.IsLower((char)newChar) != isLower)
                        newChar -= 26;
                }

                newString += (char)newChar;
            }

            return newString;
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            string s = Console.ReadLine();

            int k = Convert.ToInt32(Console.ReadLine().Trim());

            string result = Result.caesarCipher(s, k);

            Console.WriteLine(result);

        }
    }

}