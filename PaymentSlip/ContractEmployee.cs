using System;
using System.Collections.Generic;
using static PaymentSlip.EmploeeType;

namespace PaymentSlip
{
    internal class ContractEmployee : Employee
    {
        public typeOfEmployee Type { get; } = typeOfEmployee.contract;
        public decimal HourlyWage { get; set; }


        public override decimal GetSalary(DateTime date)
        {
            return (HourlyWage *8) * BusinessDaysOfMonth(date);
        }

        //public virtual void PrintPaymentSlip(DateTime mounthOfYear)
        //{
        //    System.Console.WriteLine(FirstName + " " + LastName + "\n" +mounthOfYear.Month+ "\n" + GetSalary(mounthOfYear)+ "\n");
        //}

        public ContractEmployee(decimal hourlyWage) :base(RandomNameforEmployee.GenerateFirstName(), RandomNameforEmployee.GenerateLastName())
        {
            HourlyWage = hourlyWage;
        }

        public int BusinessDaysOfMonth (DateTime date)
        {
            int workingDays = 0;
            var days = DateTime.DaysInMonth(date.Year, date.Month);

                for (int i = 1; i <= days; i++)
            {
                DateTime day = new DateTime(date.Year, date.Month, i);
                if (day.DayOfWeek != DayOfWeek.Saturday && day.DayOfWeek != DayOfWeek.Sunday)
                    workingDays++;
            }
            return workingDays;
        }
    }
}