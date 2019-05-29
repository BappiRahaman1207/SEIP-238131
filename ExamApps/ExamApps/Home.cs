using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamApps
{
    public partial class Home : Form
    {
        const int size = 10;
        int[] number = new int[size];
        int[] max = new int[size];
        int[] min = new int[size];
        int index = 0;
        

        public Home()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {



            string message = "";
            number[index] = Convert.ToInt32(numberTextBox.Text);
            index++;
            for (int index = 0; index < number.Length; index++)
            {
                if (number[index] != 0)

                    message = message +"element " + index + " - " + number[index].ToString() +"\n";

            }

            showRichTextBox.Text = message +"\n";
            numberTextBox.Clear();

        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            string message = "";
            //number[index] = Convert.ToInt32(numberTextBox.Text);
            index++;
            for (int index = 0; index < number.Length; index++)
            {
                if (number[index] != 0)

                    message = message + "element " + index + " - " + number[index].ToString() + "\n";

            }

            showRichTextBox.Text = message+"\n";
            numberTextBox.Clear();

        }

        private void ReverseButton_Click(object sender, EventArgs e)
        {
          string message = "";
             for (int index = number.Length-1;index>=0; index--)
            {
                if (number[index] != 0)

                    message = message + "element " + index + " - " + number[index].ToString() + "\n";

            }

            showRichTextBox.Text = message;
            numberTextBox.Clear();

        }

        private void SumButton_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int index = 0; index < number.Length; index++)
            {
                if (number[index] != 0)

                    sum = sum + number[index];

            }
            showRichTextBox.Text = "Sum :" + sum;
            numberTextBox.Clear();
        }

        private void MaximumButton_Click(object sender, EventArgs e)
        {
            int max = number[0];
            string message = "";
            //number[index] = Convert.ToInt32(numberTextBox.Text);
            index++;
            for (int index = 0; index < number.Length; index++)
            {
                if (number[index] != 0)

                    message = message + "element " + index + " - " + number[index].ToString() + "\n";

            }

            showRichTextBox.Text = message + "\n";




            for (int index = 0; index < number.Length; index++)

            {

                if (number[index] > max)
                {
                    max = number[index];
                }


                showRichTextBox.Text = "Maximum element is :" + max + "\n";


               }
            numberTextBox.Clear();

        }

        private void MinimumButton_Click(object sender, EventArgs e)
        {

            int min = number[0];
            string message = "";
            //number[index] = Convert.ToInt32(numberTextBox.Text);
            index++;
            for (int index = 0; index < number.Length; index++)
            {
                if (number[index] != 0)

                    message = message + "element " + index + " - " + number[index].ToString() + "\n";

            }

            showRichTextBox.Text = message + "\n";




            for (int index = 0; index < number[index]; index++)

            {

                if (number[index] < min)
                {
                    min = number[index];
                }

                showRichTextBox.Text = "Minimum element is :" + min + "\n";


            }
            numberTextBox.Clear();
        }
    }
}
