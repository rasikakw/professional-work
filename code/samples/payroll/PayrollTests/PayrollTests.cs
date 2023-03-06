using Microsoft.VisualStudio.TestTools.UnitTesting;

using Payroll.Payroll;

namespace PayrollTests
{
    /// <summary>
    /// Payroll tests.
    /// </summary>
    [TestClass]
    public class PayrollTests
    {
        /// <summary>
        /// Payslip test 1.
        /// </summary>
        [TestMethod]
        public void Test_Payslip1()
        {
            decimal sal = 40000m;
            Employee emp = new Employee { Name = "Test", Salary = sal };

            decimal incTax = 20000 * 0.10m;

            decimal grossMonthlyInc = sal / Constants.NoOfMonthsInYear;
            decimal monthlyIncTax = incTax / Constants.NoOfMonthsInYear;
            decimal netMonthlyInc = grossMonthlyInc - monthlyIncTax;

            Payslip payslip = new Payslip();
            payslip.Employee = emp;

            Assert.AreEqual(payslip.GrossMonthlyIncome, grossMonthlyInc);
            Assert.AreEqual(payslip.MonthlyIncomeTax, monthlyIncTax);
            Assert.AreEqual(payslip.NetMonthlyIncome, netMonthlyInc);
        }

        /// <summary>
        /// Payslip test 2.
        /// </summary>
        [TestMethod]
        public void Test_Payslip2()
        {
            decimal sal = 90000m;
            Employee emp = new Employee { Name = "Test", Salary = sal };

            decimal incTax = 20000 * 0.10m;
            incTax += 40000 * 0.20m;
            incTax += 10000 * 0.30m;

            decimal grossMonthlyInc = sal / Constants.NoOfMonthsInYear;
            decimal monthlyIncTax = incTax / Constants.NoOfMonthsInYear;
            decimal netMonthlyInc = grossMonthlyInc - monthlyIncTax;

            Payslip payslip = new Payslip();
            payslip.Employee = emp;

            Assert.AreEqual(payslip.GrossMonthlyIncome, grossMonthlyInc);
            Assert.AreEqual(payslip.MonthlyIncomeTax, monthlyIncTax);
            Assert.AreEqual(payslip.NetMonthlyIncome, netMonthlyInc);
        }

        /// <summary>
        /// Payslip test 3.
        /// </summary>
        [TestMethod]
        public void Test_Payslip3()
        {
            decimal sal = 120000m;
            Employee emp = new Employee { Name = "Test", Salary = sal };

            decimal incTax = 20000 * 0.10m;
            incTax += 40000 * 0.20m;
            incTax += 40000 * 0.30m;

            decimal grossMonthlyInc = sal / Constants.NoOfMonthsInYear;
            decimal monthlyIncTax = incTax / Constants.NoOfMonthsInYear;
            decimal netMonthlyInc = grossMonthlyInc - monthlyIncTax;

            Payslip payslip = new Payslip();
            payslip.Employee = emp;

            Assert.AreEqual(payslip.GrossMonthlyIncome, grossMonthlyInc);
            Assert.AreEqual(payslip.MonthlyIncomeTax, monthlyIncTax);
            Assert.AreEqual(payslip.NetMonthlyIncome, netMonthlyInc);
        }

        /// <summary>
        /// Payslip test 4.
        /// </summary>
        [TestMethod]
        public void Test_Payslip4()
        {
            decimal sal = 210000m;
            Employee emp = new Employee { Name = "Test", Salary = sal };

            decimal incTax = 20000 * 0.10m;
            incTax += 40000 * 0.20m;
            incTax += 100000 * 0.30m;
            incTax += 30000 * 0.40m;

            decimal grossMonthlyInc = sal / Constants.NoOfMonthsInYear;
            decimal monthlyIncTax = incTax / Constants.NoOfMonthsInYear;
            decimal netMonthlyInc = grossMonthlyInc - monthlyIncTax;

            Payslip payslip = new Payslip();
            payslip.Employee = emp;

            Assert.AreEqual(payslip.GrossMonthlyIncome, grossMonthlyInc);
            Assert.AreEqual(payslip.MonthlyIncomeTax, monthlyIncTax);
            Assert.AreEqual(payslip.NetMonthlyIncome, netMonthlyInc);
        }
    }
}