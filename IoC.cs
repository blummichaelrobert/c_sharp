using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
	public class IoC
	{
		public void DoWorkWithString()
		{
			StringObject so = new StringObject();

			var returnedByStringObject = so.GetDescription();

			Console.WriteLine(returnedByStringObject);
		}

		public void DoWorkWithInt()
		{
			IntObject io = new IntObject();

			var returnedByIntObject = io.GetIntInsideClass();

			Console.WriteLine($"The int returned by IntObject was: {returnedByIntObject}");
		}

		public void DoWorkWithStringIoC(StringObject doWorkWithThisObject)
		{
			var returnedByStringObject = doWorkWithThisObject.GetDescription();

			Console.WriteLine(returnedByStringObject);
		}

	}

	public class StringObject
	{
		private string _description;
		public string Description 
		{
			get => _description;
			set => _description = value; 
		}

		public string GetDescription()
		{
			Description = "This is a description of an object";
			return Description;
		}
	}

	public class IntObject
	{
		private int _number;
		public int Number
		{
			get => _number;
			set => _number = value;
		}

		public int GetIntInsideClass()
		{
			Number = 1;
			return Number;
		}
	}
}
