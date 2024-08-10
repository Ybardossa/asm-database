using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // Load department information when the form loads
            LoadDepartmentInformation();
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            // Call the method to filter department information
            FilterDepartmentInformation();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Call the method to delete selected department information
            DeleteDepartmentInformation();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            // Call the method to update selected department information
            UpdateDepartmentInformation();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            // Refresh the department information
            LoadDepartmentInformation();
        }

        private void LoadDepartmentInformation()
        {
            // Update the connection string with your database details
            string connectionString = "Server=MSI;Database=ThucTap;User Id=MyLogin;Password=MyPassword;";

            // SQL query to retrieve department information
            string query = "SELECT DepartmentID, DepartmentName, PhoneNumber FROM Departments";

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

        private void FilterDepartmentInformation()
        {
            // Implement your filtering logic here
            // For example, filter by DepartmentName
            string filterValue = rtb_departmentname.Text;

            DataTable dataTable = (DataTable)dataGridView1.DataSource;
            if (dataTable != null)
            {
                dataTable.DefaultView.RowFilter = string.Format("DepartmentName LIKE '%{0}%'", filterValue);
            }
        }

        private void DeleteDepartmentInformation()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string departmentID = selectedRow.Cells["DepartmentID"].Value.ToString();

                // Update the connection string with your database details
                string connectionString = "Server=MSI;Database=asm2;User Id=admin;Password=123;";

                // SQL query to delete department information
                string query = "DELETE FROM Departments WHERE DepartmentID = @DepartmentID";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        // Open the connection
                        connection.Open();

                        // Create a SQL command
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Add parameters to the SQL query
                            command.Parameters.AddWithValue("@DepartmentID", departmentID);

                            // Execute the command
                            command.ExecuteNonQuery();

                            // Notify the user
                            MessageBox.Show("Department information deleted successfully!");

                            // Refresh the department information
                            LoadDepartmentInformation();
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

        private void UpdateDepartmentInformation()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1 .SelectedRows[0];
                string departmentID = selectedRow.Cells["DepartmentID"].Value.ToString();
                string departmentName = rtb_departmentname.Text;
                string phoneNumber = rtb_phonenumber.Text;

                // Update the connection string with your database details
                string connectionString = "Server=MSI;Database=asm2;User Id=admin;Password=123;";

                // SQL query to update department information
                string query = "UPDATE Departments SET DepartmentName = @DepartmentName, PhoneNumber = @PhoneNumber WHERE DepartmentID = @DepartmentID";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        // Open the connection
                        connection.Open();

                        // Create a SQL command
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Add parameters to the SQL query
                            command.Parameters.AddWithValue("@DepartmentID", departmentID);
                            command.Parameters.AddWithValue("@DepartmentName", departmentName);
                            command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

                            // Execute the command
                            command.ExecuteNonQuery();

                            // Notify the user
                            MessageBox.Show("Department information updated successfully!");

                            // Refresh the department information
                            LoadDepartmentInformation();
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
}
