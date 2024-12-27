using System;
using System.IO.IsolatedStorage;
using System.Xml.Linq;

namespace Students
{
    class Program
    {
        public class Subject
        {
            public string name;
            public float mark;

            public Subject(string name, float mark)
            {
                this.name = name;
                this.mark = mark;
            }
            public override string ToString()
            {
                return $"{name}\t{mark}";
            }
        }

        public class Student
        {
            public string fio;
            public Subject[] marks;

            public Student(string fio, Subject[] marks)
            {
                this.fio = fio;
                this.marks = marks;
            }

            public float Average()
            {
                float avrg = 0;

                for (int i = 0; i < marks.Length; i++)
                {
                    avrg += marks[i].mark;
                }
                avrg = avrg / marks.Length;

                return avrg;
            }
            public override string ToString()
            {
                return $"{fio}\t{Average()}";
            }
        }
        
        public static List<Student> data = new List<Student>();

        public static void Main()
        {
            while(true)
            {
                Console.WriteLine("Заполнить базу данных[1]\nОтобразить базу данных[2]\nВыборка всех студентов со ср. баллом >4.5[3]\nВыход[4]");

                string input = Console.ReadLine();

                if (input == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Введите количество студентов");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите количество предметов");
                    int m = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < n; i++)
                    {
                        AddToBase($"ФИО№{i}", m);
                    }
                }
                if (input == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Список студентов:");
                    DisplayData(data);
                }
                if (input == "3")
                {
                    Console.Clear();
                    Console.WriteLine("Список студентов, со ср. баллом >4.5:");
                    DisplayAvrg45(data);
                }
                if (input == "4")
                {
                    Environment.Exit(0);
                }
            }
        }

        public static void AddToBase(string name, int n)
        {
            Random rnd = new Random();
            Subject[] marks = new Subject[n];

            for (int i = 0; i < n; i++)
            {
                marks[i] = new Subject($"Предмет_{i}", rnd.Next(3, 6)); 
            }

            Student new_student = new Student(name, marks);

            if (data.IndexOf(new_student) == -1)
            {
                data.Add(new_student);
            }
        }

        public static void DisplayData(List<Student> input)
        {
            foreach (Student i in input)
            {
                Console.WriteLine($"ФИО: {i.fio}");

                foreach (Subject m in i.marks)
                {
                    Console.WriteLine(m);
                }
                Console.WriteLine($"Ср. балл: {i.Average()}");
                Console.WriteLine();
            }
            
        }

        public static void DisplayAvrg45(List<Student> input)
        {
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i].Average() > 4.5)
                {
                    Console.WriteLine(input[i].fio);
                }
            }
        }
    }
}
