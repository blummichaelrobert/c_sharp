using System;

namespace CSharp.Extensions
{
	public interface IBaseClass
	{
		int intPropBase { get; set; }

		string stringPropBase { get; set; }

		void DoWorkToInt(int obj);

		void DoWorkToString(string str);
	}

	public class BaseClass : IBaseClass
	{
		public int intPropBase { get; set; }
		public string stringPropBase { get; set; }

		public void DoWorkToInt(int obj)
		{
			Console.WriteLine($"\nobj equals: {obj}...");
			obj++;
			intPropBase = obj;
			Console.WriteLine($"The value of obj is: {obj}");
		}

		public void DoWorkToString(string str)
		{
			stringPropBase = str;
			stringPropBase.ToUpper();
			Console.WriteLine($"The uppercase value of str is {stringPropBase}");
		}
	}

	public class InheritingClass : IBaseClass
	{
		public int intPropBase { get; set; }
		public string stringPropBase { get; set; }

		public void DoWorkToInt(int obj)
		{
			obj--;
			intPropBase = obj;
			Console.WriteLine($"The value of obj is: {obj}");
		}

		public void DoWorkToString(string str)
		{
			stringPropBase = str;
			Console.WriteLine($"The value of str is {stringPropBase}");
			stringPropBase = stringPropBase.ToLower();
			Console.WriteLine($"The lowercase value of str is {stringPropBase}");
		}
	}

	internal static class BaseClassExtensions
	{
		public static void ExtensionWork(this IBaseClass bc, int extension_param)
		{
			Console.WriteLine($"\nExtension param equals: {extension_param}... doing work ...");
			extension_param++;
			bc.DoWorkToInt(extension_param);
		}
	}
}
