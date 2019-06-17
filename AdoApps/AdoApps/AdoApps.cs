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
        class Department
        {
            public string Name { set; get; }
            public string Code{ set; get; }

        }

        public AdoApps()
        {
            InitializeComponent();
        }

        private void AdoApps_Load(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //string name = "BANGLA";
            //string code = "BG";

            // string name = nameTextBox.Text;
            //string code = codeTextBox.Text;

            //Insert(name,code);

            Department department = new Department();
            department.Name = nameTextBox.Text;
            department.Code = codeTextBox.Text;
            Insert(department);

        }

       // private void Insert(string name,string code)
        private void Insert(Department department)
        {

            try
            {
                //

                SqlConnection sqlConnection = new SqlConnection();
                String connectionString = @"server=DESKTOP-GPO65HT;Database= ADODB;integrated Security=True";
                sqlConnection.ConnectionString = connectionString;

                //
                SqlCommand sqlCommand = new SqlCommand();
                //string commandString = @"INSERT INTO Departments Values ('Electronics and Electrical Engineering','EEE')";
                //string commandString = @"INSERT INTO Departments Values ('"+name+"','"+code+"')";
                string commandString = @"INSERT INTO Departments Values ('" + department.Name + "','" + department.Code + "')";
                sqlCommand.CommandText = commandString;
                sqlCommand.Connection = sqlConnection;

                //
                sqlConnection.Open();


                int isExecuted = 0;
                isExecuted = sqlCommand.ExecuteNonQuery();

                if (isExecuted > 0)
                {
                    MessageBox.Show("Save Data Successfuly!");

                }

                else
                {
                    MessageBox.Show("Save Failed!");
                }




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
