namespace CSharp.OCP
{
	// As a continuation, we are going to create two classes which will inherit from the BaseSalaryCalculator class.
	// Because it is obvious that our calculation depends on the developer’s level, we are going to create our new classes in that manner:

	public abstract class BaseSalaryCalculator
	{
		protected DeveloperReport DeveloperReport { get; private set; }

		public BaseSalaryCalculator(DeveloperReport devReport)
		{
			DeveloperReport = devReport;
		}

		public abstract double CalculateSalary();
	}
}
