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

namespace StudentsApps
{
    public partial class Departments : Form
    {
        class Department
        {
            public int SL { set; get; }
            public string Name { set; get; }
            public string Code { set; get; }

        }
        public Departments()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //string name = "BANGLA";
            //string code = "BG";

            // string name = nameTextBox.Text;
            //string code = codeTextBox.Text;

            //Insert(name,code);

            Department department = new Department();
            department.SL = Convert.ToInt32(slTextBox.Text);
            department.Name = nameTextBox.Text;
            department.Code = codeTextBox.Text;
            slTextBox.Text = "";
            nameTextBox.Text = "";
            codeTextBox.Text = "";

            Insert(department);
            Display();
            

        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            Display();
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
                string commandString = @"INSERT INTO Departments Values ('" + department.SL + "','" + department.Name + "','" + department.Code + "')";
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

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Department department = new Department();
            department.SL = Convert.ToInt32(slTextBox.Text);
            department.Name = nameTextBox.Text;
            department.Code = codeTextBox.Text;
            Delete(department);

        }



        private void Delete(Department department)
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
                string commandString = @"DELETE FROM Departments WHERE SL = '"+ slTextBox.Text+"'";
                sqlCommand.CommandText = commandString;
                sqlCommand.Connection = sqlConnection;

                //
                sqlConnection.Open();


                int isExecuted = 0;
                isExecuted = sqlCommand.ExecuteNonQuery();

                if (isExecuted > 0)
                {
                    MessageBox.Show("Delete Data Successfuly!");

                }

                else
                {
                    MessageBox.Show("Delete Failed!");
                }




                //
                sqlConnection.Close();



            }

            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Department department = new Department();
            department.SL = Convert.ToInt32(slTextBox.Text);
            department.Name = nameTextBox.Text;
            department.Code = codeTextBox.Text;
            Update(department);
        }


        private void Update(Department department)
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
                string commandString = @"UPDATE Departments set SL= '" + slTextBox.Text + "', Name ='" + nameTextBox.Text + "',Code='" + codeTextBox.Text + "' WHERE SL= '" + slTextBox.Text + "';";
                sqlCommand.CommandText = commandString;
                sqlCommand.Connection = sqlConnection;

                //
                sqlConnection.Open();


                int isExecuted = 0;
                isExecuted = sqlCommand.ExecuteNonQuery();

                if (isExecuted > 0)
                {
                    MessageBox.Show("Update Data Successfuly!");

                }

                else
                {
                    MessageBox.Show("Update Failed!");
                }




                //
                sqlConnection.Close();



            }

            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Search();
        }


        private void Search()
        {

            string connectionString = @"server=DESKTOP-GPO65HT;Database= ADODB;integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string commandString = @"SELECT * FROM Departments WHERE SL='"+slTextBox.Text+"'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataReader dataReader = sqlCommand.ExecuteReader();


            if (dataReader.HasRows)
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);
                ShowDataGridView.DataSource = dataTable;

            }



            sqlConnection.Close();


        }

        private void Display()
        {

            string connectionString = @"server=DESKTOP-GPO65HT;Database= ADODB;integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string commandString = @"SELECT * FROM Departments";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataReader dataReader = sqlCommand.ExecuteReader();


            if (dataReader.HasRows)
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);
                ShowDataGridView.DataSource = dataTable;

            }



            sqlConnection.Close();


        }


    }
}
