namespace HackerRankProblems1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //int n = Convert.ToInt32(Console.ReadLine().Trim());

            //List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList()
            //    .Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            //Result.plusMinus(arr);



            //List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList()
            //    .Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            //Result.miniMaxSum(arr);



            string s = Console.ReadLine();

            string result = Result.timeConversion(s);

            Console.WriteLine(result);
        }
    }
}
