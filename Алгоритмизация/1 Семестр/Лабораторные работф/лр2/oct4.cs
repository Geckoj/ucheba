using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int current;
            int one_count = 0;
            int min_one_count = Int32.MaxValue;
            int prev = 0;

            int equalEvenCount = 0;
            int maxEqualEvenCount = 0;

            int summ = 0;
            int max_summ = Int32.MinValue;
            
            for (int i = 0; i < n; i++)
            {
                current = Convert.ToInt32(Console.ReadLine());
                
                if (current == 1)
                {
                    one_count++;
                }
                else
                {
                    if (one_count > 0)
                    {
                        min_one_count = Math.Min(min_one_count, one_count);
                        one_count = 0;
                    }
                }
                
                if (Math.Abs(current % 2) == 0)
                {
                    if (current == prev)
                    {
                        equalEvenCount++;
                    }
                    else
                    {
                        equalEvenCount = 1;
                    }
                    maxEqualEvenCount = Math.Max(maxEqualEvenCount, equalEvenCount);
                }
                else
                {
                    equalEvenCount = 0;
                }
                
                if (Math.Abs(current % 2) == 0)
                {
                    summ += current;
                }
                else
                {
                    if (summ != 0)
                    {
                        max_summ = Math.Max(max_summ, summ);
                        summ = 0;
                    }
                    else
                    {
                        max_summ = Math.Max(max_summ, 0);
                    }
                    
                }



                // Console.WriteLine($"summ: {summ}, max_summ: {max_summ}");
                prev = current;
            }

            if (one_count > 0)
            {
                min_one_count = Math.Min(min_one_count, one_count);
            }

            if (min_one_count == Int32.MaxValue)
            {
                min_one_count = 0;
            }

            if (summ != 0)
            {
                max_summ = Math.Max(max_summ, summ);
            }
            else
            {
                max_summ = Math.Max(max_summ, 0);
            }

            if (max_summ == Int32.MinValue)
            {
                max_summ = 0;
            }
            // Console.WriteLine($"summ: {summ}, max_summ: {max_summ}");
            
            
            Console.WriteLine($"1. максимальная длина последовательности четных равных элементов: {maxEqualEvenCount}");
            Console.WriteLine($"2. минимальная длина последовательности из единиц: {min_one_count}");
            Console.WriteLine($"3. максимальная сумма последовательности из четных элементов: {max_summ}");
            
        }
    }
}
