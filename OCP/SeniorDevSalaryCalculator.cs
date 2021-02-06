using System;

namespace CSharp.OCP
{
	public class SeniorDevSalaryCalculator : BaseSalaryCalculator
	{
		public SeniorDevSalaryCalculator(DeveloperReport devReport): base(devReport)
		{
						
		}

		public override double CalculateSalary()
		{
			return DeveloperReport.HourlyRate * DeveloperReport.WorkingHours * 1.2;
		}
	}
}
