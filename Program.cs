using System;

using CSharp.Extensions;

namespace CSharp
{
	class Program
	{
		static void Main(string[] args)
		{
			IBaseClass bc = new BaseClass();
			// bc.DoWorkToInt(5);
			bc.ExtensionWork(5);

			IBaseClass ic = new InheritingClass();
			ic.DoWorkToString("EXAMPLE STRING");

			Console.ReadLine();
		}
	}
}
