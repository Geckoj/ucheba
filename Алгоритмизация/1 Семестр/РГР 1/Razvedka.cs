using System;
using System.ComponentModel;
using System.Diagnostics.Metrics;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory("RESULTAT/");
            string number = "";
            
            for (int g = 1; g <= 10; g++)
            {
                if (g < 10)
                {
                    number = "0" + Convert.ToString(g);
                }
                else
                {
                    number = Convert.ToString(g);
                }
                Run(number);

            }            
        }

        static void Run(string number)
        {
            string[] lines = File.ReadAllLines($"input/input_s1_{number}.txt");
            Divide_g(Convert.ToInt32(lines[0]));

            using(StreamWriter writetext = new StreamWriter($"RESULTAT/RES{number}.txt"))
            {
                writetext.WriteLine($"{count}");
            }
            Console.WriteLine(count);
            count = 0;
        }

        static int count = 0;
        
        static void Divide_g(int number)
        {
            if (number <= 3)
            {
                if (number == 3)
                {
                    count++;
                }
                return;
            }
        
        int group_one = 0;
        int group_two = 0;
        
        if (number % 2 == 0)
        {
            group_one = number / 2;
            group_two = number / 2;
        }
        else
        {
            group_one = (number / 2);
            group_two = (number / 2) + 1;
        }
        
        Divide_g(group_one);
        Divide_g(group_two);
        }
    }
}
