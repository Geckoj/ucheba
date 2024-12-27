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

            public Xleb(int temp, int time, string name) : base(temp, time)
            {
                this.temp = temp;
                this.time = time;
                this.name = name;
            }

            public override string ToString()
            {
                return $"{temp}\t {time}\t{name}";
            }
        }

        public static List<Xleb> dataPech = new List<Xleb>();

        public static void Main()
        {
            while (true)
            {
                Console.WriteLine($"Добавить значение [1]\nОтобразить спискок[2]\nБыстрое заполнение[3]\nВыборка по времени[4]\nВыборка по температуре[5]");
                string input = Console.ReadLine();
                if (input == "1")
                {
                    Console.Clear();
                    try
                    {
                        Console.WriteLine("Добавить значение");
                        int temp = Convert.ToInt32(Console.ReadLine());
                        int time = Convert.ToInt32(Console.ReadLine());
                        string name = Console.ReadLine();
                        AddToBase(temp, time, name);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Неверный ввод");
                    }
            }
                if (input == "3")
                {
                    Console.Clear();
                    Console.WriteLine("Количество элементов:");
                    int n = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < n; i++)
                    {
                        Random rnd = new Random();
                        AddToBase(rnd.Next(10, 200), rnd.Next(10, 200), $"Хлеб {i}");
                    }

                }
                
                if (input == "2")
                {
                    Console.Clear();
                    Console.WriteLine("База данных:");
                    DisplayData(dataPech);
                }

                if (input == "4")
                {
                    Console.Clear();
                    if (dataPech.Count != 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Введите время");
                        int set_time = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Хлеб, который печётся дольше, чем {set_time}");
                        DisplayLongerTime(dataPech, set_time);
                    }
                    else
                    {
                        Console.WriteLine("База данных пуста");
                    }
                }
                if (input == "5")
                {
                    Console.Clear();
                    if (dataPech.Count != 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Введите температуру");
                        int set_temp = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Хлеб, который печётся при температуре {set_temp}");
                        DisplayOnTemp(dataPech, set_temp);
                    }
                    else
                    {
                        Console.WriteLine("База данных пуста");
                    }
                }

            }
        }

        public static void AddToBase(int temp, int time, string name)
        {
            Xleb new_xleb = new Xleb(temp, time, name);

            if (dataPech.IndexOf(new_xleb) == -1)
            {
                dataPech.Add(new_xleb);
            }
        }

        public static void DisplayData(List<Xleb> input)
        {
            foreach (Xleb i in input)
            {
                Console.WriteLine(i);
            }
        }

        public static void DisplayLongerTime(List<Xleb> input, int set_time)
        {
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i].time > set_time)
                {
                    Console.WriteLine(input[i]);
                }
            }
        }
        public static void DisplayOnTemp(List<Xleb> input, int set_temp)
        {
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i].temp == set_temp)
                {
                    Console.WriteLine(input[i]);
                }
            }
        }
    }
}
