using System;
using System.Diagnostics.Metrics;
using System.Linq;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] m_stroka = Convert.ToString(Console.ReadLine()).Split();

            Console.WriteLine($"zadanie 1: {RefactorSting(m_stroka)}");
            Console.WriteLine($"zadanie 2: {ChetGlasn(RefactorSting(m_stroka))}");
            Console.WriteLine($"zadanie 3: {DlinaSlov(RefactorSting(m_stroka))}");
            Console.WriteLine($"zadanie 4:");
            foreach (string element in WordsA(RefactorSting(m_stroka))) {
                Console.Write($"{element}   ");
            }
        }

        public static string RefactorSting(string[] m_stroka) {
            List<String> f_str = new List<String>();
            string new_string = "";

            for (int i = 0; i < m_stroka.Length; i++) {
                if (m_stroka[i] != "") {
                    f_str.Add(m_stroka[i]);
                }
            }
            string[] array = f_str.ToArray();

            for (int k = 0; k < array.Length - 1; k++) {
                new_string += array[k] + " ";
            }
            new_string += array[^1];
            
            return new_string;
        }

        public static int ChetGlasn(string ystring) {
            string[] array = ystring.Split();
            int count_w = 0;

            for (int i = 0; i < array.Length; i++) {
                if (AreVowelsAtEvenPositions(array[i])) {
                    count_w++;
                }
            }

            return count_w;
        }

        public static int DlinaSlov(string ystring) {
            string[] array = ystring.Split();
            int count = 0;

            for (int i = 0; i < array.Length; i++) {
                if ((array[i].Length % 2 != 0) && (Convert.ToString(array[i][0]).ToLower() == Convert.ToString(array[i][^1]).ToLower())) {
                    count++;
                }
            }
            return count;
        }

        public static List<string> WordsA(string ystring) {
            string[] array = ystring.Split();
            List<String> result = new List<string>();

            foreach (string element in array) {
                if (element.ToLower().Contains('a')) {
                    result.Add(element);
                }
            }
            return result;
        }

        static bool AreVowelsAtEvenPositions(string input)
        {
        string vowels = "aeiouAEIOU";
        
        for (int i = 1; i < input.Length; i += 2)
        {
            if (!vowels.Contains(input[i]))
            {
                return false;
            }
        }
        return true;
        }
}
}
