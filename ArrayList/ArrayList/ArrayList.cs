using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayList
{
    public partial class ArrayList : Form
    {
        public ArrayList()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            List<int> numbers = new List<int>();
            List<string> names = new List<string>();

            names.Add("Ali");
            names.Add("Kaml");
            names.Add("Jori");
            names.Add("Loka");
            names.Add("Dina");

            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);



            string message = "";
            message =message+"Foreach:\n";
            int index = 0;

            foreach (int number in numbers)

            {
            
                message = message +names[index] + " "+ number +"\n";
                index++;
            }

            message =message + "For:\n";
            for (int i = 0; i < numbers.Count; i++)
            {
                message = message +names[i]+ " "+ numbers[i].ToString()+"\n";
            }
            ShowRichTextBox.Text = message + "\n";
        }
    }
}
