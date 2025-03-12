using System.Xml.Linq;

public class Program
{
    public class Person
    {
        public string number { get; set; }
        public string t_operator { get; set; }

        public override string ToString()
        {
            return $"{number}\t{t_operator}";
        }
    }

    public static List<Person> nomera = new List<Person>();
    public static Dictionary<string, int> dict = new Dictionary<string, int>();
    static void Main()
    {
        Console.WriteLine("Список элементов:");

        Console.WriteLine("Введите элементы списка ('x' чтобы закончить)");
        string input = "-1";
        while (input != "x")
        {
            input = Console.ReadLine();
            
            if (input != "x")
            {
                Person new_person = new Person
                {
                    number = input.Split()[0],
                    t_operator = input.Split()[1]
                };
                nomera.Add(new_person);
            }
        }
        Print_List();

        foreach (Person element in nomera)
        {
            if (!dict.ContainsKey(element.t_operator))
            {
                dict.Add(element.t_operator, 0);
            }
            
            if (dict[element.t_operator] == 0)
            {  
                for (int i = 0; i < nomera.Count; i++)
                {
                    if (nomera[i].t_operator == element.t_operator)
                    {
                        dict[element.t_operator] += 1;

                    }
                }
            }
        }

        var max_dict = dict.Values.Max();

        Console.WriteLine('\n');
        Console.WriteLine("Наиболее встречаемый оператор в списке:");

        foreach (KeyValuePair<string, int> elem in dict)
        {
            if (elem.Value == max_dict)
            {
                Console.WriteLine($"'{elem.Key}': {elem.Value}");
            }
        }
    }

    public static void Print_List()
    {
        foreach(Person element in nomera)
        {
            Console.WriteLine(element);
        }
    }
}
