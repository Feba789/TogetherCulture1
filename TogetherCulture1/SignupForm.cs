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
            LoginForm lForm = new LoginForm();
            lForm.Show();
            this.Hide();
        }

        private void create_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (create_showpass.Checked)
            {
                create_passField.PasswordChar = '\0';
            }
            else
            {
                create_passField.PasswordChar = '*';
            }
        }

        private void confirm_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (confirm_showpass.Checked)
            {
                confirm_passField.PasswordChar = '\0';
            }
            else
            {
                confirm_passField.PasswordChar = '*';
            }
        }

        private void SignupButton_Click(object sender, EventArgs e)
        {
            if(signup_emailField.Text == "" || create_passField.Text == "" || confirm_passField.Text == "")
            {
                MessageBox.Show("Please fill all the fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string email = signup_emailField.Text;
            string password = create_passField.Text;
            string confirmPassword = confirm_passField.Text;

            if (!email.Contains("@") || !email.EndsWith(".com"))
            {
                MessageBox.Show("Invalid email format. Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\Documents\LoginData.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False"))


            {
                try
                {
                    connect.Open();
                    String checkEmail = "SELECT * FROM users WHERE email = @Email";
                    //admin is the name of table created

                    using (SqlCommand checkUser = new SqlCommand(checkEmail, connect))

                    {
                        checkUser.Parameters.AddWithValue("@Email", signup_emailField.Text);
                        SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            MessageBox.Show(signup_emailField.Text + " already exist", "error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    {
                        string insertData = "INSERT INTO users (email, passwrd, profile_created) VALUES(@email, @passwrd , @date)";


                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {
                            DateTime date = DateTime.Today;

                            cmd.Parameters.AddWithValue("@email", signup_emailField.Text.Trim());
                            cmd.Parameters.AddWithValue("@passwrd", create_passField.Text.Trim());
                            cmd.Parameters.AddWithValue("@date", date);

                            cmd.ExecuteNonQuery();

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
                }
                finally
                {
                    connect.Close();
                }
            }
                    
        }



           
        

        private void gotoLoginButton_MouseEnter(object sender, EventArgs e)
        {
            gotoLoginButton.ForeColor = Color.Gray;
        }

        private void gotoLoginButton_MouseLeave(object sender, EventArgs e)
        {
            gotoLoginButton.ForeColor = Color.Black;
        }

        private void signup_closeButton_MouseEnter(object sender, EventArgs e)
        {
            signup_closeButton.ForeColor = Color.Gray;
        }

        private void signup_closeButton_MouseLeave(object sender, EventArgs e)
        {
            signup_closeButton.ForeColor = Color.Black;
        }

        private void signup_emailField_TextChanged(object sender, EventArgs e)
        {

        }
        Point lastpoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }
    }
}
    
