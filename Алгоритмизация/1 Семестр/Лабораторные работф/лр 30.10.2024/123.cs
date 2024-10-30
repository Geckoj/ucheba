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
		  int n = Convert.ToInt32(Console.ReadLine());
			int[] arr= new int[n];
			
			for (int i = 0; i < n; i++)
			{
			  arr[i] = Convert.ToInt32(Console.ReadLine());
			}
		// 	for (int j = 0; j < n; j++)
		// 	{
		// 	  Console.WriteLine(arr[j]);
		// 	}
		  Console.WriteLine($"1. кол-во элементов массива, оканчивающихся на 3: {end3(arr, n)}");
		  Console.WriteLine($"2. равномерная возрастающая последовательность (да/нет): {progression(arr, n)}");
		  Console.WriteLine($"3. массив:");
		  
		  // int[] arr1 = new int[n];
		      
		  // arr1 = swap_minmax(arr, n);
		  
		  foreach(var item in swap_minmax(arr, n))
        {
          Console.WriteLine(item.ToString());
        }
		  
		
		
		}
	 
	 static int end3(int[] arr, int n)
	 {
	   int count = 0; 
	   for (int i = 0; i < n; i++)
	   {
	     if (arr[i] % 10 == 3)
	     {
	       count++;
	     }
	   }
	   return count;
	 }
	 
	 static string progression(int[] arr, int n)
	 {
	   int prog = 1;
	   int dif = 0;
	   int incr = 1;
	   for (int i = 1; i < n-1; i++)
	   {
	     dif = arr[i] - arr[i-1];
	     if ((arr[i] > arr[i+1]) || (dif != (arr[i+1] - arr[i])) || (dif == 0))
	     {
	       incr *= 0;
	     }
	   }
	   if (incr == 0)
	   {
	     return "нет";
	   }
	   else
	   {
	     return "да";
	   }
	 }
	
	static int[] swap_minmax(int[] arr, int n)
	{
	  int prev_max;
	  int prev_min;
	  int max = Int32.MinValue;
	  int min = Int32.MaxValue;
	  int maxi = 0;
	  int mini = 0;
	  
	  for (int i = 0; i < n; i++)
	  {
	    prev_max = max;
	    prev_min = min;
	    max = Math.Max(max, arr[i]);
	    min = Math.Min(min, arr[i]);
	    if (max > prev_max)
	    {
	      maxi = i;
	    }
	    if (min < prev_min)
	    {
	      mini = i;
	    }
	  }
    
    arr[maxi] = min;
    arr[mini] = max;
	  
	  return arr;
	}
	}
}
