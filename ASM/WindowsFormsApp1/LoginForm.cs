using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
                
        }
        private void ValidateUserCredentials()
        {

            string connectionString = "Server=MSI;Database=ThucTap;User Id=MyLogin;Password=MyPassword;";



            string username = txtUsername.Text;
            string password = txtPassword.Text;


            string query = "SELECT COUNT(1) FROM Users WHERE Username = @Username AND Password = @Password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                   
                    connection.Open();

                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                       
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        
                        int count = (int)command.ExecuteScalar();

                        if (count == 1)
                        {
                            
                            MessageBox.Show("Login successful!");
                           
                        }
                        else
                        {
                            
                            MessageBox.Show("Invalid username or password.");
                        }
                    }
                }
                catch (Exception ex)
                {
                  
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            ValidateUserCredentials();
        }
    }
}
