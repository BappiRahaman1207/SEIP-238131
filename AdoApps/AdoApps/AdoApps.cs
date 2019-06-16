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

namespace AdoApps
{
    public partial class AdoApps : Form
    {
        public AdoApps()
        {
            InitializeComponent();
        }

        private void AdoApps_Load(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                //
             
                SqlConnection sqlConnection = new SqlConnection();
                String connectionString = @"server=DESKTOP-GPO65HT;Database= ADODB;integrated Security=True";
                sqlConnection.ConnectionString = connectionString;

              //
                SqlCommand sqlCommand = new SqlCommand();
                string commandString = @"INSERT INTO Departments Values ('Computer Science and Engineering','CSE')";
                sqlCommand.CommandText = commandString;
                sqlCommand.Connection = sqlConnection;

                //
                sqlConnection.Open();

                sqlCommand.ExecuteNonQuery();


                //
                sqlConnection.Close();



            }

            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }

        }
    }
}
