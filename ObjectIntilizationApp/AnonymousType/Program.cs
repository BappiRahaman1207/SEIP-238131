using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousType
{
    class Program
    {
        static void Main(string[] args)
        {



            var customer = new { Id = 1, Name = "Mr.A", Address = "Danmondi", Loyaltypoint = 120 };
            var product = new { Id = 1, Name = "potato", Unit = "kg", SalesPrice = 40 };
            var student = new { Id = 1, Name = "A", RegNo="001" };




            var customers = new[]
            {

                new{Id=1,Name="Mr.A",Address="Mirpur",Loyaltypoint = 120 },
                new{Id=2,Name="Mr.B",Address="Mdpur",Loyaltypoint = 150 },
                new{Id=3,Name="Mr.C",Address="Danmondi",Loyaltypoint = 130 },


            };





            dynamic aValue = new ExpandoObject();
            aValue.message = "New Message";

            Console.WriteLine(aValue);


            //object aValue = customer;

            //dynamic retrieveCustomer = aValue;

            //Console.WriteLine(retrieveCustomer.Name);




            //ShowCustomer(customers);
            Console.ReadKey();


            //foreach (var c in customers)
            //{

            //    Console.WriteLine(c.Id + " " + c.Name + " " + c.Address + " " + c.Loyaltypoint);
            //}
            //Console.ReadKey();

        }



        public static void ShowCustomer(dynamic customers)
        {

            foreach (var c in customers)
            {

                Console.WriteLine(c.Id + " " + c.Name + " " + c.Address + " " + c.Loyaltypoint);
            }
     

        }

    }

}
