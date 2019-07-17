using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyMVCApp.Models.Models;

namespace MyMVCApp.DatabaseContext.DatabaseContext
{
    public class StudentDbConetxt:DbContext
    {
        public DbSet <Student> Students { get; set; }

    }
}
