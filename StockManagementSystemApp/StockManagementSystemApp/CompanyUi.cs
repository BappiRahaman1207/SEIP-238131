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
    public partial class CompanyUi : Form
    {
        private string connectionString;
        private SqlConnection sqlConnection;

        //Command
        private string commandString;
        private SqlCommand sqlCommand;

        private CompanyUi companyUi;
        public CompanyUi()
        {
            connectionString = @"Server=DESKTOP-GPO65HT; Database=SMS; Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            InitializeComponent();
        }

        private void CompanyUiButton_Click(object sender, EventArgs e)
        {
            CompanyUi companyUi = new CompanyUi();
            companyUi.Name = companyUiTextBox.Text;
            Insert(companyUi);

        }


        private void Insert(CompanyUi companyUi)
        {
            try
            {

                //
                sqlConnection.Open();

                commandString = @"INSERT INTO CompanyUi (Name) VALUES ('" + companyUi.Name + "')";
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

        private void CompanyUi_Load(object sender, EventArgs e)
        {
            CompanyUi categoryUi = new CompanyUi();
            categoryUi.Name = companyUiTextBox.Text;

            Show(categoryUi);
        }

        private void Show(CompanyUi companyUi)
        {

            sqlConnection.Open();

            //
            commandString = @"SELECT * FROM CompanyUi";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            //
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
                CompanyUiDataGridView.DataSource = dataTable;
            //
            sqlConnection.Close();

        }





    }
}
