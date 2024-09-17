using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblems3
{
    public class Result
    {
        public static List<int> FindZigZagSequence(List<int> arr)
        {
            List<int> result = new List<int>(arr);
            int firstValue = 0;
            int lastValue = 0;
            int j = result.Count - 1;

            result.Sort();

            for (int i = result.Count / 2; i < result.Count / 2 + result.Count / 4 + 1; i++)
            {
                firstValue = result[i];
                lastValue = result[j];

                result[i] = lastValue;
                result[j] = firstValue;

                j--;
            }

            return result;
        }

        public static int TowerBreakers(int n, int m)
        {
            int result = m == 1 ? 2 : n % 2 == 1 ? 1 : 2;

            return result;

            if (m == 1)
            {
                return 2;
            }
            else
            {
                if (n % 2 == 1)
                {
                    return 1;
                }

                return 2;
            }
        }

        public static string CaesarCipher(string s, int k)
        {
            char[] charArray = s.ToCharArray();
            string result = string.Empty;
            k %= 26;

            for (int i = 0; i < s.Count(); i++)
            {
                char c = charArray[i];

                int asciiCode = Convert.ToInt32(c);

                if (65 <= asciiCode && asciiCode <= 90)
                {
                    if (asciiCode + k > 90)
                    {
                        asciiCode += (k - 26);
                    }
                    else
                    {
                        asciiCode += k;
                    }
                }
                else if (97 <= asciiCode && asciiCode <= 122)
                {
                    if (asciiCode + k > 122)
                    {
                        asciiCode += (k - 26);
                    }
                    else
                    {
                        asciiCode += k;
                    }
                }

                c = Convert.ToChar(asciiCode);

                result = result + c;
            }

            return result;
        }

        public static int PalindromeIndex(string s)
        {
            int index = -1;
            int j = s.Length - 1;
            string first = string.Empty;
            string second = string.Empty;

            for (int i = 0; i < s.Length / 2; i++)
            {
                first = s.Substring(i, 1);
                second = s.Substring(j, 1);

                if (!first.Equals(second))
                {
                    if (first.Equals(s.Substring(j - 1, 1)))
                    {
                        if (index != - 1)
                        {
                            return -1;
                        }

                        index = j;
                        j--;
                    }
                    else if (second.Equals(s.Substring(i + 1, 1)))
                    {
                        if (index != -1)
                        {
                            return -1;
                        }

                        index = i;
                        i++;
                    }
                }

                j--;
            }

            return index;
        }
    }
}
