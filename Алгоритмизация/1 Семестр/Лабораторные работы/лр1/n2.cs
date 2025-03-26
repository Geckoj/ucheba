// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        var a = Convert.ToInt32(Console.ReadLine());
        var b = Convert.ToInt32(Console.ReadLine());
        int min = (a + b - Math.Abs(a - b))/2;
        int max = ((a + b - Math.Abs(a - b))/2) + Math.Abs(a - b);
        Console.WriteLine($"min: {min}, max: {max}");
        
    }
}