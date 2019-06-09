using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerInformation
{
    public partial class Home : Form
    {
        List<string> userName = new List<string>();
        List<string> firstName = new List<string>();
        List<string> lastName = new List<string>();
        List<int> contactNo = new List<int>();
        List<string> email = new List<string>();
        List<string> address = new List<string>();
        List<int> accountNo = new List<int>();
       
        public Home()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {


             userName.Add ( userTextBox.Text);
             firstName.Add(firstTextBox.Text);
             lastName.Add(lastTextBox.Text);
             contactNo.Add(Convert.ToInt32(( contactTextBox.Text)));
             email.Add( emailTextBox.Text);
             address.Add( addressTextBox.Text);
             accountNo.Add(Convert.ToInt32((accountTextBox.Text)));



            showRichTextBox.Text = Display();



        }


        private string Display()

        {

            string message = "";

           

            message = "SL\tUser Name\tFirst Name\tLast Name\tContact No\tEmail\t\tAddress\t\tAccount No\n";

           for (int index = 0; index < userName.Count; index++)
            {


                message = message + (index + 1) + "\t" + userName[index] + "\t\t" + firstName[index] + "\t\t" + lastName[index]
                      + "\t\t" + contactNo[index] + "\t\t" + email[index] + "\t\t" + address[index] + "\t\t"
                      + accountNo[index];


                index++;





            }
           

            return message;



        }

    }
}
