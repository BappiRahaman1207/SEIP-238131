using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayApps
{
    public partial class Array : Form
    {
        const int size = 10;
        int[] number = new int[size];
        int index = 0;

         
            string messge = "";

        public Array()
        {
            InitializeComponent();

            /*const int size = 10;
           int[] number = new int[size];



           string messge = "";

          messge = messge + "elment of array :" + number[0].ToString()+"\n";
           messge = messge + "elment of array :" + number[1].ToString() + "\n";
           messge = messge + "elment of array :" + number[3].ToString() + "\n";
           messge = messge + "elment of array :" + number[9].ToString() + "\n";


            for (int index = 0; index < number.Length; index++)
            {
                if(number[index]!=0)
                
                messge = messge + "elment of array " + index + " :" + number[index].ToString() + "\n";

            }

            showRichTextBox.Text = messge;*/



        }

        private void ReverseButton_Click(object sender, EventArgs e)
        {


            /*messge = messge + "elment of array :" + number[0].ToString()+"\n";
            messge = messge + "elment of array :" + number[1].ToString() + "\n";
            messge = messge + "elment of array :" + number[3].ToString() + "\n";
            messge = messge + "elment of array :" + number[9].ToString() + "\n";*/

          

            for (int index =number.Length- 1; index >=0; index--)
            {
                if (number[index] != 0)

                    messge = messge + "elment of array " + index + " :" + number[index].ToString() + "\n";

                
            }

            showRichTextBox.Text = messge;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            

            number[index]= Convert.ToInt32( numberTextBox.Text);
            index++;

            string messge = "";

            /*messge = messge + "elment of array :" + number[0].ToString()+"\n";
            messge = messge + "elment of array :" + number[1].ToString() + "\n";
            messge = messge + "elment of array :" + number[3].ToString() + "\n";
            messge = messge + "elment of array :" + number[9].ToString() + "\n";*/


            for (int index = 0; index < number.Length; index++)
            {
                if (number[index] != 0)

                    messge = messge + "elment of array " + index + " :" + number[index].ToString() + "\n";

            }

            showRichTextBox.Text = messge;
        }
    }
}
