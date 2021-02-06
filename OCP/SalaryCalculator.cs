using System.Collections.Generic;

namespace CSharp.OCP
{
	public class SalaryCalculator
	{
		private readonly IEnumerable<DeveloperReport> _developerReports;

		// after optimization:
		private readonly IEnumerable<BaseSalaryCalculator> _developerCalculation;

		public SalaryCalculator(List<DeveloperReport> developerReports)
		{
			_developerReports = developerReports;
		}

		public SalaryCalculator(IEnumerable<BaseSalaryCalculator> developerCalculation)
		{
			_developerCalculation = developerCalculation;
		}

		public double CalculateTotalSalaries()
		{
			double totalSalaries = 0D;

			foreach (var devReport in _developerReports)
			{
				totalSalaries += devReport.HourlyRate * devReport.WorkingHours;
			}

			return totalSalaries;
		}

		// So, all of this is working great, but now our boss comes to our office and says that we need a different calculation for the senior and junior developers.
		// The senior developers should have a bonus of 20% on a salary.

		// Of course, to satisfy this requirement, we are going to modify our CalculateTotalSalaries method like this:

		public double CalculateTotalSalaries_NO_OCP()
		{
			double totalSalaries = 0D;

			foreach (var devReport in _developerReports)
			{
				if (devReport.Level == "Senior developer")
				{
					totalSalaries += devReport.HourlyRate * devReport.WorkingHours * 1.2;
				}
				else
				{
					totalSalaries += devReport.HourlyRate * devReport.WorkingHours;
				}
			}

			return totalSalaries;
		}

		public double CalculateTotalSalaries_OCP_OPTIMIZED()
		{
			double totalSalaries = 0D;

			foreach (var devCalculation in _developerCalculation)
			{
				totalSalaries += devCalculation.CalculateSalary();
			}

			return totalSalaries;
		}
	}
}
