using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblems2
{
    public class Result
    {
        public static int LonelyInteger(List<int> a)
        {
            int result = 0;
            int firstNumber = 0;
            int secondNumber = 0;

            a.Sort();

            for (int i = 0; i < a.Count; i = i + 2)
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

        public static List<int> CountingSort(List<int> arr)
        {
            List<int> frequencyArray = new List<int>(new int[100]);
            int value = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                value = arr[i];
                frequencyArray[value]++;
            }


            return frequencyArray;
        }

        public static int FlippingMatrix(List<List<int>> matrix)
        {
            List<int> row = new List<int>();
            List<int> column = new List<int>();
            int number = 0;
            int mirrorNumber = 0;
            int result = 0;

            for (int j = 0; j < matrix.Count; j++)
            {
                for (int i = 0; i < matrix.Count; i++)
                {
                    column.Add(matrix[i][j]);
                }

                for (int k = 0; k < column.Count / 2; k++)
                {
                    number = column[k];
                    mirrorNumber = column[column.Count - 1 - k];

                    if (number < mirrorNumber)
                    {
                        column[k] = mirrorNumber;
                        column[column.Count - 1 - k] = number;
                    }
                }

                for (int i = 0; i < column.Count; i++)
                {
                    matrix[i][j] = column[i];
                }

                number = 0;
                mirrorNumber = 0;
                column.Clear();
            }

            for (int i = 0; i < matrix.Count / 2; i++)
            {
                row = matrix[i];

                for (int j = 0; j < row.Count / 2; j++)
                {
                    number = row[j];
                    mirrorNumber = row[row.Count - 1 - j];

                    if (number < mirrorNumber)
                    {
                        row[j] = mirrorNumber;
                        row[row.Count - 1 - j] = number;
                    }
                }

                number = 0;
                mirrorNumber = 0;
            }

            for (int i = 0; i < matrix.Count / 2; i++)
            {
                for (int j = 0; j < matrix.Count / 2; j++)
                {
                    result += matrix[i][j];
                }
            }

            return result;
        }
    }
}

//1
//2
//112 42 83 119
//56 125 56 49
//15 78 101 43
//62 98 114 108
