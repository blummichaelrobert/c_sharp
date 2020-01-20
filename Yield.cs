using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
	// kenneth-truyers.net/2016/05/12/yield-return-in-c/
		// when debugging execution jumps between the caller and the yield return statements.
		// each iteration of the caller calls the iterator method until it reaches the yield return statement.

	// Yield = state machine + relay.
	public class Yield
	{
		public IEnumerable<int> GenerateWithYield()
		{
			var i = 0;
			while (i < 5)
			{
				yield return ++i;
			}
		}
		public void GenerateWithYieldShowList()
		{
			foreach (var number in GenerateWithYield())
			{
				Console.WriteLine($"GenerateWithYield yields: {number}");
			}
		}

		public IEnumerable<int> GenerateWithYieldInfiniteLoopSafe()
		{
			var i = 0;
			while (true) { yield return i++;  }
		}
		public void GenerateWithYieldinfiniteLoopSafeShowList()
		{
			// Because the take method is actually implemented with a yield return operator as well, this will succeed.
			// The method only gets called until the Take method is satisfied.
			foreach (var number in GenerateWithYieldInfiniteLoopSafe().Take(5))
			{
				Console.WriteLine($"GenerateWithYieldInfiniteLoopSafe yields: {number}");
			}
		}


		public void TakeExample()
		{
			// Take example:
			int[] grades = { 59, 82, 70, 56, 92, 98, 85 };

			// To order a sequence by the values of the elements themselves, specify the identity function (x => x)
			IEnumerable<int> topThreeGrades = grades.OrderByDescending(x => x).Take(3);

			Console.WriteLine("Top three grades are:");
			foreach (var grade in topThreeGrades)
			{
				Console.WriteLine(grade);
			}
		}
		
	}
}
