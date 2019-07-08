using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystemApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CategorySetupButton_Click(object sender, EventArgs e)
        {
            CategoryUi categoryUi = new CategoryUi();
            categoryUi.Show();
        }

        private void CompanySetupButton_Click(object sender, EventArgs e)
        {
            CompanyUi companyUi = new CompanyUi();
            companyUi.Show();
        }
    }
}
