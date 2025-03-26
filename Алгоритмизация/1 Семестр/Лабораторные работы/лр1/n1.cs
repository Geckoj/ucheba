using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        var a = Convert.ToInt32(Console.ReadLine());
        var b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"do perestanovki: a = {a}, b = {b}");

        a = a + b;
        b = a - b;
        a = a - b;

        Console.WriteLine($"posle perestanovki: a = {a}, b = {b}");

    }
}
