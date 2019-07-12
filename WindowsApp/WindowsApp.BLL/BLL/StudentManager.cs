using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsApp.Models.Models;
using WindowsApp.Repository.Repository;

namespace WindowsApp.BLL.BLL
{
    public class StudentManager
    {
        StudentRepository _studentRepository = new StudentRepository();
        public string AddStudent(Student student)
        {
      
          return  _studentRepository.AddStudent(student);
        }
    }
}
