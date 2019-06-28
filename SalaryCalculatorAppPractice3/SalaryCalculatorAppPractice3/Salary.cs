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


        public int GetHomeRent()
        {

            int homeRent = basicAmount / 100;
            return homeRent;

        }


        public int GetMedicalAllowance()
        {

            int medicalAllowance = basicAmount /100;
            return medicalAllowance;

        }



        public int GetSalary()
        {

            int TotalSalary = basicAmount + homeRent + medicalAllowance;
            return TotalSalary;

        }


    }
}
