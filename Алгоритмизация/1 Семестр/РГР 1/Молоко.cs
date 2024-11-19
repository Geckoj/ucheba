using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.Arm;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory("RESULTAT/");

            Check(10);
        }

        static void Check(int number)
        {
            for (int aga = 1; aga <= number; aga++)
            {
                string[] lines = File.ReadAllLines($"input/input{aga}.txt");

                int firms_num = Convert.ToInt32(lines[0]);
                double min_milk = Double.MaxValue;
                int best_firm = 0;
                int count = 0;

                for (int i = 0; i < lines.Length; i++)
                {
                    string[] temp_line = lines[i].Split();
                    if (i > 0)
                    {
                        double prev_milk = min_milk;

                        double X1 = Convert.ToDouble(temp_line[0]);
                        double Y1 = Convert.ToDouble(temp_line[1]);
                        double Z1 = Convert.ToDouble(temp_line[2]);
                        double X2 = Convert.ToDouble(temp_line[3]);
                        double Y2 = Convert.ToDouble(temp_line[4]);
                        double Z2 = Convert.ToDouble(temp_line[5]);
                        double C1 = Convert.ToDouble(temp_line[6]);
                        double C2 = Convert.ToDouble(temp_line[7]);

                        double k = (X2 * Y2 * Z2) / (X1*Y1*Z1);
                        double S1 = 2 * (X1 * Y1 + X1 * Z1 + Z1* Y1);
                        double S2 = 2 * (X2 * Y2 + X2 * Z2 + Z2* Y2);
                        
                        min_milk = Math.Min(((C1 - (S1 * Math.Abs((C2 - k * C1) / (S2 - k * S1)))) / (X1*Y1*Z1))* 1000, min_milk);

                        if (min_milk < prev_milk)
                        {
                            best_firm = i;
                        }
                        count++;
                    }

                }
                using(StreamWriter writetext = new StreamWriter($"RESULTAT/RES{aga}.txt"))
                {
                    writetext.WriteLine($"{best_firm} {Math.Round(min_milk, 2).ToString("0.00")}");
                }

            Console.WriteLine($"file name: {$"input{aga}.txt"} \t output: {best_firm}, {Math.Round(min_milk, 2).ToString("0.00")}");
        }
        }
    }
}
