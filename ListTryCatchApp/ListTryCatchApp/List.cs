using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListTryCatchApp
{
    public partial class List : Form
    {
        List<string> users = new List<string>();
        List<string> names = new List<string>();
        List<int> ages = new List<int>();
     
        public List()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string user;
                int age;
                string name = nameTextBox.Text;
                userlabel.Text = "";

                if (!string.IsNullOrEmpty(userTextBox.Text))
                {
                    user = userTextBox.Text;
                    bool isExist= false;
                    isExist = IsExist(user);
                    if(isExist)
                    {
                        MessageBox.Show("User: "+ user +"alreday exist!!");
                        return;
                    } 

                }

                else
                {

                    userlabel.Text= "Field Can not be Empty!";
                    return;
                }

 
              
                agelabel.Text = "";

                if (!string.IsNullOrEmpty(ageTextBox.Text))
                {
                    age = Convert.ToInt32(ageTextBox.Text);
                  
                    
                }

                else
                {

                    agelabel.Text="Field Can not be Empty!";
                    return;
                }


              
                users.Add(user);
                names.Add(name);
                ages.Add(age);


                displayRichTextBox.Text = Display();
                
            }


            catch (Exception exception)
            {
                MessageBox.Show (exception.Message);

            }


        }


        private string Display()

        {
           
            string message = "";

            message = "SL\tUser\tName\tAge\n";
            int index = 0;
            foreach (string user in users)
            {   
                message = message + (index+1)+"\t" + users[index] +"\t" + names[index] +"\t"+ ages[index]+"\n";
                index++;

            }

            return message;
   
    

        }

        private bool IsExist(string user)
        {
            bool isExist = false;
            foreach(string userChk in users)
            {
                if (user == userChk)
                    isExist = true;

            }

            return isExist;
        }



    }
}
