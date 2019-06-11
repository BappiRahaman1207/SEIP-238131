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
        List<int> soldierNo = new List<int>();
        List<string> soldierName = new List<string>();
        List <int> target1score = new List<int>();
        List <int> target2score = new List<int>();
        List <int>target3score = new List<int>();
        List <int> target4score = new List<int>();

        public Home()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

            try
            {
                int soldier;
                SolierNolabel.Text = "";

                 if (!string.IsNullOrEmpty(SoldierNoTextBox.Text))
                 {
                    soldier = Convert.ToInt32(SoldierNoTextBox.Text);
                  
                    bool isExist = false;
                    isExist = IsExist(soldier);
                    if (isExist)
                    {
                        MessageBox.Show("Soldier Alreday Exists!");
                        return;
                    }
                 }

                 else
                 {
                    SolierNolabel.Text = "Field Can not be Empty!";
                    return;
                }

                soldierNo.Add(Convert.ToInt32(SoldierNoTextBox.Text));
                soldierName.Add(SoldierNameTextBox.Text);
                target1score.Add(Convert.ToInt32(Target1ScoreTextBox.Text));
                target2score.Add(Convert.ToInt32(Target2ScoreTextBox.Text));
                target3score.Add(Convert.ToInt32(Target3ScoreTextBox.Text));
                target4score.Add(Convert.ToInt32(Target4ScoreTextBox.Text));


                showRichTextBox.Text = Display();

                MessageBox.Show("Date insert successfully");
                showRichTextBox.Clear();
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);

            }



        }

        private void SoldierNoTextBox_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void SoldierNoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void ShowAllButton_Click(object sender, EventArgs e)
        {
          
            showRichTextBox.Text = Display();
         
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private string Display()
        {
            string message = "";

            index++;

            for (int index = 0; index < soldierNo.Count; index++)
            {
                if (soldierNo[index] != 0)

                    message = message + "\t Soldier Information\n" + "-------------------------------------------------------------------" + "\n\n"
                      + "\nSoldier No :" + soldierNo[index] + "\n\n" + "\nSoldier Name :" + soldierName[index] + "\n\n"
                      + "\n Target 1 Score :" + target1score[index] + "\n\n"
                      + "\nTarget 2 Score : " + target2score[index] + "\n\n" + "\nTarget 3 Score  : " + target3score[index] + "\n\n"
                      + "\nTarget 4 Score :" + target4score[index] + "\n\n";


            }

         return message;
           

        }

        private bool IsExist(int Soldier)
        {
            bool isExist = false;
            foreach (int SoldierChk in soldierNo)
            {
                if (Soldier == SoldierChk)
                    isExist = true;

            }

            return isExist;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {


            showRichTextBox.Text = Display();



        }
    }

}
