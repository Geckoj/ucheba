using System;

public class Test
{
    public int FieldOne { get; set; }
    public int FieldTwo { get; set; }

    public Test()
    {
        FieldOne = 0;
        FieldTwo = 0;
    }

    public Test(int fieldone)
    {
        FieldOne = fieldone;
        FieldTwo = 0;
    }   

    public Test(int fieldone, int fieldtwo)
    {
        FieldOne = fieldone;
        FieldTwo = fieldtwo;
    }

    public int Plus()
    {
        return FieldOne + FieldTwo;
    }

    public int Minus()
    {
        return FieldOne - FieldTwo;
    }

    public int Mult()
    {
        return FieldOne * FieldTwo;
    }

    public string Division()
    {
        if (FieldTwo != 0)
        {
            return $"{(float)FieldOne / FieldTwo}";
        }
        else
        {
            return "деление на ноль невозможно";
        }
    }

    // public override string ToString()
    // {
    //     return $"{FieldOne}\t{FieldTwo}";
    // }
}


internal class Program
{
    static void Main()
    {
        Test test1 = new Test();
        Test test2 = new Test(120);
        Test test3 = new Test(32, 37);
        //Console.WriteLine($"{test1}\t{test2}\t{test3}");

        Console.WriteLine($"test1\ttest2\ttest3");
        Console.WriteLine($"+ {test1.Plus()}\t{test2.Plus()}\t{test3.Plus()}");
        Console.WriteLine($"- {test1.Minus()}\t{test2.Minus()}\t{test3.Minus()}");
        Console.WriteLine($"* {test1.Mult()}\t{test2.Mult()}\t{test3.Mult()}");
        Console.WriteLine($"/ {test1.Division()}\t{test2.Division()}\t{test3.Division()}");

        Console.ReadKey();
    }
}
