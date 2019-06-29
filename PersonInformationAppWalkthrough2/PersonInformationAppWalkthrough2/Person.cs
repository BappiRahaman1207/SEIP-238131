using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInformationAppWalkthrough2
{
    class Person
    {
        private string firstName;
        private string middleName;
        private string lastName;



       /* public string GetFisrtName(string firstName)
        {

            this.firstName = firstName;
            return firstName;
           
        }
        public string SetFisrtName(string firstName)
        {
            return firstName;

        }*/


        public string FirstName
        {

            get { return firstName; }
            set { this.firstName = value; }
        }




        public string MiddleName
        {

            get { return middleName; }
            set { this.middleName = value; }
        }

        public string LastName
        {

            get { return lastName; }
            set { this.lastName = value; }
        }



        public string GetFullName()
        {
            string fullName = firstName+" " + middleName+" " + lastName;
            return fullName;
        }
        public string GetReverseName()
        {

            string reverseName = "";
            string fullName = GetFullName();
            for(int index=fullName.Length-1;index>=0;index--)
            {
                reverseName += fullName[index];
            }

            return reverseName; 
        }
    }
}
