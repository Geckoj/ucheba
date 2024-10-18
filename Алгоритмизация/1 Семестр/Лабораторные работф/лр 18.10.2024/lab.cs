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
			result = flip(current, 0, 0, 0);
			if (result > -1)
      {
			    Console.WriteLine($"вход {current}   выход {result}");
      }
      else
      {
        Console.WriteLine($"нет четных цифр");
      }
			
			while (current >= -1) 
			{
			  current = Convert.ToInt32(Console.ReadLine());

        result = flip(current, 0, 0, 0);
        if (result >= 0)
        {
			    Console.WriteLine($"вход {current}   выход {result}");
        }
        else
        {
          Console.WriteLine($"нет четных цифр");
        }
			  
			}
		}
		
		static int flip(int conv, int rev, int r, int have_zero)
		{
        conv = conv;
        rev = 0;
        have_zero = 0;
        
        while(conv > 0)
        {
          if ((conv % 10) % 2 == 0)
          {
            r = conv % 10;
          }
          else
          {
            r = 0;
          }
          if (r != 0)
          {
            rev = rev * 10 + r;
          }
          else if ((conv % 10) == 0)
          {
            rev = rev * 10;
            have_zero = 1;
          }
          else
          {
            rev = rev;
            if (have_zero > 0)
            {
              rev = 0;
            }
          }
          conv = conv / 10;
        }
        
        return rev;
        
		}
		
	}
}
