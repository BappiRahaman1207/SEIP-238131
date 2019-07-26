using EntityFrameworkExamples.DatabaseContext;
using EntityFrameworkExamples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkExamples
{
    class Program
    {
        static void Main(string[] args)
        {


            Product product = new Product()
            {
                Name = "A",
                Price = 15000.0,
                ProductType = "Electronics"
            };

            ProjectDbContext db = new ProjectDbContext();
            db.Products.Add(product);

            int rowAffected = db.SaveChanges();

            if (rowAffected > 0)
            {
                Console.WriteLine("Successful!");
            }

            Console.ReadKey();



        }
    }
}
