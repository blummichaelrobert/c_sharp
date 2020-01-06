using System;

using CSharp.Extensions;

namespace CSharp
{
	public class Program
	{
		static void Main(string[] args)
		{
			#region Extensions
			//IBaseClass bc = new BaseClass();
			//// bc.DoWorkToInt(5);
			//bc.ExtensionWork(5);

			//IBaseClass ic = new InheritingClass();
			//ic.DoWorkToString("EXAMPLE STRING");
			#endregion

			Cat cat = new Cat("Mr. Cat");
			cat.Feed();
			cat.Play();

			Console.ReadLine();

		}
	}
}
