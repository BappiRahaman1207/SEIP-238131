using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireRangeApps
{
    public partial class Home : Form

    {
        const int size = 20;
        int index = 0;
        int[] soldierNo = new int [size];
        string[] soldierName = new string[size];
        int[] target1score = new int[size];
        int[] target2score = new int[size];
        int[] target3score = new int[size];
        int[] target4score = new int[size];

        public Home()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
           
            string message = "";

            soldierNo[index] =Convert.ToInt32(SoldierNoTextBox.Text);
            soldierName[index] = SoldierNameTextBox.Text;
            target1score[index] = Convert.ToInt32(Target1ScoreTextBox.Text);
            target2score[index] = Convert.ToInt32(Target2ScoreTextBox.Text);
            target3score[index] = Convert.ToInt32(Target3ScoreTextBox.Text);
            target4score[index] = Convert.ToInt32(Target4ScoreTextBox.Text);
            index++;
            for (int index = 0; index < soldierNo.Length; index++)
            {
                if (soldierNo[index] != 0)

                    message = message + "\t Soldier Information\n" + "-------------------------------------------------------------------" + "\n\n"
                      + "\nSoldier No :" + soldierNo[index] + "\n\n" + "\nSoldier Name :" + soldierName[index] + "\n\n"
                      + "\n Target 1 Score :" + target1score[index] + "\n\n"
                      + "\nTarget 2 Score : " + target2score[index] + "\n\n" + "\nTarget 3 Score  : " + target3score[index] + "\n\n"
                      + "\nTarget 4 Score :" + target4score[index] + "\n\n";



            }

            showRichTextBox.Text = message;

        }

        private void SoldierNoTextBox_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void SoldierNoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
