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
                    else if (arr1[i, j] == maxValue && (i < maxIndexRow || (i == maxIndexRow && j < maxIndexCol)))
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
                    else if (arr1[i, j] == minValue && (i > minIndexRow || (i == minIndexRow && j > minIndexCol)))
                    {
                        minIndexRow = i;
                        minIndexCol = j;
                    }
                }
            }
            Console.WriteLine($"Minimal value in arr1 = {minValue}");
            Console.WriteLine($"Coordinates of the minimum element in arr1: [{minIndexRow}, {minIndexCol}]");

            // Task 5
            /*Знайти індекси першого входження максимального елемента. Виведіть два числа: номер рядка і номер стовпця, 
            який містить найбільший елемент двовимірного масиву. Якщо таких елементів кілька, то відображається той,
            у якого номер нижнього рядка, а якщо номери рядків рівні, то виводиться той, у якого номер нижнього стовпця.*/
            maxValue = arr1[0, 0]; maxIndexRow = 0; maxIndexCol = 0;
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    if ((arr1[i, j] > maxValue))
                    {
                        maxValue = arr1[i, j];
                        maxIndexRow = i;
                        maxIndexCol = j;
                    }
                    else if (arr1[i,j] == maxValue && i > maxIndexRow || arr1[i, j] == maxValue && i == maxIndexRow && j < maxIndexCol)
                    { // якщо треба стовпець праворуч, то треба змінити j < maxIndexCol на j > maxIndexCol.
                        maxIndexRow = i;
                        maxIndexCol = j;
                    }
                }
            }
            Console.WriteLine($"\nYour coordinates are: [{maxIndexRow}, {maxIndexCol}].\n");

            // Task 6
            /*Задається непарне число n. Створіть двовимірний масив з n x n елементів, 
             *заповнивши його символами "." (Кожен елемент масиву є односимвольним рядком.) 
             *Потім заповніть середній рядок масиву, середній стовпець масиву, головну діагональ 
             *і бічну діагональ символами "*". В результаті одиниці в масиві повинні сформувати зображення зірочки. 
             *Виведіть отриманий масив на екран, відокремлюючи елементи масиву пробілами.*/
            int n = 3;
            string[,] arr2 = new string[n, n];
            for (int i = 0; i < n; i++) // Filling array
            {
                for (int j = 0; j < n; j++)
                {
                    arr2[i,j] = ".";
                }
            }
            PrintArray(arr2);

            for (int j = 0; j < n; j++) // Middle row
            {
                arr2[1,j] = "*";
            }
            PrintArray(arr2);
            ResetArray(arr2);

            for (int i = 0; i < n; i++) // Middle col
            {
                arr2[i,1] = "*";
            }
            PrintArray(arr2);
            ResetArray(arr2);

            for (int i = 0; i < n; i++) // Main diagonal
            {
                for (int j = 0;j < n; j++)
                {
                    if (i == j)
                    {
                        arr2[i,j] = "*";
                    }
                }
            }
            PrintArray(arr2);
            ResetArray(arr2);

            for (int i = n-1, j = 0; i >= 0; i--) // Secondary diagonal
            {
                arr2[i, j] = "*";
                j++;
            }
            PrintArray(arr2);
            ResetArray(arr2);

            // Task 7
            /*Задано квадратний масив. Поміняйте місцями елементи по головній і бічній діагоналі, 
             *причому кожен елемент повинен залишитися в одній колонці
             *(тобто в кожному стовпці потрібно міняти місцями елементи по головній діагоналі і по бічній діагоналі).*/
            n = 3;
            int[,] arr3 = new int[n, n];
            for (int i = 0, counter = 1;i < n; i++) // Filling array
            {
                for (int j = 0; j < n; j++)
                {
                    arr3[i, j] = counter;
                    counter++;
                }
            }
            PrintArray(arr3);
            Console.WriteLine();

            int temp;
            for (int i = 0, counter = 1; i < n; i++) // Swapping columns on main and secondary diagonals
            {
                for (int j = 0; j < n; j++)
                {
                    if (i==j)
                    {
                        SwapTwoPositions(arr3, i, j, n-counter, j);
                        counter++;
                    }
                }
            }
            PrintArray(arr3);
            Console.WriteLine();

            // Task 8
            /*Заданий прямокутний масив розміром n x m. 
             *Поверніть його на 90 градусів за годинниковою стрілкою,
             *записавши результат в новий масив розміром m x n.*/
            n = 3;
            int m = 4;
            int[,] arr4 = new int[n, m];
            for (int i = 0, counter = 1; i < n; i++) // Filling array
            {
                for (int j = 0; j < m; j++)
                {
                    arr4[i, j] = counter;
                    counter++;
                }
            }
            PrintArray(arr4);
            Console.WriteLine();

            int[,] arr4_rotated = RotateClockwise(arr4);
            PrintArray(arr4_rotated);


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
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void PrintArray(string[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void ResetArray(string[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = ".";
                }
            }
        }

        static void SwapTwoPositions(int[,] array, int row1, int col1, int row2, int col2)
        {
            int temp = array[row1, col1];
            array[row1, col1] = array[row2, col2];
            array[row2, col2] = temp;
        }

        static int[,] RotateClockwise(int[,] array)
        {
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);

            int[,] rotatedArray = new int[columns, rows];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    rotatedArray[j, rows - 1 - i] = array[i, j];
                }
            }

            return rotatedArray;
        }
    }
}