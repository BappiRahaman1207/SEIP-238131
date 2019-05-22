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

    {
        int numberOfQuantity = 1;
        double blackCoffeePrice = 120;
        double coldCoffeePrice = 120;
        double hotCoffeePrice = 120;
        double regularCoffeePrice = 120;
        string customerName, contactNo, customerAddress, orderBox;
        double totalPrice = 0;
    

    
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
            customerName = nameTextBox.Text;
            contactNo = contactTextBox.Text;
            customerAddress = addressTextBox.Text;
            orderBox = OrderComboBox.Text;
            numberOfQuantity = Convert.ToInt32(quantityTextBox.Text);

            if (orderBox == "Black")

            {
                totalPrice = blackCoffeePrice * numberOfQuantity;
                displayRichTextBox.Text = "\nCustomer Information\n\n" + "\nCustomer Name     : " + customerName + "\n\n"
                + "\nContact No            : " +contactNo + "\n\n" + "\nCustomer Address  : " +customerAddress + "\n\n"
                + "\nOrder                    : " + orderBox + "\n\n" + "\nQuantity                : " + numberOfQuantity + "\n\n\n" + "   Total Price  : "
                + totalPrice + "\n\n";
                
            }

            else if (orderBox == "Cold")

            {

                totalPrice = coldCoffeePrice * numberOfQuantity;
                displayRichTextBox.Text = "\nCustomer Information\n\n" + "\nCustomer Name     : " + customerName + "\n\n"
                + "\nContact No            : " + contactNo + "\n\n" + "\nCustomer Address  : " + customerAddress + "\n\n"
                + "\nOrder                    : " + orderBox + "\n\n" + "\nQuantity                : " + numberOfQuantity + "\n\n\n" + "   Total Price  : "
                + totalPrice + "\n\n";

            }

            else if (orderBox == "Hot")

            {

                totalPrice = hotCoffeePrice * numberOfQuantity;
                displayRichTextBox.Text = "\nCustomer Information\n\n" + "\nCustomer Name     : " + customerName + "\n\n"
                + "\nContact No            : " + contactNo + "\n\n" + "\nCustomer Address  : " + customerAddress + "\n\n"
                + "\nOrder                    : " + orderBox + "\n\n" + "\nQuantity                : " + numberOfQuantity + "\n\n\n" + "   Total Price  : "
                + totalPrice + "\n\n";

            }

            else 

            {

                totalPrice = regularCoffeePrice * numberOfQuantity;
                displayRichTextBox.Text = "\nCustomer Information\n\n" + "\nCustomer Name     : " + customerName + "\n\n"
                + "\nContact No            : " + contactNo + "\n\n" + "\nCustomer Address  : " + customerAddress + "\n\n"
                + "\nOrder                    : " + orderBox + "\n\n" + "\nQuantity                : " + numberOfQuantity + "\n\n\n" + "   Total Price  : "
                + totalPrice + "\n\n";

            }

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
