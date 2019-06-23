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
    public partial class PriceRange : Form
    {
        //Connection
        private string connectionString;
        private SqlConnection sqlConnection;

        //Command
        private string commandString;
        private SqlCommand sqlCommand;

        private MobileInformation mobileInformation;

        public PriceRange()
        {
            InitializeComponent();
            connectionString = @"Server=DESKTOP-GPO65HT; Database=MobileDB; Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            MobileInformation mobileInformation = new MobileInformation();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void PriceRange_Load(object sender, EventArgs e)
        {
            MobileInformation mobileInformation = new MobileInformation();
           
            Show(mobileInformation);
        }



        private void Show(MobileInformation mobileInformation)
        {

            sqlConnection.Open();

            //
            commandString = @"SELECT * FROM  MobileInformation";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            //
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
                DisplayDataGridView.DataSource = dataTable;
            //
            sqlConnection.Close();

        }

        private void ImeiButton_Click(object sender, EventArgs e)
        {
            Search();
        }



        private void Search()
        {

            string connectionString = @"server=DESKTOP-GPO65HT;Database= MobileDB;integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string commandString = @"SELECT * FROM MobileInformation WHERE Imei='" + imeiTextBox.Text + "'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataReader dataReader = sqlCommand.ExecuteReader();


            if (dataReader.HasRows)
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);
               DisplayDataGridView.DataSource = dataTable;

            }



            sqlConnection.Close();


        }



    }
}
