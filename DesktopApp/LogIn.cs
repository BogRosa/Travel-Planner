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

namespace DesktopApp
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text; 
            AuthenticateUser(username, password);
        }
        private void AuthenticateUser(string username, string password)
        {
            string connectionString = "Server=DESKTOP-J35TMGK; Database=TravelPlannerDB; Integrated Security=True;\r\n"; 
            string hashedPassword = HashPassword(password);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "SELECT Username, Password FROM Admins WHERE Username = @Username AND Password = @Password";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", hashedPassword);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        // User is authenticated
                        // Proceed to the next part of the application
                        this.Hide(); // Assuming this is within a Form class

                        // Show the main admin form
                        Trips trips = new Trips(); 
                        trips.Show();
                    }
                    else
                    {
                        // Authentication failed
                        MessageBox.Show("The username or password is incorrect.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }


        private string HashPassword(string password)
        {
            return password; 
        }

    }
}
