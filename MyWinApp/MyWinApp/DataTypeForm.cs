using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinApp
{
    public partial class DataTypeForm : Form
    {
        public DataTypeForm()
        {
            InitializeComponent();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            int number = 10;
            double salary = 1000.50;
            string name = "Ali";
            bool isValied = true;
            MessageBox.Show("Number:" +number +"Salary:" +salary +"Name:" +name + "IsValied:" + isValied);
        }

        private void ConversionButton_Click(object sender, EventArgs e)
        {

        }
    }
}
