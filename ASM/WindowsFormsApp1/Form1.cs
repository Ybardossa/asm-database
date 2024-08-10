using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // You can add any initialization code here
        }
        private void InsertStudentInformation()
        {
            // Update the connection string with your database details
            string connectionString = "Server=MSI;Database=ThucTap;User Id=MyLogin;Password=MyPassword;";

            // Retrieve the student information from the text boxes
            string studentID = rtb_studentID.Text;
            string name = rtb_studentname.Text;
            string age = rtb_yearofbirth.Text;
            string studentHomeTown = rtb_hometown.Text;
            string departmentID = rtb_departmentID.Text;
            string chooseDepartment = cb_choosedepartment.Text;

            // SQL query to insert student information
            string query = "INSERT INTO Students (StudentID, Name, Age, HomeTown, DepartmentID, Department) VALUES (@StudentID, @Name, @Age, @HomeTown, @DepartmentID, @Department)";

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
                        command.Parameters.AddWithValue("@StudentID", studentID);
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Age", age);
                        command.Parameters.AddWithValue("@HomeTown", studentHomeTown);
                        command.Parameters.AddWithValue("@DepartmentID", departmentID);
                        command.Parameters.AddWithValue("@Department", chooseDepartment);

                        // Execute the command
                        command.ExecuteNonQuery();

                        // Notify the user
                        MessageBox.Show("Student information inserted successfully!");
                    }
                }
                catch (Exception ex)
                {
                    // Handle any errors that may have occurred
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            InsertStudentInformation();
        }
    }
}
