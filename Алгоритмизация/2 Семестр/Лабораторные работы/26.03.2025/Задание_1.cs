//Точка
namespace Program
{
    class Program
    {
        public static int rect_x1 = -5;
        public static int rect_y1 = -5;
        public static int rect_x2 = 30;
        public static int rect_y2 = 30;

        public delegate void Rect(int x, int y);
        public static event Rect OnMove;

        class Point
        {
            public int x { get; set; }
            public int y { get; set; }
            public void Move()
            {
                Random random = new Random();
                int movement_x = random.Next(-5, 5);
                int movement_y = random.Next(-5, 5);

                x += movement_x;
                y += movement_y;

                if (!(x >= rect_x1 && x <= rect_x2 && y >= rect_y1 && y <= rect_y2))
                {
                    OnMove(x, y);
                }
                else
                {
                    Console.WriteLine($"Координаты:\t{x}\t{y};");
                }
            }
        }

        public class Handler_1
        {
            public void Msg(int x, int y)
            {
                Console.WriteLine($"Координаты:\t{x}\t{y}; Точка вышла за пределы прямоугольника.");
            }
        }
        static void Main()
        { 
            Point point = new Point 
            { 
                x = 15, 
                y = 15
            };

            Handler_1 handler_1 = new Handler_1();

            OnMove += handler_1.Msg;

            for (int i = 0; i < 30; i++)
            {
                point.Move();    
            }
        }
    }
}
