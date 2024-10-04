using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine()); 
        int mem1 = 0;
        int mem2 = 0;
        int mem3 = 0;
        int chet = 1;
        int prev= 0;
        int counter1 = 0;
        int min1 = 1000000;
        int counter2 = 0;
        int counter3 = 0;
        int max2 = 0;
        int max3 = 0;

        counter1 = isOne(a, counter1);
        counter2 = isEvenAndEqual(a, b, prev, counter2);
        counter3 = isEvenSum(a, counter3);
 
        while (n >= 1)
        {
            n--;
            
            prev = a;
            a=b;
            b = Convert.ToInt32(Console.ReadLine());
            
            mem1 = counter1;
            counter1 = isOne(a, counter1);
            
            if (counter1 == 0 && mem1!= 0)
            {
              min1 = Math.Min(min1, mem1);
            }
            
            
            mem2 = counter2;
            counter2 = isEvenAndEqual(a, b, prev, counter2);
            
            if ((counter2 == 0 && mem2!= 0) || (n == 0))
            {
              max2 = Math.Max(max2, mem2);
            }
            
            mem3 = counter3;
            counter3 = isEvenSum(a, counter3);
            
            if ((counter3 == 0 && mem3!= 0) || (n == 0))
            {
              max3 = Math.Max(max3, mem3);
            }
            
            // Console.WriteLine($"{n} {a} {b}     {counter3}, {mem3}, {max3}");
            
            
        }

        Console.WriteLine($"минимальный размер подпоследовательности единиц {min1}");
        Console.WriteLine($"максимальный размер подпоследовательности четных одинаковых элементов {max2}");
        Console.WriteLine($"максимальная сумма подпоследовательности из четных элементов {max3}");
        
        }
    static int isEvenAndEqual(int a, int b, int prev, int chet)
    {
        chet = chet;
        if (((a % 2 == 0) && (b % 2 == 0) && (a == b)) || ((a % 2 == 0) && (prev % 2 == 0) && (a == prev)))
        {
          chet += 1;
        }
        else
        {
          chet = 0;
        }
        
        return chet;
    }
    
    static int isEvenSum(int a, int chet)
    {
      chet = chet;
      
      if (a % 2 == 0)
      {
        chet += a;
      }
      else
      {
        chet = 0;
      }
      
      return chet;
    }
    
    static int isOne(int a, int counter)
    {
      counter = counter;
      
      if (a == 1)
      {
        counter += 1;
      }
      else
      {
        counter = 0;
      }
      
      return counter;
    }

    }
