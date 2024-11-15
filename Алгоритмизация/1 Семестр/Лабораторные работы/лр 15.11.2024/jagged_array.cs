using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WrireLine("n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] jag = new int[n][]; 

            PrintJaggedArray(RandomFill(jag));
        }

        static int[][] RandomFill(int[][] array)
        {
            Random rnd = new Random();
            int length_in;

            for (int i = 0; i < array.Length; i++)
            {
                length_in = rnd.Next(1, 20);
                int[] elem = new int[length_in];
                for (int j = 0; j < length_in; j++)
                {
                    elem[j] = rnd.Next(-256, 256);
                }
                array[i] = elem;
                // Console.WriteLine(i);
            }
            
            return array;
        }

        static void PrintJaggedArray(int[][] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write($"{array[i][j]} \t");
                }
                Console.Write($"max: {Max(array[i])} min: {Min(array[i])}");
                Console.WriteLine();
            }
        }

        static int Max(int[] array, int startIndex = 0)
        {
            int current = array[startIndex];

            if (startIndex + 1 == array.Length)
            {
                return current;
            }

            int nexts = Max(array, startIndex + 1);

            if (current >= nexts)
            {
                return current;
            }

            return nexts;
        }
        static int Min(int[] array, int startIndex = 0)
        {
            int current = array[startIndex];

            if (startIndex + 1 == array.Length)
            {
                return current;
            }

            int nexts = Min(array, startIndex + 1);

            if (current < nexts)
            {
                return current;
            }

            return nexts;
        }
    }
}
