using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // You can add any initialization code here
        }
        private void SaveDepartmentInformation()
        {
            // Update the connection string with your database details
            string connectionString = "Server=MSI;Database=ThucTap;User Id=MyLogin;Password=MyPassword;";

            // Retrieve the department information from the text boxes
            string departmentID = rtb_departmentID.Text;
            string departmentName = rtb_DepartmentName.Text;
            string phoneNumber = rtb_phonenumber.Text;

            // SQL query to insert department information
            string query = "INSERT INTO Departments (DepartmentID, DepartmentName, PhoneNumber) VALUES (@DepartmentID, @DepartmentName, @PhoneNumber)";

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
                        MessageBox.Show("Department information saved successfully!");
                    }
                }
                catch (Exception ex)
                {
                    // Handle any errors that may have occurred
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void btn_save_Click_1(object sender, EventArgs e)
        {
            SaveDepartmentInformation();
        }
    }
}
