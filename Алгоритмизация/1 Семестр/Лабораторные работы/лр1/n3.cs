// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int p = 5;
        int h = 3;
        int w = 3;
        int N = 1;
        int res;
        res = 2*N*p + (w*(((2+2*(N-1))/2)*(N-1))) + 2*N*(h + w);
        Console.WriteLine(res);
    }
}