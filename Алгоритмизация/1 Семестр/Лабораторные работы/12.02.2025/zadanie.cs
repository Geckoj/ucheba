namespace Figuri
{
    public class Program
    {
        public class Figura
        {
            public string name { get; set; }
        }

        public interface IFigura
        {
            public double Area();
            public double Perimeter();
        }

        public class Circle: Figura, IFigura
        {
            public double radius;
            
            public double Area()
            {
                return 2 * Math.PI * Math.Pow(radius, 2);
            }
            public double Perimeter()
            {
                return 2 * Math.PI * radius;
            }

            public Circle(string name, double radius)
            {
                this.name = name;
                this.radius = radius;
            }
        }

        public class Square: Figura, IFigura
        {
            public double storona;

            public double Area()
            {
                return Math.Pow(storona, 2);
            }
            public double Perimeter()
            {
                return 4 * storona;
            }

            public Square(string name, double storona)
            {
                this.name = name;
                this.storona = storona;
            }
        }
        public class Triangle: Figura, IFigura
        {
            public double storona;
            
            public double Area()
            {
                return Math.Sqrt(3) / 4 * Math.Pow(storona, 2);
            }
            public double Perimeter()
            {
                return 3 * storona;
            }

            public Triangle(string name, double storona)
            {
                this.name = name;
                this.storona = storona;
            }
        }

        public static List<object> Figures = new List<object>();

        public static void Main()
        {
            Circle circle = new Circle("Окружность_1", 12);
            Square square = new Square("Квадрат_1", 21);
            Triangle triangle = new Triangle("Треугольник_1", 39);
            Console.WriteLine($"Фигура\t{circle.name}\t{square.name}\t{triangle.name}");
            Console.WriteLine($"Площадь\t{circle.Area()}\t{square.Area()}\t{triangle.Area()}");
            Console.WriteLine($"Периметр\t{circle.Perimeter()}\t{square.Perimeter()}\t{triangle.Perimeter()}");
            
        }
    }
}
