using System;

using Payroll.Payroll;

namespace Payroll
{
    /// <summary>
    /// Program.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Entry point.
        /// </summary>
        /// <param name="args">Arguments.</param>
        static void Main(string[] args)
        {
            RunIncomeTax();
        }

        /// <summary>
        /// Runs income tax.
        /// </summary>
        static void RunIncomeTax()
        {
            Console.WriteLine(Environment.NewLine + Constants.OutputLine1);
            Console.WriteLine(string.Format("           {0} {1}", Constants.AppName, Constants.AppVersion));
            Console.WriteLine(Environment.NewLine + Constants.OutputLine1 + Environment.NewLine);

            Employee emp = new Employee();
            emp.Name = GetEmployeeName();
            emp.Salary = GetEmployeeSalary();

            Payslip payslip = new Payslip();
            payslip.Employee = emp;

            Console.WriteLine(Environment.NewLine + Constants.OutputLine1);
            Console.WriteLine(string.Format("Monthly Payslip for {0}", payslip.Employee.Name));
            Console.WriteLine(Constants.OutputLine1);
            Console.WriteLine("Gross Monthly Income: " + payslip.GrossMonthlyIncome.ToString(Constants.CurrencyFormat1));
            Console.WriteLine("Monthly Income Tax: " + payslip.MonthlyIncomeTax.ToString(Constants.CurrencyFormat1));
            Console.WriteLine("Net Monthly Income: " + payslip.NetMonthlyIncome.ToString(Constants.CurrencyFormat1));
            Console.WriteLine(Constants.OutputLine1);

            Console.WriteLine(Environment.NewLine + "Press any key to continue...");
            Console.ReadLine();
        }

        /// <summary>
        /// Gets employee name.
        /// </summary>
        /// <returns>Employee name.</returns>
        static string GetEmployeeName()
        {
            string name = null;
            while (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Enter employee name:");
                name = Console.ReadLine().Trim();
            }
            return name;
        }

        /// <summary>
        /// Gets employee salary.
        /// </summary>
        /// <returns>Employee salary</returns>
        static decimal GetEmployeeSalary()
        {
            string salaryText = null;
            decimal salary = -1m;
            while (salary <= decimal.Zero)
            {
                Console.WriteLine("Enter employee salary $:");
                salaryText = Console.ReadLine().Trim().Replace("$", null);
                decimal.TryParse(salaryText, out salary);
            }
            return salary;
        }
    }
}