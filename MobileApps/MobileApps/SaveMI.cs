using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MobileApps.Models;

namespace MobileApps
{
    public partial class SaveMI : Form
    {
        //Connection
        private string connectionString;
        private SqlConnection sqlConnection;

        //Command
        private string commandString;
        private SqlCommand sqlCommand;

        private MobileInformation mobileInformation;

        public SaveMI()
        {
            InitializeComponent();
            //Initialize Connection
            connectionString = @"Server=DESKTOP-GPO65HT; Database=MobileDB; Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            MobileInformation mobileInformation = new MobileInformation();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (modelTextBox.Text == "")
            {
                label4.Text = "";
                label4.Text = "Field Can not be Empty!";
                return;
            }
            else
            {
                label4.Text = "";
            }


            if (imeiTextBox.Text == "")
            {
                label5.Text = "";
                label5.Text = "Field Can not be Empty!";
                return;
            }
            else
            {
                label5.Text = "";
            }


            if (priceTextBox.Text == "")
            {
                label6.Text = "";
                label6.Text = "Field Can not be Empty!";
                return;
            }
            else
            {
                label6.Text = "";
            }




            MobileInformation mobileInformation = new MobileInformation();
            mobileInformation.Model = modelTextBox.Text;
            mobileInformation.IMEI = imeiTextBox.Text;
            mobileInformation.Price = Convert.ToInt32(priceTextBox.Text);
            modelTextBox.Text = "";
            imeiTextBox.Text = "";
            priceTextBox.Text = "";

            Insert(mobileInformation);
          
        }


        private void Insert(MobileInformation mobileInformation)
        {
            try
            {

                //
                sqlConnection.Open();

                commandString = @"INSERT INTO MobileInformation ( ModelName,IMEI,Price) VALUES ('" + mobileInformation.Model + "', '" + mobileInformation.IMEI + "', '" + mobileInformation.Price + "')";
                sqlCommand = new SqlCommand(commandString, sqlConnection);

                int isExecuted;
                isExecuted = sqlCommand.ExecuteNonQuery();

                if (isExecuted > 0)
                {
                    MessageBox.Show("Saved!!");
                }
                else
                {
                    MessageBox.Show("Not Saved!!");
                }

                //
                sqlConnection.Close();
            }

            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }



        }

        private void modelTextBox_TextChanged(object sender, EventArgs e)
        {
           

        }





    }
}
