using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Runtime.Remoting.Contexts;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Text.RegularExpressions;
//// FORM BY STUDENT ID 2243328 ////
namespace TogetherCulture1
{
    public partial class SignupForm : Form
    {
       
        public SignupForm()
        {
            InitializeComponent();
        }

        private void confirmPassField_Click(object sender, EventArgs e)
        {

        }
        private void create_passField_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirm_passField_TextChanged(object sender, EventArgs e)
        {

        }
        private void closeButton_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void gotoLoginButton_Click(object sender, EventArgs e)
        {
            LoginForm lForm = new LoginForm(); // Create an instance of LoginForm.
            lForm.Show(); // Display the login form.
            this.Hide(); // Hide the current sign-up form.
        }

        private void create_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (create_showpass.Checked)
            {
                create_passField.PasswordChar = '\0'; // If checkbox is checked, show password.
            }
            else
            {
                create_passField.PasswordChar = '*'; // Otherwise, Hide the password.
            }
        }

        private void confirm_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (confirm_showpass.Checked)
            {
                confirm_passField.PasswordChar = '\0'; // If checkbox is checked, show password.
            }
            else
            {
                confirm_passField.PasswordChar = '*'; // Otherwise, hide the password.
            }
        }

        private void SignupButton_Click(object sender, EventArgs e)
        {
            if(signup_emailField.Text == "" || create_passField.Text == "" || confirm_passField.Text == "")
                //Validate that all required fields are filled.

            {
                MessageBox.Show("Please fill all the fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string email = signup_emailField.Text;
            string password = create_passField.Text;
            string confirmPassword = confirm_passField.Text;

            if (!email.Contains("@") || !email.EndsWith(".com")) // Validate email format.
            {
                MessageBox.Show("Invalid email format. Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password.Length < 6) // Ensure password is at least 6 characters long.
            {
                MessageBox.Show("Password must be at least 6 characters.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != confirmPassword) //Check if password and confirm password fields match.
            {
                MessageBox.Show("Passwords do not match.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\Documents\LoginData.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False"))
            // Connect to the database to validate and insert user information.

            {
                try
                {
                    connect.Open();
                    String checkEmail = "SELECT * FROM users WHERE email = @Email"; // Check if the email already exists in the database.
                    //'users' is the name of table created

                    using (SqlCommand checkUser = new SqlCommand(checkEmail, connect))

                    {
                        checkUser.Parameters.AddWithValue("@Email", signup_emailField.Text);
                        SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            // Display error if the email already exists.
                            MessageBox.Show(signup_emailField.Text + " already exist", "error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    {
                        string insertData = "INSERT INTO users (email, passwrd, profile_created) VALUES(@email, @passwrd , @date)";
                        // Insert new user information into the database.


                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {
                            DateTime date = DateTime.Today; // Get the current date.

                            cmd.Parameters.AddWithValue("@email", signup_emailField.Text.Trim());
                            cmd.Parameters.AddWithValue("@passwrd", create_passField.Text.Trim());
                            cmd.Parameters.AddWithValue("@date", date);

                            cmd.ExecuteNonQuery(); // Execute the insert command.

                            MessageBox.Show("Successfully Created", " Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LoginForm lform = new LoginForm();
                            lform.Show();
                            this.Hide();
                            //WILL SWITCH TO LOGIN FORM


                        }





                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error Connecting : " + ex, "error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Handle exceptions and display error message.
                }
                finally
                {
                    connect.Close(); // Ensure the database connection is closed.
                }
            }
                    
        }



           
        

        private void gotoLoginButton_MouseEnter(object sender, EventArgs e) // Change "Go to Login" button color to gray when mouse hovers over it.
        {
            gotoLoginButton.ForeColor = Color.Gray;
        }

        private void gotoLoginButton_MouseLeave(object sender, EventArgs e) // Revert "Go to Login" button color to black when mouse leaves.
        {
            gotoLoginButton.ForeColor = Color.Black;
        }

        private void signup_closeButton_MouseEnter(object sender, EventArgs e) // Change close button color to gray when mouse hovers over it.
        {
            signup_closeButton.ForeColor = Color.Gray;
        }

        private void signup_closeButton_MouseLeave(object sender, EventArgs e) // Revert close button color to black when mouse leaves.
        {
            signup_closeButton.ForeColor = Color.Black;
        }

        private void signup_emailField_TextChanged(object sender, EventArgs e)
        {

        }
        Point lastpoint; // Allow dragging the form by holding the mouse button on the panel.
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e) // Save the last point when the mouse is pressed on the panel.
        {
            lastpoint = new Point(e.X, e.Y);
        }
    }
}
    
