﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonInformationAppWalkthrough2
{
    public partial class PersonInformationUi : Form
    {
        public PersonInformationUi()
        {
            InitializeComponent();
        }



        private void ShowButton_Click(object sender, EventArgs e)
        {
            Person personObj = new Person();

            personObj.firstName = firstNameTextBox.Text;
            personObj.middleName = middleNameTextBox.Text;
            personObj.lastName = lastNameTextBox.Text;


            string fullName = personObj.GetFullName();
            string reverseName = personObj.GetReverseName();

            fullNameTextBox.Text = fullName;

            reverseNameTextBox.Text = reverseName;

        }
    }
}
