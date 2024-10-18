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
			result = flip(current, 0, 0);
			Console.WriteLine($"вход {current}   выход {result}");
			
			while (current >= 0) 
			{
			  current = Convert.ToInt32(Console.ReadLine());

        result = flip(current, 0, 0);
			  Console.WriteLine($"вход {current}   выход {result}");
			  
			}
		}
		
		static int flip(int conv, int rev, int r)
		{
        conv = conv;
        rev = 0;
        
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
          else
          {
            rev = rev;
          }
          conv = conv / 10;
        }
        return rev;
		}
		
	}
}
