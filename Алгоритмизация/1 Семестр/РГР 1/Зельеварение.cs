using System;
using System.ComponentModel;

// в папке с исполняемым файлом должны лежать папки "input", "output" с соответственно
// input и output текстовыми файлами из условия задачи
// программа создаст папку с файлами, содержащими результат

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory("RESULTAT/");
            
            for (int i = 1; i < 11; i++)
            {
                Run(i);
            }
            for (int i = 1; i < 11; i++)
            {
                CheckRes(i);
            }
        }

        public static string Reverse( string s )
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static string Dict(string a, Dictionary<string, string> brew, string[] array)
        {
            if (a.Any(char.IsDigit))
            {
                if (brew.ContainsKey(a) == false)
                {
                    brew[a] = array[Convert.ToInt32(a)-1];
                    return brew[a];
                }
                else
                {
                    return brew[Convert.ToString(Convert.ToInt32(a) - 1)];
                }
            }
            else
            {
                return a;
            }
        }

        public static void Run(int number)
        {
            string[] lines = File.ReadAllLines($"input/input{number}.txt");

            string[] potions = new string[lines.Length];

            var brew = new Dictionary<string, string>()
            {
                { "MIX", "MX"},
                { "WATER", "WT"},
                { "DUST", "DT"},
                { "FIRE", "FR"}
            };

            for (int i = 0; i < lines.Length; i++)
            {
                string[] temp_line = lines[i].Split();
                
                for (int k = 1; k < temp_line.Length; k++)
                {
                    potions[i] += Dict(temp_line[k], brew, potions);
                }
                potions[i] = brew[temp_line[0]] + potions[i] + Reverse(brew[temp_line[0]]);
                brew[Convert.ToString(i)] = potions[i];
            }
            Console.WriteLine($"{potions.Last()}");

            using(StreamWriter writetext = new StreamWriter($"RESULTAT/RES{number}.txt"))
            {
                writetext.WriteLine(potions.Last());
            }
        }

        public static void CheckRes(int number)
        {
            string res1 = (File.ReadAllLines($"output/output{number}.txt"))[0];
            string res2 = (File.ReadAllLines($"RESULTAT/RES{number}.txt"))[0];
            
            if (res1 == res2)
            {
                Console.WriteLine($"input{number}.txt - verno");
            }
            else
            {
                Console.WriteLine($"input{number}.txt - neverno");
            }
        }
    }
}
