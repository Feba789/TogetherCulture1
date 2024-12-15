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
using TogetherCultureApp;
using static System.Net.Mime.MediaTypeNames;
//// fORM BY STUDENT ID 2243328 ////


namespace TogetherCulture1
{
    public partial class LoginForm : Form
    {
        
        public LoginForm()
        {
            InitializeComponent();

            this.passField.AutoSize = false;
            this.passField.Size = new Size(this.passField.Size.Width, 27);
            // // Customize password field size

            this.emailField.AutoSize = false;
            this.emailField.Size = new Size(this.emailField.Size.Width, 27);
            //// Customize email field size
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
            //close the application when the close button is clicked.
        }

      

        private void passfield_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameField_TextChanged(object sender, EventArgs e)
        {

        }

       
        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            login_closeButton.ForeColor = Color.Gray;
            // Change close button color to gray when mouse hovers over it.
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            login_closeButton.ForeColor = Color.Black;
            // Revert close button color to black when mouse leaves.
        }



        private void gotoSignupButton_Click(object sender, EventArgs e)
        {
            SignupForm sForm = new SignupForm(); // Create instance of the SignupForm.
            sForm.Show(); // Show sign-up form.
            this.Hide(); // Hide login form.
        }

        private void gotoSignupButton_MouseEnter(object sender, EventArgs e)
        {
            gotoSignupButton.ForeColor = Color.Gray;
            // Change sign-up button color to gray when mouse hovers over it.
        }

        private void gotoSignupButton_MouseLeave(object sender, EventArgs e)
        {
            gotoSignupButton.ForeColor = Color.Black;
            // Revert sign-up button color to black when mouse leaves.
        }


        private void login_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (login_showpass.Checked)
            {
                passField.PasswordChar = '\0';
                // If checkbox is checked, show password.
            }
            else
            {
                passField.PasswordChar = '*'; // Otherwise, Hide password.
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (emailField.Text == "" || passField.Text == "") // Check if email or password fields are empty.
            {
                MessageBox.Show("Please Enter Your User Credentials", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            using(SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\Documents\LoginData.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False"))
            // Establish a connection to the database.
            // String connection given here is mine. 
            // Try to change to "YOUR_STRING_CONNECTON" before run.

            {

                try
                    {
                        connect.Open();

                        String selectDate = "SELECT * FROM users WHERE email = @Email AND passwrd = @pass";  // SQL query to validate user credentials.
                    using (SqlCommand cmd = new SqlCommand(selectDate, connect))
                        {

                            cmd.Parameters.AddWithValue("@Email", emailField.Text);
                            cmd.Parameters.AddWithValue("@pass", passField.Text);
                        // Use parameterized query to prevent SQL injection.

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd); // Execute query.
                        DataTable table = new DataTable(); // Hold results in a DataTable.
                        adapter.Fill(table);

                            if(table.Rows.Count > 0) // If user is found, open the homepage.
                        {
                            Form1 homepage = new Form1();
                            homepage.Show(); // Show the homepage
                            this.Hide(); // Hide login form.
                        }
                            else
                            {
                                MessageBox.Show("Incorrect Username or Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            // Display error if user credentials are incorrect.

                        }

                    }


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error while Connecting: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Handle exceptions and display error message.
                }
                finally
                    {
                        connect.Close();
                    }
                }
            
        }
        
        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        Point lastpoint;
        // Track last point for dragging the window.
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        // Allow dragging the form by holding the mouse button on the panel.

        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        // Save the last point when the mouse is pressed on the panel.

        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
