using System.IO;

namespace HackerRankProblems3
{
    public class Program
    {
        static void Main(string[] args)
        {
            //int t = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < t; i++)
            //{
            //    int n = Convert.ToInt32(Console.ReadLine());

            //    List<int> arr = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToList();

            //    List<int> result = Result.FindZigZagSequence(arr);

            //    Console.WriteLine(String.Join(' ', result));
            //}



            //int t = Convert.ToInt32(Console.ReadLine().Trim());

            //for (int tItr = 0; tItr < t; tItr++)
            //{
            //    string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            //    int n = Convert.ToInt32(firstMultipleInput[0]);

            //    int m = Convert.ToInt32(firstMultipleInput[1]);

            //    int result = Result.TowerBreakers(n, m);

            //    Console.WriteLine(result);
            //}



            //int n = Convert.ToInt32(Console.ReadLine().Trim());

            //string s = Console.ReadLine();

            //int k = Convert.ToInt32(Console.ReadLine().Trim());

            //string result = Result.CaesarCipher(s, k);

            //Console.WriteLine(result);



            int q = Convert.ToInt32(Console.ReadLine().Trim());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s = Console.ReadLine();

                int result = Result.PalindromeIndex(s);

                Console.WriteLine(result);
            }



            Console.WriteLine();
        }
    }
}
