//Гонка
namespace Program
{
    public class Program
    {
        public static int start = 0;
        public static int finish = 20;
        public static bool end_of_race = false;
        public class Part()
        {
            public delegate void Race(string name);
            public event Race OnMove; 
            
            public string name { get; set; }
            public int x = start;

            public void Move()
            {
                Random random = new Random();
                x += random.Next(0, 2);
                if (x >= finish)
                {
                    OnMove(name);
                }
                else
                {
                    Console.WriteLine($"Участник {name} прошёл расстояние {x}");
                }
            }
        }
        public class Handler
        {
            public void Msg(string name)
            {
                Console.WriteLine($"Участник {name} прибыл к финишу");
                end_of_race = true;
            }
        }

        public static void Main()
        {
            Part part_1 = new Part
            {
                name = "Номер_1",
            };
            Part part_2 = new Part
            {
                name = "Номер_2",

            };
            Part part_3 = new Part
            {
                name = "Номер_3",
            };

            Handler handler = new Handler();
            part_1.OnMove += handler.Msg;
            part_2.OnMove += handler.Msg;
            part_3.OnMove += handler.Msg;

            while (!end_of_race)
            {
                Console.Clear();
                part_1.Move();
                part_2.Move();
                part_3.Move();
                Thread.Sleep(250);
                //Console.ReadKey();
            }
        }
    }
}
