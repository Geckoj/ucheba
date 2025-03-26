//Гонка
namespace Program
{
    public class Program
    {
        public static int start = 0;
        public static int finish = 200;
        public static bool end_of_race = false;
        public static int time = 5;

        public delegate void Race(string name);
        public static event Race OnMove;
        public class Part()
        {
            public string name { get; set; }
            public int velocity = 2;
            public int travel = 0;

            public void Move()
            {
                Random random = new Random();
                travel += velocity * time;
                velocity += random.Next(0, 2);
                
                if (travel >= finish)
                {
                    OnMove(name);
                }
                else
                {
                    Console.WriteLine($"Участник {name} прошёл расстояние {travel} метров" +
                        $". Текущая скорость {velocity} м/с");
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
            OnMove += handler.Msg;

            while (!end_of_race)
            {
                Console.Clear();
                part_1.Move();
                part_2.Move();
                part_3.Move();
                Console.ReadKey();
            }
        }
    }
}
