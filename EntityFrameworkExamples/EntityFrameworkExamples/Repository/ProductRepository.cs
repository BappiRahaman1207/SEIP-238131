using EntityFrameworkExamples.DatabaseContext;
using EntityFrameworkExamples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkExamples.Repository
{
    public class ProductRepository
    {

        ProjectDbContext db = new ProjectDbContext();
        public bool Add(Product product)
        {
            db.Products.Add(product);
            return db.SaveChanges() > 0;

        }

        public List<Product> GetAll()
        {
            return db.Products.ToList();
        }

        public List<Product> GetByName(string name)
        {
            var products = db.Products.Where(c => c.Name.Contains(name));
            return products.ToList();
        }
    }

}

