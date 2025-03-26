public class Program
{

    public delegate float Deg1(int a, int b);
    public delegate float Deg2(int a, int b);
    public class Opers
    {
        public static int a { get; set; }
        public static int b { get; set; }

        public static int Plus(int a, int b)
        {
            return a + b;
        }

        public static int Minus(int a, int b)
        {
            return a - b;
        }

        public static int Mult(int a, int b)
        {
            return a * b;
        }

        public static float Div(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch
            {
                return b / a;
            }
        }
    }
    static void Main()
    {
        Deg1 operation_1 = (a, b) =>
        {
            int s1 = Opers.Plus(a, b);
            int s2 = Opers.Minus(s1, b);
            int s3 = Opers.Mult(s2, b);
            return s3;
        };

        Deg2 operation_2 = (a, b) =>
        {
            int s1 = Opers.Mult(a, b);
            int s2 = Opers.Minus(s1, a);
            float s3 = Opers.Div(s2, a);
            return s3;
        };

        Console.WriteLine(operation_1(10, 5));
        Console.WriteLine(operation_2(10, 5));
    }
}
