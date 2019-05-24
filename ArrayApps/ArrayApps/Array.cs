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
        public Array()
        {
            InitializeComponent();

            const int size = 10;
            int[] number = new int[size];

            number[0]= 1;
            number[1]= 3;
            number[3]= 4;
            number[9]= 5;

            string messge = "";

            messge = messge + number[0].ToString()+"\n";
            messge = messge + number[1].ToString() + "\n";
            messge = messge + number[3].ToString() + "\n";
            messge = messge + number[9].ToString() + "\n";

            showRichTextBox.Text = messge;

            

        }

        private void ReverseButton_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {

        }
    }
}
