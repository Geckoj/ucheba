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
			int m = Convert.ToInt32(Console.ReadLine());
			int n = Convert.ToInt32(Console.ReadLine());

			int zeros = 0;
			
			
			int[,] mas = new int[m, n];
			int[] masst2;
			int[] masst3;

			for (int i = 0; i < m; i++)
			{
				for (int j = 0; j < n; j++)
				{
					mas[i, j] = Convert.ToInt32(Console.ReadLine());
				}
			}


			for (int i = 0; i < n-1; i++)
			{
				for (int j = 0; j < m; j++)
				{
					masst2[i] = mas[j, i];
					masst3[i] = mas[j, i+1];
				}
			}

			foreach (var item in masst2)  
            {  
                Console.WriteLine(item);  
            }  


	



			static int[] ArraySort(int[] a)
			{
				// int[] intArray = new int[] {2,9,4,3,5,1,7 }; a  
				int temp = 0;  
	
				for (int i = 0; i <= a.Length-1; i++)  
				{  
					for (int j = i+1; j < a.Length; j++)  
					{  
						if (a[i] > a[j])  
						{  
							temp = a[i];  
							a[i] = a[j];  
							a[j] = temp;  
						}  
					}  
				}
				return a;
			}

			static int CountZeros(int[] a)
			{
				int zeros = 0;
				for (int i = 0; i < a.Length; i++)
				{
					if (a[i] == 0)
					{
						zeros+=1;
					}
				}
				return zeros;
			}

			static int SumOfArray(int[] a)
			{
				int summ = 0;
				for (int i = 0; i < a.Length; i++)
				{
					summ += Math.Abs(a[i]);
				}
				return summ;
			}

			static bool HasNegative(int[] a)
			{
				int neg = 0;
				for (int i = 0; i < a.Length; i++)
				{
					neg += 1;
				}
				if (neg > 0)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
		
		
	}
}
}
