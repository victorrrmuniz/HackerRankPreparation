namespace Exercise3
{
    class Result
    {

        /*
         * Complete the 'pageCount' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER n
         *  2. INTEGER p
         */

        public static int pageCount(int n, int p)
        {
            int fromStart = p / 2;
            int fromEnd = (n / 2) - (p / 2);

            // Se a página de destino estiver mais próxima do final, ajuste fromEnd.
            if (fromStart > fromEnd)
            {
                return fromEnd;
            }

            return fromStart;
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            int p = Convert.ToInt32(Console.ReadLine().Trim());

            int result = Result.pageCount(n, p);

            Console.WriteLine(result);
        }
    }

}