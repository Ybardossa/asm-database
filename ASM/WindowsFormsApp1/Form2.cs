using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // You can add any initialization code here
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            // Call the method to load student information
            LoadStudentInformation();
        }

        private void LoadStudentInformation()
        {
            // Update the connection string with your database details
            string connectionString = "Server=MSI;Database=ThucTap;User Id=MyLogin;Password=MyPassword;";

            // SQL query to retrieve student information
            string query = "SELECT StudentID, Name, Age, HomeTown, DepartmentID, Department FROM Students";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Open the connection
                    connection.Open();

                    // Create a SQL data adapter
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        // Fill a DataTable with the results
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Bind the DataGridView to the DataTable
                        dataGridView1.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    // Handle any errors that may have occurred
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
    }
}
