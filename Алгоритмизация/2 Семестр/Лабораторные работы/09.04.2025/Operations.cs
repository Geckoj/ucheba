using System.Numerics;
class Program
{
    public class Schet<T> where T: INumber<T>
    {
        public T a { get; set; }
        public T b { get; set; }
        public Schet(T a, T b)
        {
            this.a = a;
            this.b = b;
        }

        public T Plus()
        {
            return a + b;
        }
        public T Sub()
        {
            return a - b;
        }
        public T Mult()
        {
            return a * b;
        }
        public T Div()
        {
            try
            {
                return a / b;
            }
            catch (Exception e)
            {
                Console.WriteLine("Деление на ноль");
                return b / a;
            }
        }
    }
    public static void Main()
    {
        Schet<double> test = new Schet<double>(15, 4.5);
        Console.WriteLine(test.Plus());
        Console.WriteLine(test.Sub());
        Console.WriteLine(test.Mult());
        Console.WriteLine(test.Div());
        Schet<int> test_1 = new Schet<int>(15, 0);
        Console.WriteLine(test_1.Plus());
        Console.WriteLine(test_1.Sub());
        Console.WriteLine(test_1.Mult());
        Console.WriteLine(test_1.Div());
    }
}
