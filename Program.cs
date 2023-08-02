using System.Data;

namespace Hometask7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            // Task 1
            /*Заданий двовимірний масив.Визначити: 
             * а) Сума всіх елементів третього рядка масиву; 
             * б) Сума всіх елементів s-го стовпця масиву.*/
            int rows = 5;
            int cols = 5;
            int[,] arr1 = new int[rows,cols];
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    arr1[i, j] = rnd.Next(0, 10);
                }
            }
            PrintArray(arr1);
            int s = 4;
            int sum = 0;

            // a)
            for (int j = 0; j < arr1.GetLength(1); j++)
            {
                sum += arr1[2,j];
            }
            Console.WriteLine($"Sum = {sum}.");

            // b)
            sum = 0;
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                sum += arr1[i, s-1];
            }
            Console.WriteLine($"Sum = {sum}.\n");

            // Task 2
            // a)
            sum = 0;
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                sum += arr1[i, 1];
            }
            Console.WriteLine($"Sum = {sum}.");

            // b)
            sum = 0;
            int k = 2;
            for (int j = 0;j < arr1.GetLength(1); j++)
            {
                sum += arr1[k-1, j];
            }
            Console.WriteLine($"Sum = {sum}.\n");

            // Task 3
            // a)
            sum = 0;
            for (int j = 0; j < arr1.GetLength(1); j++)
            {
                sum += arr1[1, j] * arr1[1, j];
            }
            Console.WriteLine($"Sum = {sum}.");

            // b)
            sum = 0;
            int c = 2;
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                sum += arr1[i, c - 1] * arr1[i, c - 1];
            }
            Console.WriteLine($"Sum = {sum}.\n");

            // Task 4
            // а)
            int maxValue = arr1[0, 0];
            int maxIndexRow = 0;
            int maxIndexCol = 0;

            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    if (arr1[i, j] > maxValue) // d)
                    {
                        maxValue = arr1[i, j];
                        maxIndexRow = i;
                        maxIndexCol = j;
                    }
                    else if (arr1[i, j] == maxValue && (i > maxIndexRow || (i == maxIndexRow && j > maxIndexCol)))
                    {
                        maxIndexRow = i;
                        maxIndexCol = j;
                    }
                }
            }
            Console.WriteLine($"Maximum value in arr1 = {maxValue}");
            Console.WriteLine($"Coordinates of the maximum element in arr1: [{maxIndexRow}, {maxIndexCol}]");

            // b) 
            int minValue = arr1[0, 0];
            int minIndexRow = 0;
            int minIndexCol = 0;

            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    if (arr1[i, j] < minValue) // c)
                    {
                        minValue = arr1[i, j];
                        minIndexRow = i;
                        minIndexCol = j;
                    }
                    else if (arr1[i, j] == minValue && (i < minIndexRow || (i == minIndexRow && j < minIndexCol)))
                    {
                        minIndexRow = i;
                        minIndexCol = j;
                    }
                }
            }
            Console.WriteLine($"Minimal value in arr1 = {minValue}");
            Console.WriteLine($"Coordinates of the minimum element in arr1: [{minIndexRow}, {minIndexCol}]");


        }

        static void PrintArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
        }

        static void PrintArray(int[,] array) 
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}