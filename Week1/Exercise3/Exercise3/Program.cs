namespace Exercise3
{
    class Result
    {

        /*
         * Complete the 'timeConversion' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts STRING s as parameter.
         */

        public static string timeConversion(string s)
        {
            var time = s.Split(':');
            var newHours = int.Parse(time[0]);
            if (s.Contains("PM") && newHours < 12)
            {
                newHours += 12;
                if (newHours == 24)
                    newHours = 0;
            }

            if (s.Contains("AM") && newHours == 12)
                newHours = 0;

            return newHours.ToString().PadLeft(2, '0') + ":" + time[1] + ":" + time[2].Replace("AM", "").Replace("PM", "");
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            string result = Result.timeConversion(s);

            Console.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }

}