namespace Payroll.Payroll
{
    /// <summary>
    /// Income tax.
    /// </summary>
    public class IncomeTax
    {
        /// <summary>
        /// Gets monthly income tax for salary.
        /// </summary>
        /// <param name="salary">Salary to use.</param>
        /// <returns>Monthly income tax for salary.</returns>
        public decimal GetMonthlyIncomeTax(decimal salary)
        {
            decimal tax = 0m;
            if (salary <= decimal.Zero)
                return tax;

            if (salary > 180000)
            {
                decimal taxable = salary - 180000;
                tax += taxable * 0.4m;
            }
            if (salary > 80000)
            {
                decimal maxTaxable = 180000 - 80000;
                decimal taxable = salary - 80000;
                if (taxable > maxTaxable)
                    taxable = maxTaxable;
                tax += taxable * 0.3m;
            }
            if (salary > 40000)
            {
                decimal maxTaxable = 80000 - 40000;
                decimal taxable = salary - 40000;
                if (taxable > maxTaxable)
                    taxable = maxTaxable;
                tax += taxable * 0.2m;
            }
            if (salary > 20000)
            {
                decimal maxTaxable = 40000 - 20000;
                decimal taxable = salary - 20000;
                if (taxable > maxTaxable)
                    taxable = maxTaxable;
                tax += taxable * 0.1m;
            }

            return tax / Constants.NoOfMonthsInYear;
        }
    }
}