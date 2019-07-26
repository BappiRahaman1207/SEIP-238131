using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkExamples.Models
{
    public class Product
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string ProductType { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }



    }
}
