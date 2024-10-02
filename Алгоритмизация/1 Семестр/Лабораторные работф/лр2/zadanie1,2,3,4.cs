using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine()); 
        int c = Convert.ToInt32(Console.ReadLine()); 
        int maxs = 0;
        int mem = 0;
        int chet = 1;
        int max1 = 0;
        int max2 = 0;
        int pyat = 0;

        chet = isEven(a, b, c, chet);
        maxs = localMax(a, b, c, maxs);
       
        max1 = Math.Max(a, Math.Max(b, c));
        max2 = (a+b+c) - max1 - Math.Min(a, Math.Min(b, c));
        
        pyat = numFive(a, pyat);
        pyat = numFive(b, pyat);
        pyat = numFive(c, pyat);
        
        
        while (n > 3)
        {
            n--;
            a=b;
            b=c;
            c = Convert.ToInt32(Console.ReadLine());
            
            pyat = numFive(c, pyat);
            
            maxs = localMax(a, b, c, maxs);
            
            chet = isEven(a, b, c, chet);
            if (c >= max1)
            {
                max2 = max1;
                max1 = c;
            }
            else if (c >= max2)
            {
                max2 = c;
            }
        }
        Console.WriteLine($"локальный максимум (кол-во) {maxs}");
        Console.WriteLine($"второй максимум {max2}");
        Console.WriteLine($"количество элементов оканчивающихся на 5 {pyat}");
        Console.WriteLine($"все ли нечетные {chet} (0 - нет, 1 - да)");
        
        }
    static int isEven(int a, int b, int c, int chet)
    {
        chet = chet;
        if ((a % 2 == 0) || (b % 2 == 0) || (c % 2 == 0))
        {
            chet *= 0;
        }
        return chet;
    }
    
    static int localMax(int a, int b, int c, int maxs)
    {
        maxs = maxs;
        if ((b>a)&&(b>c))
        {
            maxs++;
        }
        return maxs;
    }
    
    static int numFive(int a, int pyat)
    {
        pyat = pyat;
        
        if ((a%10==5) || (a%10== -5))
        {
            pyat++;
        }
        
        return pyat;
    }

    }
