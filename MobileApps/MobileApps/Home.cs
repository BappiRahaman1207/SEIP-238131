using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileApps
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveMI f1 = new SaveMI();
            f1.Show();
        }

        private void PiceRangeButton_Click(object sender, EventArgs e)
        {
            PriceRange f1 = new PriceRange();
            f1.Show();
        }
    }
}
