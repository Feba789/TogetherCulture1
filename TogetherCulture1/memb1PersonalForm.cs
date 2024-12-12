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
        {
            if (membFirstName.Text == "" || membSurname.Text == "" || membEmail.Text == "" || membType.Text == "" ||
                membPhone.Text == "" || membCity.Text == "" || membCountry.Text == "" || mGender.Text == "")
            {
                MessageBox.Show("Please fill all the fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string fname = membFirstName.Text;
            string sname = membSurname.Text;
            string phone = membPhone.Text;
            string email = membEmail.Text;
            string membtype = membType.Text;
            string city = membCity.Text;
            string country = membCountry.Text;
            string gender = mGender.Text;
        


            if (!Regex.IsMatch(fname, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Invalid First Name", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.IsMatch(sname, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Invalid Surname", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!email.Contains("@") || !email.EndsWith(".com"))
            {
                MessageBox.Show("Invalid email format. Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Regex.IsMatch(phone, @"^\d{10}$"))
            {
                MessageBox.Show("Invalid Phone Number", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.IsMatch(city, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Invalid City Name", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.IsMatch(fname, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Invalid Country", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\Documents\logindata.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                try
                {


                    connect.Open();
                    String checkEmail = "SELECT * FROM members WHERE email = @Email";

                    using (SqlCommand checkUser = new SqlCommand(checkEmail, connect))

                    {
                        checkUser.Parameters.AddWithValue("@Email", membEmail.Text);
                        SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            MessageBox.Show(membEmail.Text + " already exist", "error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    {
                        String insertData = "INSERT INTO members (first_name, surname, email, membership_type, phone,city, country, gender, profile_created) VALUES(@first_name, @surname, @email, @membership_type, @phone , @city , @country , @gender ,@date)";


                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {
                            DateTime date = DateTime.Today;

                            cmd.Parameters.AddWithValue("@first_name", membFirstName.Text.Trim());
                            cmd.Parameters.AddWithValue("@surname", membSurname.Text.Trim());
                            cmd.Parameters.AddWithValue("@phone", membPhone.Text.Trim());
                            cmd.Parameters.AddWithValue("@email", membEmail.Text.Trim());
                            cmd.Parameters.AddWithValue("@membership_type", membType.Text.Trim());
                            cmd.Parameters.AddWithValue("@city", membCity.Text.Trim());
                            cmd.Parameters.AddWithValue("@country", membCountry.Text.Trim());
                            cmd.Parameters.AddWithValue("@gender", mGender.Text.Trim());
                            cmd.Parameters.AddWithValue("@date", date);

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Submitted", " Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void label9_Click(object sender, EventArgs e)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}