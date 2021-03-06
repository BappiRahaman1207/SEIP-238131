﻿using System;
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
    public partial class Students : Form
    {
        class Student
        {
            public int ID { get; set; }
            public int SL { get; set; }
            public string RollNo { set; get; }
            public string Name { set; get; }
            public int Age { set; get; }
            public string Address { set; get; }
            public int DistrictID { set; get; }
  

        }
        int id;


        public Students()
        {
            InitializeComponent();
        }

        private void Students_Load(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.SL =Convert.ToInt32( sslTextBox.Text);
            student.RollNo = rollTextBox.Text;
            student.Name = nameTextBox.Text;
            student.Age = Convert.ToInt32(ageTextBox.Text);
            student.Address = addressTextBox.Text;
            student.DistrictID = Convert.ToInt32(districtTextBox.Text);
            Insert(student);
            Clear();

        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            string connectionString = @"server=DESKTOP-GPO65HT;Database= ADODB;integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string commandString = @"SELECT * FROM Students";
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

        private void Insert(Student student)
        {

            try
            {
                //

                SqlConnection sqlConnection = new SqlConnection();
                String connectionString = @"server=DESKTOP-GPO65HT;Database= ADODB;integrated Security=True";
                sqlConnection.ConnectionString = connectionString;

                //
                SqlCommand sqlCommand = new SqlCommand();
                //string commandString = @"INSERT INTO Students Values ('Electronics and Electrical Engineering','EEE')";
                //string commandString = @"INSERT INTO Students Values ('"+name+"','"+code+"')";
                string commandString = @"INSERT INTO Students Values ('"+student.SL+"','" + student.RollNo + "','" + student.Name + "','" + student.Age + "','" + student.Address + "','" + student.DistrictID + "')";
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
            Student student = new Student();
            student.SL = Convert.ToInt32(sslTextBox.Text);
            student.RollNo = rollTextBox.Text;
            student.Name = nameTextBox.Text;
            student.Age = Convert.ToInt32(ageTextBox.Text);
            student.Address = addressTextBox.Text;
            student.DistrictID = Convert.ToInt32(districtTextBox.Text);
            Delete(student);
        }

        private void Delete(Student student)
        {
            try
            {
                //

                SqlConnection sqlConnection = new SqlConnection();
                String connectionString = @"server=DESKTOP-GPO65HT;Database= ADODB;integrated Security=True";
                sqlConnection.ConnectionString = connectionString;

                //
                SqlCommand sqlCommand = new SqlCommand();
                string commandString = @"DELETE FROM Students WHERE ID = '" + id + "' ";
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
            Student student = new Student();
            student.SL = Convert.ToInt32(sslTextBox.Text);
            student.RollNo = rollTextBox.Text.ToString();
            student.Name = nameTextBox.Text;
            student.Age = Convert.ToInt32(ageTextBox.Text);
            student.Address = addressTextBox.Text;
            student.DistrictID = Convert.ToInt32(districtTextBox.Text);
            Update(student);

        }




        private void Update(Student student)
        {
            try
            {
                //

                SqlConnection sqlConnection = new SqlConnection();
                String connectionString = @"server=DESKTOP-GPO65HT;Database= ADODB;integrated Security=True";
                sqlConnection.ConnectionString = connectionString;

                //
                SqlCommand sqlCommand = new SqlCommand();
                string commandString = @"UPDATE Students  SET SL='" + sslTextBox+ "',RollNo='" + rollTextBox + "',Name='" + nameTextBox + "',Age='" + ageTextBox + "',Address='" + addressTextBox + "',DistrictID='" + districtTextBox + "'WHERE ID= '" + id + "';";
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

            string commandString = @"SELECT * FROM Students WHERE SL='" + sslTextBox.Text + "'";
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



        private void Clear()

        {
          sslTextBox.Text="";
          rollTextBox.Text="";
          nameTextBox.Text="";
          ageTextBox.Text="";
          addressTextBox.Text="";
          districtTextBox.Text="";

        }

        private void ShowDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ShowDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = Convert.ToInt32(ShowDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            sslTextBox.Text = ShowDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            rollTextBox.Text = ShowDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            nameTextBox.Text = ShowDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            ageTextBox.Text = ShowDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            addressTextBox.Text = ShowDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            districtTextBox.Text = ShowDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();

        }
    }
}
