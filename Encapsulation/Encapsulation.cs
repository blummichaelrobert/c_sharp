
using System;

public class Cat
{
	public string Name { get; set; }
	private int Mood { get; set; }
	private int Hungry { get; set; }
	private int Energy { get; set; }

	public Cat(string name)
	{
		Name = name;
		HungryMeow();
	}

	public void Feed()
	{
		Hungry--;
		Mood++;
	}

	public void Play()
	{
		Mood++;
		Energy--;
		HappyMeow();
	}

	public void Sleep()
	{
		Energy++;
		Hungry++;
	}

	private void HappyMeow()
	{
		if (string.IsNullOrWhiteSpace(Name))
		{
			Console.WriteLine("The cat meowed happily");
		}
		Console.WriteLine($"{Name} meowed happily");
	}
	private void HungryMeow()
	{
		if (string.IsNullOrWhiteSpace(Name))
		{
			Console.WriteLine("The cat meowed because it's hungry");
		}
		Console.WriteLine($"{Name} meowed because it's hungry");
	}
}