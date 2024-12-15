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
using System.Text.RegularExpressions;
using System.Runtime.Remoting.Contexts;
using System.Xml.Linq;
using TogetherCultureApp;
//// form by student ID 2243328 ////

namespace TogetherCulture1
{
    public partial class memb1PersonalForm : Form
    {
        public memb1PersonalForm()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void membDetailsPageButton_Click(object sender, EventArgs e)
        //Handles the submission of membership details.
        {
            if (membFirstName.Text == "" || membSurname.Text == "" || membEmail.Text == "" || membType.Text == "" ||
                membPhone.Text == "" || membCity.Text == "" || membCountry.Text == "" || mGender.Text == "")
            //// Check if any of the required fields are empty.
            
            {
                MessageBox.Show("Please fill all the fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Exit the function if validation fails.
            }

            string fname = membFirstName.Text;
            string sname = membSurname.Text;
            string phone = membPhone.Text;
            string email = membEmail.Text;
            string membtype = membType.Text;
            string city = membCity.Text;
            string country = membCountry.Text;
            string gender = mGender.Text;
            // Retrieve input values from text fields.



            if (!Regex.IsMatch(fname, @"^[a-zA-Z\s]+$"))
            // Validate First Name: Only letters and spaces are allowed.
            {
                MessageBox.Show("Invalid First Name", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.IsMatch(sname, @"^[a-zA-Z\s]+$"))
            // Validate Surname: Only letters and spaces are allowed.
            {
                MessageBox.Show("Invalid Surname", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!email.Contains("@") || !email.EndsWith(".com"))
            // Validate Email: Must contain "@" and end with ".com".
            {
                MessageBox.Show("Invalid email format. Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Regex.IsMatch(phone, @"^\d{10}$"))
            // Validate Phone Number: Must be exactly 10 digits.

            {
                MessageBox.Show("Invalid Phone Number", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.IsMatch(city, @"^[a-zA-Z\s]+$"))
            // Validate City: Only letters and spaces are allowed.
            {
                MessageBox.Show("Invalid City Name", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.IsMatch(country, @"^[a-zA-Z\s]+$"))
            // Validate Country: Only letters and spaces are allowed.
            {
                MessageBox.Show("Invalid Country", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\Documents\LoginData.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False"))
            // Database connection for inserting membership details.

            {
                try
                {


                    connect.Open(); // Open the database connection.
                    String checkEmail = "SELECT * FROM members WHERE email = @Email";
                    // Query to check if the email already exists in the database.

                    using (SqlCommand checkUser = new SqlCommand(checkEmail, connect))

                    {
                        checkUser.Parameters.AddWithValue("@Email", membEmail.Text);
                        SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count > 0)  // If email already exists, show an error message.
                        {
                            MessageBox.Show(membEmail.Text + " already exist", "error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    {
                        String insertData = "INSERT INTO members (first_name, surname, email, membership_type, phone,city, country, gender, profile_created) VALUES(@first_name, @surname, @email, @membership_type, @phone , @city , @country , @gender ,@date)";
                        // Query to insert the new membership data into the database.


                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {
                            DateTime date = DateTime.Today; // Get the current date.

                            cmd.Parameters.AddWithValue("@first_name", membFirstName.Text.Trim());
                            cmd.Parameters.AddWithValue("@surname", membSurname.Text.Trim());
                            cmd.Parameters.AddWithValue("@phone", membPhone.Text.Trim());
                            cmd.Parameters.AddWithValue("@email", membEmail.Text.Trim());
                            cmd.Parameters.AddWithValue("@membership_type", membType.Text.Trim());
                            cmd.Parameters.AddWithValue("@city", membCity.Text.Trim());
                            cmd.Parameters.AddWithValue("@country", membCountry.Text.Trim());
                            cmd.Parameters.AddWithValue("@gender", mGender.Text.Trim());
                            cmd.Parameters.AddWithValue("@date", date);
                            // Add parameter values to the query.

                            cmd.ExecuteNonQuery(); // Execute the query.

                            MessageBox.Show("Submitted", " Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Show a success message.

                            Form1 homepage = new Form1();

                            // Show the homepage
                            homepage.Show();
                            this.Hide();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Connecting : " + ex, "error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Display an error message in case of exceptions.
                }
                finally
                {
                    connect.Close();
                    // Ensure the database connection is closed.
                }
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        Point lastpoint; // Enables dragging the form using the mouse.
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        // Captures the initial mouse position when dragging starts.
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}