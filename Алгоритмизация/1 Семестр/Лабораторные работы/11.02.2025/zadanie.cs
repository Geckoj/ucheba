using System;
using static Program;

public class Program
{
    public class Person
    {
        public string name { get; set; }
        public Phone_Number number { get; set; }
        public string town { get; set; }
        public Person(string name, Phone_Number number, string town)
        {
            this.name = name;
            this.number = number;
            this.town = town;
        }

        public override string ToString()
        {
            return $"{name}\t{number}\t{town}";
        }
    }

    public class Phone_Number
    {
        public List<string> numbers { get; set; }
        public List<string> ops { get; set; }
        public List<string> date { get; set; }
        public Phone_Number(List<string> numbers, List<string> ops, List<string> date)
        {
            this.numbers = numbers;
            this.ops = ops;
            this.date = date;
        }
    }

    public static List<Person> people = new List<Person>();
    public static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Добавление данных[1]\nПросмотр данных[2]\nВыборка[3]\nВыход[x]");
            string input = Console.ReadLine();

            if (input == "1")
            {
                Console.Clear();
                Console.WriteLine("Введите данные о пользователе:");
                Console.WriteLine("ФИО");
                string name = Console.ReadLine();
                Console.WriteLine("Номера");
                Phone_Number numbers = CreatePhoneNumber(name);
                Console.WriteLine("Город");
                string town = Console.ReadLine();

                Person new_person = new Person(name, numbers, town);

                people.Add(new_person);
            }
            if (input == "2")
            {
                Console.Clear();
                Console.WriteLine("Пользователи в базе данных:");
                DisplayPersonInf(people);
                Console.WriteLine("(Enter для выхода)");
                input = Console.ReadLine();
                
            }
            if (input == "3")
            {
                Console.Clear();
                Console.WriteLine("Осуществить выборку по:\nДате заключения договора[1]\n" +
                    "Оператору связи[2]\nНомеру телефона[3]\nГороду проживания[4]\nНазад[x]\n");
                string input_1 = Console.ReadLine();
              
                if (input_1 == "1")
                {
                    Console.Clear();
                    string targ_date = Console.ReadLine();
                    Console.WriteLine($"Выборка по дате {targ_date}");
                    SortByDate(people, targ_date);
                    Console.ReadLine();
                }
                if (input_1 == "2")
                {
                    Console.Clear();
                    string targ_op = Console.ReadLine();
                    Console.WriteLine($"Выборка по оператору {targ_op}");
                    SortByOp(people, targ_op);
                    Console.ReadLine();
                }
                if (input_1 == "3")
                {
                    Console.Clear();
                    string targ_number = Console.ReadLine();
                    Console.WriteLine($"Выборка по номеру {targ_number}");
                    SortByNumber(people, targ_number);
                    Console.ReadLine();
                }
                if (input_1 == "4")
                {
                    Console.Clear();
                    string targ_town = Console.ReadLine();
                    Console.WriteLine($"Выборка по городу {targ_town}");
                    SortByTown(people, targ_town);
                    Console.ReadLine();
                }
                if (input_1 == "x")
                {
                    Console.Clear();
                }
            }
            if (input == "x")
            {
                break;
            }
        }
        
        Console.Clear();
    }

    public static Phone_Number CreatePhoneNumber(string p_name)
    {
        List<string> p_numbers = new List<string>();
        List<string> p_ops = new List<string>();
        List<string> p_date = new List<string>();

        Phone_Number new_phone_number = new Phone_Number(p_numbers, p_ops, p_date);

        Console.WriteLine($"Введите количество номеров пользователя {p_name}");

        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Введите данные о номере №{i+1}");
            
            string number = Console.ReadLine();
            string op = Console.ReadLine();
            string date = Console.ReadLine();

            p_numbers.Add(number);
            p_ops.Add(op);
            p_date.Add(date);

            new_phone_number = new Phone_Number(p_numbers, p_ops, p_date);   
        }

        return new_phone_number;
    }

    public static void DisplayPersonInf(List<Person> persons)
    {
        foreach (Person person in persons)
        {
            int n = person.number.numbers.Count;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{person.name}\t{person.number.numbers[i]}\t{person.number.ops[i]}" +
                $"\t{person.number.date[i]}\t{person.town}");
            }
        }
    }

    public static void SortByDate(List<Person> persons, string target_date)
    {
        foreach (Person person in persons)
        {
            int n = person.number.numbers.Count;

            for (int i = 0; i < n; i++)
            {
                if (person.number.date[i] == target_date)
                {
                    Console.WriteLine($"{person.name}\t{person.number.numbers[i]}\t{person.number.ops[i]}" +
                    $"\t{person.number.date[i]}\t{person.town}");
                }
            }
        }
    }

    public static void SortByOp(List<Person> persons, string target_op)
    {
        foreach (Person person in persons)
        {
            int n = person.number.numbers.Count;

            for (int i = 0; i < n; i++)
            {
                if (person.number.ops[i] == target_op)
                {
                    Console.WriteLine($"{person.name}\t{person.number.numbers[i]}\t{person.number.ops[i]}" +
                    $"\t{person.number.date[i]}\t{person.town}");
                }
            }
        }
    }

    public static void SortByNumber(List<Person> persons, string target_number)
    {
        foreach (Person person in persons)
        {
            int n = person.number.numbers.Count;

            for (int i = 0; i < n; i++)
            {
                if (person.number.numbers[i] == target_number)
                {
                    Console.WriteLine($"{person.name}\t{person.number.numbers[i]}\t{person.number.ops[i]}" +
                    $"\t{person.number.date[i]}\t{person.town}");
                }
            }
        }
    }
    public static void SortByTown(List<Person> persons, string target_town)
    {
        foreach (Person person in persons)
        {
            int n = person.number.numbers.Count;

            for (int i = 0; i < n; i++)
            {
                if (person.town == target_town)
                {
                    Console.WriteLine($"{person.name}\t{person.number.numbers[i]}\t{person.number.ops[i]}" +
                    $"\t{person.number.date[i]}\t{person.town}");
                }
            }
        }
    }
}
