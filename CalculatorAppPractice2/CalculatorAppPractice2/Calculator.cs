using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorAppPractice2
{
    public class Calculator
    {

        public int firstNumber;
        public int secondNumber;
        public int result;


        public int GetAdd()
        {

            result = firstNumber + secondNumber;
            return result;

        }


        public int GetSubtract()
        {

            result = firstNumber - secondNumber;
            return result;

        }


        public int GetMultiply()
        {

            result = firstNumber * secondNumber;
            return result;

        }


        public int GetDivide()
        {

            result = firstNumber / secondNumber;
            return result;

        }




    }
}
