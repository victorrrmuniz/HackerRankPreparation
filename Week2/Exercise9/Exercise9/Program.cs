using System;

namespace Exercise9
{
    public class Program
    {
        public static int[] month;

        static void Main(string[] args)
        {

            month = new int[13];

            var dates = Console.ReadLine();
            var datesSplitted = dates?.Split(" ");
            var firstDate = datesSplitted[0];
            var secondDate = datesSplitted[1];

            var dateItens = firstDate.Split("-");


            int d1 = int.Parse(dateItens[0]);
            int m1 = int.Parse(dateItens[1]);
            int y1 = int.Parse(dateItens[2]);

            dateItens = secondDate.Split("-");

            int d2 = int.Parse(dateItens[0]);
            int m2 = int.Parse(dateItens[1]);
            int y2 = int.Parse(dateItens[2]);

            int result = findPrimeDates(d1, m1, y1, d2, m2, y2);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static void updateLeapYear(int year)
        {
            if (year % 400 == 0)
            {
                month[2] = 28;
            }
            else if (year % 100 == 0)
            {
                month[2] = 28;
            }
            else if (year % 4 == 0)
            {
                month[2] = 29;
            }
            else
            {
                month[2] = 28;
            }
        }

        public static void storeMonth()
        {
            month[1] = 31;
            month[2] = 28;
            month[3] = 31;
            month[4] = 30;
            month[5] = 31;
            month[6] = 30;
            month[7] = 31;
            month[8] = 31;
            month[9] = 30;
            month[10] = 31;
            month[11] = 30;
            month[12] = 31;
        }

        public static int findPrimeDates(int d1, int m1, int y1, int d2, int m2, int y2)
        {
            storeMonth();

            int result = 0;

            while (true)
            {
                int x = d1 * 1000000;
                x += 10000 * m1;
                x += y1;
                if (x % 4 == 0 || x % 7 == 0)
                {
                    result = result + 1;
                }
                if (d1 == d2 && m1 == m2 && y1 == y2)
                {
                    break;
                }
                updateLeapYear(y1);
                d1 = d1 + 1;
                if (d1 > month[m1])
                {
                    m1 = m1 + 1;
                    d1 = 1;
                    if (m1 > 12)
                    {
                        y1 = y1 + 1;
                        m1 = 1;
                    }
                }
            }
            return result;
        }
    }
}