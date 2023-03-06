using System;

namespace Payroll.Payroll
{
    /// <summary>
    /// Pay slip.
    /// </summary>
    public class Payslip
    {
        private IncomeTax _tax = new IncomeTax();

        /// <summary>
        /// Employee.
        /// </summary>
        public Employee Employee { get; set; }

        /// <summary>
        /// Gross monthly income of employee.
        /// </summary>
        public decimal GrossMonthlyIncome
        {
            get
            {
                ValidateEmployee();
                return Employee.Salary / Constants.NoOfMonthsInYear;
            }
        }

        /// <summary>
        /// Monthly income tax for employee.
        /// </summary>
        public decimal MonthlyIncomeTax
        {
            get
            {
                return _tax.GetMonthlyIncomeTax(Employee.Salary);
            }
        }

        /// <summary>
        /// Net monthly income of employee.
        /// </summary>
        public decimal NetMonthlyIncome
        {
            get
            {
                return GrossMonthlyIncome - MonthlyIncomeTax;
            }
        }

        /// <summary>
        /// Validates employee.
        /// </summary>
        private void ValidateEmployee()
        {
            if (Employee == null)
                throw new ArgumentException("Unable to locate employee information.");
            if (string.IsNullOrWhiteSpace(Employee.Name))
                throw new ArgumentNullException("Invalid employee name.");
            if (Employee.Salary <= decimal.Zero)
                throw new ArgumentOutOfRangeException(string.Format("Invalid salary {0} for employee {1}.", Employee.Salary.ToString(Constants.CurrencyFormat1), Employee.Name));
        }
    }
}