using System;
using static PaymentSlip.AnnualBonus;

namespace PaymentSlip
{
    internal class PermanentEmployeeFactory
    {
        private Random random = new Random();

        public PermanentEmployee GetNewEmployee()
        {
            bonus bonus;
            int mountlySalary = random.Next(1, 10) * 1000;
            float select = random.Next(0,9);
            if (select < 3)
                bonus = bonus.basic;
            else if (select < 6)
                bonus = bonus.good;
            else
                bonus = bonus.high;

            return new PermanentEmployee(mountlySalary, bonus);
        }
    }
}