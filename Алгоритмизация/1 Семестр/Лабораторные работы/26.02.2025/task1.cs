class Program
{
    public static HashSet<int> sostav = new HashSet<int>();
    public static Dictionary<int, int> amount = new Dictionary<int, int>();
    public static List<int> elements = new List<int>();

    public static void Main()
    {
        

        Console.WriteLine("Список элементов:");

        Console.WriteLine("Введите элементы списка ('x' чтобы закончить)");
        string input = "-1";
        while (input != "x")
        {
            input = Console.ReadLine();
            if (input != "x")
            {
                elements.Add(Convert.ToInt32(input));
            }
        }

        //Random random = new Random();
        //for (int i = 0; i < 25; i++)
        //{
        //    int k = random.Next(1, 10);
        //    elements.Add(k);
        //    Console.Write($"{k}\t");
        //}

        Console.WriteLine('\n');
        Console.WriteLine("Состав списка:");

        for (int i = 0; i < elements.Count; i++)
        {
            sostav.Add(elements[i]);
        }

        foreach (int elem in sostav)
        {
            Console.Write($"{elem}\t");

            amount.Add(elem, 0);
            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i] == elem)
                {
                    amount[elem] += 1;
                }
            }
        }

        var max_dict = amount.Values.Max();

        Console.WriteLine('\n');
        Console.WriteLine("Наиболее встречаемый элемент в списке:");

        foreach (KeyValuePair<int, int> elem in amount)
        {
            if (elem.Value == max_dict)
            {
                Console.WriteLine($"'{elem.Key}': {elem.Value}");
            }
        }
    }
}
