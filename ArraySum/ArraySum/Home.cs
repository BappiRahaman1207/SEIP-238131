using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArraySum
{
    public partial class Home : Form
    {
        const int size =10 ;
        int[] number = new int[size];
        int index = 0;
        int sum ;


        public Home()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            number[index] = Convert.ToInt32(numbeTextBox.Text);
            index++;

            string message = "";
            for (int index = 0; index < number.Length; index++)
            {
                if (number[index] != 0)

                
                    message = message + "elment " + index + " :" + number[index].ToString() + "\n";


              }

            for (int index = 0; index < number.Length; index++)
            {
                if (number[index] != 0)

                    sum = sum +number[index];

           }

            showRichTextBox.Text = message +"\n"+"Total Sum :"+sum +"\n";
        }
    }
}
