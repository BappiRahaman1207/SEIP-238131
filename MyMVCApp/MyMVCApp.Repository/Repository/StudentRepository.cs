using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyMVCApp.Models.Models;
using MyMVCApp.DatabaseContext.DatabaseContext;



namespace MyMVCApp.Repository.Repository
{
    public class StudentRepository
    {

        StudentDbConetxt db = new StudentDbConetxt();

        public bool Add(Student student)
        {

            db.Students.Add(student);

            int saved= db.SaveChanges();

            if (saved < 0)

            {

                return true;
            }


            return false;
        }
        public bool Delete(Student student)
        {
            Student aStudent = db.Students.FirstOrDefault(c => c.ID == student.ID);
            db.Students.Remove(aStudent);

            int saved = db.SaveChanges();

            if (saved < 0)

            {

                return true;
            }

            return false;
        }
        public bool Update(Student student)
        {

            Student aStudent = db.Students.FirstOrDefault(c => c.ID == student.ID);
            //db.Students.Remove(aStudent);

            int saved = 0;
            if(aStudent!=null)
            {
             aStudent.Name = student.Name;
             saved= db.SaveChanges();
            }

            if (saved < 0)

            {

                return true;
            }


            return false;
        }
        public List<Student> GetAll(Student student)
        {
            return db.Students.ToList();
        }
        public Student GetByID(Student student)
        {
            Student aStudent = db.Students.FirstOrDefault(c => c.ID == student.ID);
            return aStudent;
        }
    }
}
