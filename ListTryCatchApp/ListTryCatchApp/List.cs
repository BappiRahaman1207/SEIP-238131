﻿using System;
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

                if (!string.IsNullOrEmpty(userTextBox.Text))
                {
                    user = userTextBox.Text;
                    users.Add(user);

                }

                else
                {

                    MessageBox.Show("Field Can not be Empty!");
                    return;
                }

                string name = nameTextBox.Text;
                names.Add(name);


                int age;
                if (!string.IsNullOrEmpty(ageTextBox.Text))
                {
                    age = Convert.ToInt32(ageTextBox.Text);
                    ages.Add(age);
                    
                }

                else
                {

                    MessageBox.Show("Field Can not be Empty!");
                    return;
                }

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




    }
}
