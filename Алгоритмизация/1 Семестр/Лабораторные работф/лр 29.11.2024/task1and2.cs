using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MyApp
{
    internal class Program
    {   
        static void Main(string[] args)
        {
            string stroka_1 = Console.ReadLine();
            string pattern_1 = "XYZ";
            
            
            char[] letters = new char[26];  
            int[] quantity = new int[26];
            
            Console.WriteLine($"ZADANIE 1: {Task1(stroka_1, pattern_1)}");

            string pattern_2 = "A*B";
            string stroka_2 = Console.ReadLine();
            
            // Console.WriteLine($"ZADANIE 2: {Task2(stroka_2, pattern_2, letters, quantity)}");
            
            Console.WriteLine("ZADANIE 2: ");
            Task2(stroka_2, pattern_2, letters, quantity);
            
        
        }
        public static int local_counter_1 = 0;
        public static int global_counter_1 = 0;
        public static int local_counter_2 = 0;
        public static int global_counter_2 = 0;
        
        public static int Task1 (string stroka, string pattern)
        {
            int k = 0;

            for (int i = 0; i < stroka.Length; i++)
            {
                if (stroka[i] == pattern[k])
                    {   
                        Counter(false);
                        k++;
                    }
                else
                    {
                        Counter(true);
                        k = 0;
                    }
                
                if (k == 3)
                {
                    k = 0;
                }
            }
            
            Counter(true);
            return global_counter_1;
        }

        public static void Task2 (string stroka, string pattern, char[] letters, int[] qnt)
        {
            for (int i = 0; i < stroka.Length - 2; i++)
            {
                if ((stroka[i] == pattern[0]) && (stroka[i+2] == pattern[2]))
                {
                    global_counter_2++;
                    if (Array.IndexOf(letters, Char.ToLower(stroka[i+1])) != -1)
                    {
                        qnt[Array.IndexOf(letters, Char.ToLower(stroka[i+1]))]++;
                    }
                    else
                    {
                        letters[global_counter_2] = Char.ToLower(stroka[i+1]);
                        qnt[Array.IndexOf(letters, Char.ToLower(stroka[i+1]))]++;
                    }
                }
            }

            for (int i = 0; i < qnt.Length; i++)
            {
                if (qnt[i] == qnt.Max())
                {
                    Console.WriteLine($"{letters[i]}: {qnt.Max()}");
                }
            }
        }
        
        public static void Counter(bool update)
        {
            if (!update)
            {
                local_counter_1++;
            }
            
            if (update)
            {
                if (local_counter_1 < 3)
                {
                    local_counter_1 = 0;
                }
                else
                {
                    global_counter_1 = Math.Max(global_counter_1, local_counter_1);
                    local_counter_1 = 0;
                }   
            }
        }
}
}
