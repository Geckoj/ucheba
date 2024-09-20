// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        var a = Convert.ToInt32(Console.ReadLine());
        var b = Convert.ToInt32(Console.ReadLine());
        (a, b) = (b, a);
        Console.WriteLine($"a = {a}, b = {b}");
    }
}