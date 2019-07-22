using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectIntilizationApp
{
    class Program
    {
        static void Main(string[] args)
        {


            Student student = new Student()
            {

                ID = 1,
                Name = "A",
                RegNo="001"
              
            };


            List<Student> studentList = new List<Student>()
            {
                 student,
                 new Student(){ID=2,Name="B",RegNo="002" },
                 new Student(){ID=3,Name="C",RegNo="003" }

            };



            foreach (Student s in studentList)
            {

                Console.WriteLine(s.ID+" "+s.Name+" "+s.RegNo);
            }


            Console.ReadKey();

        }
    }
}
