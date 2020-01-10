using System;

using CSharp.Extensions;

namespace CSharp
{
	public class Program
	{
    public delegate void Print(int value);
		static void Main(string[] args)
		{
			#region Extensions
			//IBaseClass bc = new BaseClass();
			//// bc.DoWorkToInt(5);
			//bc.ExtensionWork(5);

			//IBaseClass ic = new InheritingClass();
			//ic.DoWorkToString("EXAMPLE STRING");
			#endregion

			#region Inheritance
			// Cat cat = new Cat("Mr. Cat");
			// cat.Feed();
			// cat.Play();
			#endregion

			#region Delegates
			Delegates delegates = new Delegates();
			delegates.CallDelegate();
			#endregion

			Console.ReadLine();

		}

	}
}
