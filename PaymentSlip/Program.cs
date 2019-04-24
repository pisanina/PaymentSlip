using System;
using System.Collections.Generic;

namespace PaymentSlip
{
    class Program
    {
        static void Main(string[] args)
        {
            uint howMany = 0;
            List<Employee> employeeList = new List<Employee>();
            Console.WriteLine("How many employes is needed?");
            if (uint.TryParse(Console.ReadLine(), out howMany))
            {
                employeeList.AddRange(GetPermanentEmployee(howMany / 2));

                employeeList.AddRange(GetContractEmployee(howMany / 2));

                foreach (var item in employeeList)
                {
                    item.PrintPaymentSlip(DateTime.Now);
                }

                Console.Read();
            }

        }

            static List<PermanentEmployee> GetPermanentEmployee(uint howmany)
            {
                PermanentEmployeeFactory permanentEmployeeFactory = new PermanentEmployeeFactory();
                List<PermanentEmployee> permanentEmloyesList = new List<PermanentEmployee>();

                for (uint i = 0; i < howmany; i++)
                {
                     var employee = permanentEmployeeFactory.GetNewEmployee();
                    permanentEmloyesList.Add(employee);
                }
                return permanentEmloyesList;
            }

            static List<ContractEmployee> GetContractEmployee(uint howmany)
            {
                ContractEmployeeFactory contractEmployeeFactory = new ContractEmployeeFactory();
                List<ContractEmployee> contractEmloyesList = new List<ContractEmployee>();

                for (uint i = 0; i < howmany; i++)
                {
                    var employee = contractEmployeeFactory.GetNewEmployee();
                    contractEmloyesList.Add(employee);
                }
                return contractEmloyesList;
            }
    }
}
