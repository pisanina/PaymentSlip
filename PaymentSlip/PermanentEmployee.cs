using System;
using static PaymentSlip.AnnualBonus;
using static PaymentSlip.EmploeeType;

namespace PaymentSlip
{
    internal class PermanentEmployee : Employee
    {
        public typeOfEmployee Type { get; } = typeOfEmployee.permanent;
        public decimal MonthlySalary { get; set; }
        public bonus AnnualBonus { get; set; }

        public override decimal GetSalary(DateTime date)
        {
            return MonthlySalary;
        }

        public override void PrintPaymentSlip(DateTime date)
        {
            base.PrintPaymentSlip(date);

            if (date.Month == 12)
                Console.WriteLine("Annual bonus = " + MonthlySalary*12*(((int)AnnualBonus)/100));
        }

        public PermanentEmployee(decimal monthlySalary, bonus annualBonus) : base(RandomNameforEmployee.GenerateFirstName(), RandomNameforEmployee.GenerateLastName())
        {
            MonthlySalary = monthlySalary;
            AnnualBonus = annualBonus;
        }
    }
}