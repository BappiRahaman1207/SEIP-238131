using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopApp
{
    public partial class CoffeeShop : Form

    {   const int size = 20;
        int index = 0;
        List<int>  numberOfQuantity = new List<int>();
        int blackCoffeePrice = 120;
        int coldCoffeePrice = 120;
        int hotCoffeePrice = 120;
        int regularCoffeePrice = 120;
        List<string> customerName = new List<string>();
        List<int> contactNo = new List<int>();
        List<string> customerAddress = new List<string>();
        List<string> orderBox = new List<string> ();
        List<int> totalPrice = new List<int>() ;
    

    
        public CoffeeShop()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            customerName.Add( nameTextBox.Text);
            contactNo.Add (Convert.ToInt32(contactTextBox.Text));
            customerAddress.Add( addressTextBox.Text);
            orderBox.Add(Convert.ToString(OrderComboBox.Text));
            numberOfQuantity.Add( Convert.ToInt32(quantityTextBox.Text));
            totalPrice.Add(index);
            string message = "";

            if (orderBox[index] == "Black")

            {
                totalPrice[index] = blackCoffeePrice * numberOfQuantity[index];


            }

            else if (orderBox[index] == "Cold")

            {

                totalPrice[index] = coldCoffeePrice * numberOfQuantity [index];
                
            }

            else if (orderBox [ index] == "Hot")

            {

                totalPrice[index] = hotCoffeePrice * numberOfQuantity[index];
               
            }

            else 

            {

                totalPrice[index] = regularCoffeePrice * numberOfQuantity[index];


            }

            index++;

            for(int index = 0; index < customerName.Count; index++)
            {
                if (numberOfQuantity[index]!=0)
                {
                    message = message + "\tCustomer Information\n" + "-------------------------------------------------------------------" +"\n\n"
                    +"\nCustomer Name :" +customerName[index]+"\n\n" + "\nContact No :" + contactNo[index] + "\n\n"
                    +"\n Customer Address :" + customerAddress[index] + "\n\n"
                    + "\nOrder : " + orderBox[index] + "\n\n" + "\nQuantity : " + numberOfQuantity[index] + "\n\n"
                    + "\nTotal Price :" +totalPrice[index]+"\n\n";



                }


            }
            displayRichTextBox.Text = message;


            /*  else if (orderBox == "Hot")

              {
                  displayRichTextBox.Text = "\nCustomer Information\n\n\n"; // + "Total Price : " + totalPrice "\n\n";
                  displayRichTextBox.Text = "\nCustomer Name    : " + customerName + "\n\n";
                  displayRichTextBox.Text = "\nContact No       : " + contactNo + "\n\n";
                  displayRichTextBox.Text = "\nCustomer Address : " + customerAddress + "\n\n";
                  displayRichTextBox.Text = "\nOrder            : " + orderBox + "\n\n";
                  displayRichTextBox.Text = "\nQuantity         : " + numberOfQuantity + "\n\n";
                  //totalPrice = hotCoffeePrice * numberOfQuantity;

              }

              else 

              {
                  displayRichTextBox.Text = "\nCustomer Information\n\n\n"; // + "Total Price : " + totalPrice "\n\n";
                  displayRichTextBox.Text = "\nCustomer Name    : " + customerName + "\n\n";
                  displayRichTextBox.Text = "\nContact No       : " + contactNo + "\n\n";
                  displayRichTextBox.Text = "\nCustomer Address : " + customerAddress + "\n\n";
                  displayRichTextBox.Text = "\nOrder            : " + orderBox + "\n\n";
                  displayRichTextBox.Text = "\nQuantity         : " + numberOfQuantity + "\n\n";
                  //totalPrice = regularCoffeePrice * numberOfQuantity;

              } */

        }
    }
}
