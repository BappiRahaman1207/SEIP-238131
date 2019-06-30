using System;
using System.Collections.Generic;

namespace StudentEntryAppExample2
{
    class Department
    {
        public Department()
        {
            students = new List<Student>();
        }
        public string Code { get; set; }
        public string Name { get; set; }

        private List<Student> students;

        public bool AddStudent(Student student)
        {
            if (students.Count < 15)
            {
                students.Add(student);
                return true;
            }

            return false;
        }

        public string GetDetails()
        {
            string message = "";
            message += "Department Code: " + Code + " Name: " + Name+Environment.NewLine;
            if (students.Count > 0)
            {
                message += "RegNo \t\t Name \t\t Email"+Environment.NewLine;

                foreach (Student student in students)
                {
                    message += student.RegNo + " \t\t " + student.Name + " \t\t " + student.Email+Environment.NewLine;
                }
            }

            return message;
        }

    }
}
