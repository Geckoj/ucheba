using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
	public class Program
	{
		public static void Main(string[] args)
		{
			int m = Convert.ToInt32(Console.ReadLine());
			int n = Convert.ToInt32(Console.ReadLine());	
			
			int[,] mas = new int[m, n];
			int[] masst2 = new int[m];
			int[] masst3 = new int[m];

            int count = 0;

            int [] lines_zeros = new int[m];
            int [] line = new int[n];


			for (int i = 0; i < m; i++)
			{
				for (int j = 0; j < n; j++)
				{
					mas[i, j] = Convert.ToInt32(Console.ReadLine());
				}
			}

            Print2DArray(mas);

            Console.WriteLine("1 задание. Одинаковые пары столбцов:");
            
            for (int col1 = 0; col1 < n - 1; col1++)
            {
                for (int col2 = col1 + 1; col2 < n; col2++)
                {
                    for (int row = 0; row < m; row++)
                    {
                        masst2[row] = mas[row, col1];
                        masst3[row] = mas[row, col2]; 
                    }
                    
                    if (SortArray(masst2).SequenceEqual(SortArray(masst3)))
                    {
                        for (int j = 0; j < m; j++)
                        {
                            Console.Write($"{masst2[j]} \t{masst3[j]}\t");
                            Console.WriteLine();
                            count++;
                        }
                        
                        Console.WriteLine();
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Никакие столбцы не совпадают");
            }

            Console.WriteLine("2 задание:");

            Print2DArray(SortZeros(mas));

            Console.WriteLine("3 задание:");

            Print2DArray(SwapMinMax(mas));
        }

        public static int[] SortArray(int[] array)
        {
            int n = array.Length;
            int[] sortedArray = (int[])array.Clone();

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (sortedArray[j] > sortedArray[j + 1])
                    {
                        int temp = sortedArray[j];
                        sortedArray[j] = sortedArray[j + 1];
                        sortedArray[j + 1] = temp;
                    }
                }
            }

            return sortedArray;
        }

        public static int CountZeros(int[,] array, int row, int cols)
        {
            int zeroCount = 0;
            for (int col = 0; col < cols; col++)
            {
                if (array[row, col] == 0)
                {
                    zeroCount++;
                }
            }
            return zeroCount;
        }

        public static int[,] SortZeros(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            int[,] sortedArray = (int[,])array.Clone();

            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < rows - 1 - i; j++)
                {
                    int zeroCountCurrent = CountZeros(sortedArray, j, cols);
                    int zeroCountNext = CountZeros(sortedArray, j + 1, cols);

                    if (zeroCountCurrent < zeroCountNext)
                    {
                        for (int k = 0; k < cols; k++)
                        {
                            int temp = sortedArray[j, k];
                            sortedArray[j, k] = sortedArray[j + 1, k];
                            sortedArray[j + 1, k] = temp;
                        }
                    }
                }
            }

            return sortedArray;
        }

        public static void Print2DArray(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{array[i, j]} \t");
                }
                Console.WriteLine();
            }
        }

        public static int[,] SwapMinMax(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            int prev_max;
            int prev_min;
            
            int max = Int32.MinValue;
            int min = Int32.MaxValue;

            int[] maxc = new int[2];
            int[] minc = new int[2];

            int[,] sortedArray = (int[,])array.Clone();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    prev_max = max;
                    prev_min = min;
                    
                    max = Math.Max(max, sortedArray[i, j]);
                    min = Math.Min(min, sortedArray[i, j]);

                    if (max != prev_max)
                    {
                        maxc = [i, j];
                    }
                    if (min != prev_min)
                    {
                        minc = [i, j];
                    }
                }
            }

            sortedArray[maxc[0], maxc[1]] = min;
            sortedArray[minc[0], minc[1]] = max;

            return sortedArray;
        }
	}
}
