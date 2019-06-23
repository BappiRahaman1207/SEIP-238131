using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWinApp.Models;
using MyWinApp.Repository;
using MyWinApp.BLL;

namespace MyWinApp.Repository
{
    public class StudentRepository
    {

        //Connection
        private string connectionString= @"Server=DESKTOP-GPO65HT; Database=StudentDB; Integrated Security=True";
        private SqlConnection sqlConnection;

        //Command
        private string commandString;
        private SqlCommand sqlCommand;

        //connectionString = @"Server=DESKTOP-GPO65HT; Database=StudentDB; Integrated Security=True";

        // sqlConnection  = new SqlConnection(connectionString);

        public DataTable LoadDistrict()
        {
            //

            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //
            commandString = @"SELECT * FROM Districts";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            //
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

           // if (dataTable.Rows.Count > 0)
                //districtComboBox.DataSource = dataTable;
            //
            sqlConnection.Close();

            return dataTable;
        }


          public void Insert(Student student)
          {
           
                sqlConnection.Open();

                commandString = @"INSERT INTO Students (RollNo, Name, Age, Address, DistrictID) VALUES ('" + student.RollNo + "', '" + student.Name + "', " + student.Age + ", '" + student.Address + "'," + student.DistrictID + ")";
                sqlCommand = new SqlCommand(commandString, sqlConnection);

                int isExecuted;
                isExecuted = sqlCommand.ExecuteNonQuery();

                //if (isExecuted > 0)
                //{
                // MessageBox.Show("Saved!!");
                //}
                //else
                //  {
                //  MessageBox.Show("Not Saved!!");
                // }


                sqlConnection.Close();
           
           
           }


        private void ShowStudent()
        {
            //
            sqlConnection.Open();

            //
            commandString = @"SELECT * FROM StudentsView";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            //
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

           // if (dataTable.Rows.Count > 0)
             //   displayDataGridView.DataSource = dataTable;
            //
            sqlConnection.Close();
        }

    }
}
