using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblems2
{
    public class Result
    {
        public static int LonelyInteger (List<int> a)
        {
            int result = 0;
            int firstNumber = 0;
            int secondNumber = 0;

            a.Sort();

            for (int i = 0; i< a.Count; i = i + 2)
            {
                firstNumber = a[i];

                if (i == (a.Count - 1))
                {
                    result = firstNumber;
                    break;
                }

                secondNumber = a[i + 1];

                if (firstNumber != secondNumber)
                {
                    result = firstNumber;
                    break;
                }
            }

            return result;
        }
    }
}
