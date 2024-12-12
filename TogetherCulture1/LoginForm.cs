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


namespace TogetherCulture1
{
    public partial class LoginForm : Form
    {
        
        public LoginForm()
        {
            InitializeComponent();

            this.passField.AutoSize = false;
            this.passField.Size = new Size(this.passField.Size.Width, 27);

            this.emailField.AutoSize = false;
            this.emailField.Size = new Size(this.emailField.Size.Width, 27);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
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
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            login_closeButton.ForeColor = Color.Black;
        }



        private void gotoSignupButton_Click(object sender, EventArgs e)
        {
            SignupForm sForm = new SignupForm();
            sForm.Show();
            this.Hide();
        }

        private void gotoSignupButton_MouseEnter(object sender, EventArgs e)
        {
            gotoSignupButton.ForeColor = Color.Gray;
        }

        private void gotoSignupButton_MouseLeave(object sender, EventArgs e)
        {
            gotoSignupButton.ForeColor = Color.Black;
        }


        private void login_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (login_showpass.Checked)
            {
                passField.PasswordChar = '\0';
            }
            else
            {
                passField.PasswordChar = '*';
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (emailField.Text == "" || passField.Text == "")
            {
                MessageBox.Show("Please Enter Your User Credentials", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            using(SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\Documents\logindata.mdf;Integrated Security=True;Connect Timeout=30"))
            
           {
               
                    try
                    {
                        connect.Open();

                        String selectDate = "SELECT * FROM admin WHERE email = @Email AND passwrd = @pass";
                    using (SqlCommand cmd = new SqlCommand(selectDate, connect))
                        {

                        cmd.Parameters.AddWithValue("@Email", emailField.Text);
                       
                            cmd.Parameters.AddWithValue("@pass", passField.Text);
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if(table.Rows.Count > 0)
                            {
                            Form1 homepage = new Form1();

                            // Show the homepage
                            homepage.Show();
                        }
                            else
                            {
                                MessageBox.Show("Incorrect Username or Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error while Connecting: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
