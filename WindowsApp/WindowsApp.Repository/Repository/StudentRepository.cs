using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsApp.Models.Models;

namespace WindowsApp.Repository.Repository
{
   public class StudentRepository
    {

        public string AddStudent(Student student)
        {
            return "My ID: " + student.ID + "  and Name:" +student.Name;

        }

    }
}
