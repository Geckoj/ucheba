using System;

public class Program
{
    public class Car
    {
        public string mark { get; set; }
        public string fio { get; set; }
        public string year { get; set; }
        public bool is_washed { get; set; }

        public override string ToString()
        {
            return $"{mark}, {fio}, {year}";
        }
    }
    public static class Washing
    {
        public static void Wash(Car car)
        {
            Console.WriteLine($"Машина {car} помыта");
            car.is_washed = true;
        }
    }

    public delegate void Washer();

    public static List<Car> garage = new List<Car>();

    public static void Main()
    {
        Console.WriteLine("Введите элементы списка ('x' чтобы закончить)");
        string input = "-1";
        while (input != "x")
        {
            input = Console.ReadLine();

            if (input != "x")
            {
                Car new_car = new Car
                {
                    mark = input.Split()[0],
                    fio = input.Split()[1],
                    year = input.Split()[2],
                    is_washed = Convert.ToBoolean(input.Split()[3])
                };
                garage.Add(new_car);
            }
        }

        Print_List();
        Console.WriteLine();

        Washer wash_unwashed = () =>
        {
            for (int i = 0; i < garage.Count; i++)
            {
                if (!garage[i].is_washed)
                {
                    Washing.Wash(garage[i]);
                }
            }
        };
        

        wash_unwashed();
        Console.WriteLine();
        Print_List();
    }
    public static void Print_List()
    {
        foreach (Car element in garage)
        {
            Console.WriteLine($"{element}:\t{element.is_washed}");
        }
    }
}
