using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkExample
{
    class Program
    {
        static void Main(string[] args)
        {


            var products = new List<Product>()
            {

                new Product() { Id = 1, Name = "Nokia 235", Price = 23564, ProductType = "Mobile" },
                new Product() { Id = 1, Name = "Nokia 2352", Price = 235644, ProductType = "Mobile" },
                new Product() { Id = 1, Name = "Nokia 2354", Price = 2356444, ProductType = "Mobile" },
                new Product() { Id = 1, Name = "Nokia 2359", Price = 235642, ProductType = "Mobile" },
                new Product() { Id = 1, Name = "Pen", Price = 3000, ProductType = "Stationary" },
                new Product() { Id = 1, Name = "Monitor", Price = 23564443, ProductType = "Computer" },

            };


            //SELEET * FROM Poructs WHERE Price >5000 And Price <20000

            //var retrieveProducts = from product in products
            //                       where product.Price > 2000 && product.Price < 20000
            //                       select product;



            //var retrieveProducts = from product in products
            //                       where product.Price > 2000 && product.Price < 20000
            //                       orderby product.Name descending
            //                       select
            //                       new
            //                       {
            //                           Name =product.Name,
            //                           Price=product.Price,
            //                           Code=product.Name + product.ProductType,




            //                       };






            var retrieveProducts =  products
                                   .Where (p=> p.Price > 2000 && p.Price < 20000)
                                
                                  .Select (p=>
                                   new
                                   {
                                       Name = p.Name,
                                       Price = p.Price,
                                       Code = p.Name + p.ProductType,




                                   });








            foreach (var p in products )
            {

                Console.WriteLine(p.Name+"   "+p.Price +" "+p.ProductType +" "+p.Code);

            }

            Console.ReadKey();

        }
    }
}
