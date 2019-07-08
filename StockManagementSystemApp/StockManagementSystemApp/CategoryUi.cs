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

namespace StockManagementSystemApp
{
    public partial class CategoryUi : Form
    {
        private string connectionString;
        private SqlConnection sqlConnection;

        //Command
        private string commandString;
        private SqlCommand sqlCommand;

        private CategoryUi categoryUi;

        public CategoryUi()
        {
            connectionString = @"Server=DESKTOP-GPO65HT; Database=SMS; Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            CategoryUi categoryUi = new CategoryUi ();
            categoryUi.Name = CategorySetupTextBox.Text;
            Insert(categoryUi);
        }

        private void Insert(CategoryUi categoryUi)
        {
            try
            {

                //
                sqlConnection.Open();

                commandString = @"INSERT INTO CategoryUi (Name) VALUES ('"+ categoryUi.Name + "')";
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

        private void CategoryUi_Load(object sender, EventArgs e)
        {
            CategoryUi categoryUi = new CategoryUi();
            categoryUi.Name = CategorySetupTextBox.Text;

            Show(categoryUi);
        
        }


        private void Show(CategoryUi categoryUi)
        {

            sqlConnection.Open();

            //
            commandString = @"SELECT * FROM CategoryUi";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            //
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
                CategorySetupDataGridView.DataSource = dataTable;
            //
            sqlConnection.Close();

        }



    }
}
