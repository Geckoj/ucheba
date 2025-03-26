using System;

namespace Xleb
{
    class Program
    {
        public class Pech
        {
            public int temp;
            public int time;

            public Pech(int temp, int time)
            {
                this.temp = temp;
                this.time = time;
            }
        }
        public class Xleb : Pech
        {
            public string name;
            public int ves;

            public Xleb(int temp, int time, string name, int ves) : base(temp, time)
            {
                this.name = name;
                this.ves = ves;
            }

            public override string ToString()
            {
                return $"{temp}\t {time}\t{name}\t{ves}";
            }
        }

        public class Meat: Pech
        {
            public string name;
            public int ves;

            public Meat(int temp, int time, string name, int ves) : base(temp, time)
            {
                this.name = name;
                this.ves = ves;
            }

            public override string ToString()
            {
                return $"{temp}\t {time}\t{name}\t{ves}";
            }
        }

        public static List<Xleb> dataPech = new List<Xleb>();
        public static List<Meat> dataPech1 = new List<Meat>();

        public static void Main()
        {
            while (true)
            {
                Console.WriteLine($"Отобразить спискок[1]\nБыстрое заполнение[2]\nВыборка по времени[3]\nВыборка по весу[4]");
                string input = Console.ReadLine();
                if (input == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Количество элементов:");
                    int n = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < n; i++)
                    {
                        Random rnd = new Random();
                        AddToBase(rnd.Next(10, 200), rnd.Next(10, 200), $"Хлеб {i}", rnd.Next(10, 200));
                        AddToBase1(rnd.Next(10, 200), rnd.Next(10, 200), $"Мясо {i}", rnd.Next(10, 200));
                    }

                }

                if (input == "1")
                {
                    Console.Clear();
                    Console.WriteLine("База данных:");
                    DisplayData(dataPech, dataPech1);
                }

                if (input == "3")
                {
                    Console.Clear();
                    if (dataPech.Count != 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Введите время");
                        int set_time = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Хлеб, который печётся {set_time} минут");
                        DisplayTimeXleb(dataPech, set_time);
                        Console.WriteLine($"Мясо, которое печётся {set_time} минут");
                        DisplayTimeMeat(dataPech1, set_time);
                    }
                    else
                    {
                        Console.WriteLine("База данных пуста");
                    }
                }
                if (input == "4")
                {
                    Console.Clear();
                    if (dataPech.Count != 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Введите температуру");
                        int set_temp = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Хлеб весом {set_temp}");
                        DisplayOnTempXleb(dataPech, set_temp);
                        Console.WriteLine($"Мясо весом {set_temp}");
                        DisplayOnTempMeat(dataPech1, set_temp);
                    }
                    else
                    {
                        Console.WriteLine("База данных пуста");
                    }
                }

            }
        }

        public static void AddToBase(int temp, int time, string name, int ves)
        {
            Xleb new_xleb = new Xleb(temp, time, name, ves);

            if (dataPech.IndexOf(new_xleb) == -1)
            {
                dataPech.Add(new_xleb);
            }
        }
        public static void AddToBase1(int temp, int time, string name, int ves)
        {
            Meat new_meat = new Meat(temp, time, name, ves);

            if (dataPech1.IndexOf(new_meat) == -1)
            {
                dataPech1.Add(new_meat);
            }
        }

        public static void DisplayData(List<Xleb> input1, List<Meat> input2)
        {
            foreach (Xleb i in input1)
            {
                Console.WriteLine(i);
            }
            foreach (Meat i in input2)
            {
                Console.WriteLine(i);
            }
        }

        public static void DisplayTimeXleb(List<Xleb> input, int set_time)
        {
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i].time == set_time)
                {
                    Console.WriteLine(input[i]);
                }
            }
        }

        public static void DisplayTimeMeat(List<Meat> input, int set_time)
        {
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i].time == set_time)
                {
                    Console.WriteLine(input[i]);
                }
            }
        }
        public static void DisplayOnTempXleb(List<Xleb> input, int set_temp)
        {
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i].ves == set_temp)
                {
                    Console.WriteLine(input[i]);
                }
            }
        }

        public static void DisplayOnTempMeat(List<Meat> input, int set_temp)
        {
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i].ves == set_temp)
                {
                    Console.WriteLine(input[i]);
                }
            }
        }
    }
}
