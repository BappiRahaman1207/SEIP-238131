using EntityFrameworkExamples.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkExamples.DatabaseContext
{
    public class ProjectDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
