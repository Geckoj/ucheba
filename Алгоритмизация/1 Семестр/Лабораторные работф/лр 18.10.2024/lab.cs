using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
	public class Program
	{
		public static void Main(string[] args)
		{
			int current, result;
		  int r;
			
			current = Convert.ToInt32(Console.ReadLine());
			result = flip(current);
			if (result > -1)
      {
			    Console.WriteLine($"вход {current}   выход {result}");
      }
      else
      {
        Console.WriteLine($"нет четных цифр");
      }
			
			while (current >= 0) 
			{
			  current = Convert.ToInt32(Console.ReadLine());

        result = flip(current);
        if (result > -1)
        {
			    Console.WriteLine($"вход {current}   выход {result}");
        }
        else
        {
          Console.WriteLine($"вход {current}   выход   нет четных цифр");
        }
			  
			}
		}
		
		static int flip(int conv)
{
    if (conv == 0) return 0;

    int rev = 0;
    int haveZero = 0;

    while (conv > 0)
    {
        int digit = conv % 10;

        if (digit == 0)
        {
            haveZero++;
            rev = rev * 10 + digit;
        }
        else if (digit % 2 == 0)
        {
            rev = rev * 10 + digit;
        }

        conv /= 10;
    }

    if (rev == 0)
    {
        if (haveZero > 0)
        {
            return 0;
        }
        else
        {
            return -1;
        }
    }
    else
    {
        return rev;
    }
}
		
	}
}
