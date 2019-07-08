using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContructorChaining
{
    class Person
    {
        private string FirstName { get; set; }
        private string MidName { get; set; }
        private string LastName { get; set; }

            public Person()
            {

            }

        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }



        public Person(string firstName,string midName, string lastName):this(firstName,lastName)
        {
            //this.FirstName = firstName;
            this.MidName = midName;
            //this.LastName = lastName;
        }


    }

}
