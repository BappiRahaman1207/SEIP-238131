using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    class Program
    {


        delegate int CalculatorHandler(int f, int s);

        static void Main(string[] args)
        {

            //CalculatorHandler addMethod = Add;




            //CalculatorHandler addMethod =delegate(int num1,int num2)

            //                             {
            //                                 return num1 + num2;

            //                             };







            //CalculatorHandler addMethod = (int num1, int num2) => num1 + num2;





            //int result = addMethod(2, 10);
            //Console.WriteLine(result);




            //Func<int, int, int> addMethod = (x, y) => {
            //    int r = x + y;
            //    return r;



            //};




            Action<string> PrintOutPut = (name) =>
               {

                   Console.WriteLine("Hello World" +" " +name);

               };

            PrintOutPut("Someone");

            Console.ReadKey();
        }




        public static int Add (int num1,int num2)
        {

            return num1 + num2;

        }

        public static int Subtract(int num1, int num2)
        {

            return num1 - num2;

        }



        public static int Multiply(int num1, int num2)
        {

            return num1 * num2;

        }


    }
}
