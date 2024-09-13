using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblems1
{
    public class Result
    {
        public static void plusMinus(List<int> arr)
        {
            double positiveCount = arr.Where(x => x > 0).Count();
            double negativeCount = arr.Where(x => x < 0).Count();
            double zeroCount = arr.Where(x => x == 0).Count();

            Console.WriteLine(positiveCount / arr.Count);
            Console.WriteLine(negativeCount / arr.Count);
            Console.WriteLine(zeroCount / arr.Count);
        }

        public static void miniMaxSum (List<int> arr)
        {
            long max = arr.Max();
            long min = arr.Min();
            long sum = 0;

            foreach (int n in arr)
            {
                sum += n;
            }

            Console.WriteLine($"{sum - max} {sum - min}");
        }

        public static string timeConversion(string s)
        {
            int hours = Convert.ToInt32(s.Substring(0, 2));
            int minutes = Convert.ToInt32(s.Substring(3, 2));
            int seconds = Convert.ToInt32(s.Substring(6, 2));
            string amPm = s.Substring(s.Length - 2, 2);

            if (amPm.Equals("AM"))
            {                
                if (hours == 12)
                {
                    hours -= 12;
                }
            }
            else
            {
                if (hours < 12)
                {
                    hours += 12;
                }
            }

            return String.Format($"{hours:d2}:{minutes:d2}:{seconds:d2}");
        }
    }
}
