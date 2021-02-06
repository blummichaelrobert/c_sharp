using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using CSharp.Data;
using CSharp.Extensions;
using CSharp.OCP;

namespace CSharp
{
	public class Program
	{
    public delegate void Print(int value);
		static void Main(string[] args)
		{
			ProjectData projectData = new ProjectData();
			Stopwatch arrayStopWatch = new Stopwatch();
			Stopwatch mapStopWatch = new Stopwatch();

			string[] numbers = projectData.getRandomStringifiedNumberArray();

			Dictionary<int, string> numberMap = projectData.getNumberMap();

			string[] stringArray = projectData.getNumberArray();

			Console.WriteLine("Starting methods");
			
			arrayStopWatch.Start();
			for (var i = 0; i < numbers.Length; i++)
			{
				for (var y = 0; y < stringArray.Length; y++)
				{
					if (stringArray[y] == numbers[i]) 
					{
						Console.WriteLine("string array found: {0}, {1} ", stringArray[y], i);
						break;
					}
				}
				
			}
			arrayStopWatch.Stop();
			TimeSpan ts = arrayStopWatch.Elapsed;
			string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
			

			mapStopWatch.Start();
			for (var i = 0; i < numbers.Length; i++)
			{
				
				var found = numberMap.FirstOrDefault(number => number.Value == numbers[i]);
				Console.WriteLine("map found: {0}, {1}", found, i);
			}
			mapStopWatch.Stop();
			TimeSpan ts2 = mapStopWatch.Elapsed;
			string elapsedTime2 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts2.Hours, ts2.Minutes, ts2.Seconds, ts2.Milliseconds / 10);
			
			
			Console.WriteLine("RunTime array " + elapsedTime);
			Console.WriteLine("RunTime map " + elapsedTime2);

			#region Extensions

			//IBaseClass bc = new BaseClass();
			//// bc.DoWorkToInt(5);
			//bc.ExtensionWork(5);

			//IBaseClass ic = new InheritingClass();
			//ic.DoWorkToString("EXAMPLE STRING");

			#endregion

			#region Inheritance

			//Cat cat = new Cat("Mr. Cat");
			//cat.Feed();
			//cat.Play();

			#endregion

			#region James Ngo

			//JamesCat myCat = new JamesCat();

			//myCat.feed();
			//Console.ReadLine();

			#endregion James Ngo

			#region OCP

			//var devReports = new List<DeveloperReport>
			//{
			//	new DeveloperReport {Id = 1, Name = "Dev1", Level = "Senior developer", HourlyRate  = 30.5, WorkingHours = 160 },
			//	new DeveloperReport {Id = 2, Name = "Dev2", Level = "Junior developer", HourlyRate  = 20, WorkingHours = 150 },
			//	new DeveloperReport {Id = 3, Name = "Dev3", Level = "Senior developer", HourlyRate  = 30.5, WorkingHours = 180 }
			//};

			//var calculator = new SalaryCalculator(devReports);
			//Console.WriteLine($"Sum of all the developer salaries is {calculator.CalculateTotalSalaries()} dollars");

			//var devCalculations = new List<BaseSalaryCalculator>
			//{
			//new SeniorDevSalaryCalculator(new DeveloperReport {Id = 1, Name = "Dev1", Level = "Senior developer", HourlyRate = 30.5, WorkingHours = 160 }),
			//new JuniorDevSalaryCalculator(new DeveloperReport {Id = 2, Name = "Dev2", Level = "Junior developer", HourlyRate = 20, WorkingHours = 150 }),
			//new SeniorDevSalaryCalculator(new DeveloperReport {Id = 3, Name = "Dev3", Level = "Senior developer", HourlyRate = 30.5, WorkingHours = 180 })
			//};

			//var ocp_calculator = new SalaryCalculator(devCalculations);
			//Console.WriteLine($"Sum of all the developer salaries is {ocp_calculator.CalculateTotalSalaries_OCP_OPTIMIZED()} dollars");

			#endregion OCP

			Console.ReadLine();
		}

	}
}
