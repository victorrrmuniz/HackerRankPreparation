using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Exercise4
{
    class Result
    {

        /*
         * Complete the 'matchingStrings' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts following parameters:
         *  1. STRING_ARRAY strings
         *  2. STRING_ARRAY queries
         */

        public static List<int> matchingStrings(List<string> strings, List<string> queries)
        {
            var mathingList = Enumerable.Repeat(0, queries.Count).ToList();
          
            foreach (string s in strings)
            {
                for (int i = 0; i < queries.Count; i++)
                {
                    if (queries[i] == s)
                        mathingList[i]++;
                }
            }

            return mathingList;
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {

            int stringsCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> strings = new List<string>();

            for (int i = 0; i < stringsCount; i++)
            {
                string stringsItem = Console.ReadLine();
                strings.Add(stringsItem);
            }

            int queriesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> queries = new List<string>();

            for (int i = 0; i < queriesCount; i++)
            {
                string queriesItem = Console.ReadLine();
                queries.Add(queriesItem);
            }

            List<int> res = Result.matchingStrings(strings, queries);

            foreach (var item in res)
            {
                Console.WriteLine(item);
            }

        }
    }
}