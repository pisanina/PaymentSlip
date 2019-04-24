using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentSlip
{
    class ContractEmployeeFactory
    {
        private Random random = new Random();

        public ContractEmployee GetNewEmployee()
        {
            decimal hourlyWage = random.Next(5, 10) * 10;
            
            return new ContractEmployee(hourlyWage);
        }
    }
}
