using System;
using static PaymentSlip.EmploeeType;

namespace PaymentSlip
{
    public abstract class Employee
    {
        public string FirstName { get; }
        public string LastName { get; }

        //public typeOfEmployee Type { get; set; }

        public abstract decimal GetSalary(DateTime date);

        public virtual void PrintPaymentSlip(DateTime date)
        {
            System.Console.WriteLine (FirstName + " " + LastName + "\n" + date.ToString("MM/yyyy") + "\n" + GetSalary(date) + "\n");
        }

        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
   
}