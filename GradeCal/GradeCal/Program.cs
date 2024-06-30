using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeCal
{
	internal class Program
	{
		static void Main(string[] args)
		{
			{
				Console.Write("Enter a numerical grade (0-100): ");
				int grade = int.Parse(Console.ReadLine());

				if (grade >= 90)
				{
					Console.WriteLine("Letter grade: A");
				}
				else if (grade >= 80)
				{
					Console.WriteLine("Letter grade: B");
				}
				else if (grade >= 70)
				{
					Console.WriteLine("Letter grade: C");
				}
				else if (grade >= 60)
				{
					Console.WriteLine("Letter grade: D");
				}
				else
				{
					Console.WriteLine("Letter grade: F");
				}
			}
		}
	}
}
