using System;
using System.Linq;

public class HelloWorld
{   
    public static void Main(string[] args)
    {
        // генерация последовательности
        var n = 3;
        int[] array1 = new int[n];
        Random rnd = new Random();

        for (int i = 0; i < n; i++)
        {
            array1[i] = rnd.Next(-256, 256);
        }
        
        Console.WriteLine("Последовательность: " + string.Join(", ", array1));
        int localMins = LocalMin(array1);
        bool isEven = EvenArray(array1);
        var maximums2 = Maximums(array1);
        Console.WriteLine($"Локальные минимумы: {localMins}, Чётность последовательности {isEven}, максимумы: {("" + string.Join(", ", maximums2))}");
    }

    //метод для нахождения локальных минимумов

    static int LocalMin(int[] array)
    {
        int count = 0;

        for (int i = 1; i < array.Length - 1; i++)
        {
            if (array[i] < array[i-1] && array[i] < array[i+1])
            {
                count++;
            }
        }
        return count;
    }
    
    //метод для определения, все ли элементы последовательности чётны (да/нет)
    static bool EvenArray(int[] array)
    {
        bool isEven = true;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 != 0)
            {
                isEven = false;
                break;
            }
        }

        return isEven;
    }

    //метод для определения двух максимумов последовательности
    static int[] Maximums(int[] array)
    {
        int[] maximumVals = new int[2];

        maximumVals[0] = array.Max();
        array = array.Except(new int[] {maximumVals[0]}).ToArray();
        maximumVals[1] = array.Max();


        return maximumVals;
    }
}
