using System;
using System.Linq;
using System.Reflection.PortableExecutable;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num = "";

            Directory.CreateDirectory("RESULTAT/");

            for (int g = 1; g <= 12; g++)
            {
                if (g < 10)
                {
                    num = "0" + Convert.ToString(g);
                }
                else
                {
                    num = Convert.ToString(g);
                }
                Solution(num);
            }
        }

        static double CoefficientX(string x)
        {
            string cf = x.Replace("x", "");

            if (cf == "")
            {
                return 1.0d;
            }
            else if (cf == "-")
            {
                return -1.0d;
            }
            else
            {
                return Convert.ToDouble(cf);
            }
        }

        static double Ops(string k, string k1, string op)
        {
            double kf = CoefficientX(k);
            double a = CoefficientX(k1);

            if (op == "+")
            {
                kf += a;
            }
            else if (op == "-")
            {
                kf -= a;
            }
            else if (op == "*")
            {
                kf *= a;
            }
            else if (op == "/")
            {
                kf /= a;
            }
            return kf;
        }

        static void Solution(string number)
        {
            string[] lines = File.ReadAllLines($"input/input_s1_{number}.txt");
            double result = Convert.ToDouble(lines[lines.Length-1]);
            double[] pair = [1, 0];

            for (int i = 1; i < lines.Length-1; i++)
            {
                string[] temp_line = lines[i].Split();

                if (temp_line[1].Count(f => f == 'x') != 0)
                {
                    pair[0] = Ops(Convert.ToString(pair[0]), temp_line[1], temp_line[0]);
                }
                else
                {
                    if (temp_line[0] == "+" || temp_line[0] == "-")
                    {
                        pair[1] = Ops(Convert.ToString(pair[1]), temp_line[1], temp_line[0]);
                    }
                    else
                    {
                        pair[0] = Ops(Convert.ToString(pair[0]), temp_line[1], temp_line[0]);
                        pair[1] = Ops(Convert.ToString(pair[1]), temp_line[1], temp_line[0]);
                    }
                }
            }
            double answer = (result - pair[1]) / pair[0];
            Console.WriteLine($"input_s1_{number}.txt: {answer}");
            
            using(StreamWriter writetext = new StreamWriter($"RESULTAT/RES{number}.txt"))
            {
                writetext.WriteLine($"{answer}");
            }
        }
    }
}
