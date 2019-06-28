using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculatorAppPractice3
{
    class Salary
    {
        public string employeeName;
        public int basicAmount;
        public int homeRent;
        public int medicalAllowance;


     

            public string GetFullSalary()
            {

                int salary = basicAmount + (basicAmount / 100 * homeRent) + (basicAmount / 100 * medicalAllowance);
                return salary.ToString();
            }
    


    }
}
