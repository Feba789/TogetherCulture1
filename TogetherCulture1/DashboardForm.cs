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
using TogetherCultureApp;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;
//// form by studet ID 2243328 //// 
//// THIS IS A ADMIN DASHBOARD FORM /////

namespace TogetherCulture1
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            loadMembCount(); // Load the total number of members into the button text.
        }

        private void membCountButton_Click(object sender, EventArgs e)
        {    
        }

        private void loadMembCount() // Method to load and display the total number of members from the database.
        {

            using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\Documents\LoginData.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False"))
            // Establish a connection to the database.

            {
                connect.Open(); // Open the connection.
                string query = "SELECT COUNT(*) FROM members"; // SQL query to count the number of members.
                SqlCommand cmd = new SqlCommand(query, connect);
                int memberCount = (int)cmd.ExecuteScalar();  // Execute the query and fetch the count.
                membCountButton.Text = " " + memberCount; // Update the button text with the member count.
            }
        }

        private void logoutDashPageButton_Click(object sender, EventArgs e)
        //Logs the user out and redirects to the LoginForm.
        {
            var result = MessageBox.Show("Do you want to Logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                LoginForm lForm = new LoginForm();
                lForm.Show(); // Open the login form 
                this.Hide(); // Hide the current form
            }
            else
            {

            }
        }

        private void gotoHome_DashPage_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void gotoHome_DashPage_MouseLeave(object sender, EventArgs e)
        {

        }

        private void GotoMemb_DashPage_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void GotoMemb_DashPage_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void GotoEvents_DashPage_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void GotoEvents_DashPage_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void Dashpage_closeButton_MouseEnter(object sender, EventArgs e)
        { 
        
        }

        private void Dashpage_closeButton_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void viwMembDetails_Button_Click(object sender, EventArgs e)
        {
            ViewMembersForm vform = new ViewMembersForm();
            vform.Show(); // Open the ViewMembersForm.
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GotoMemb_DashPage_Click(object sender, EventArgs e)
        {
            MembForm m4Form = new MembForm();
            m4Form.Show(); // Open the Membersip Form.
            this.Hide();
        }

        private void gotoHome_DashPage_Click(object sender, EventArgs e)
        {
            Form1 homepageForm = new Form1();
            homepageForm.Show(); // Open the homepage form.
            this.Hide();
        }

        private void viwMembDetails_Button_MouseEnter(object sender, EventArgs e)
        {
            viwMembDetails_Button.BackColor = Color.DimGray; // Change button color on mouse enter.
        }

        private void viwMembDetails_Button_MouseLeave(object sender, EventArgs e)
        {
            viwMembDetails_Button.BackColor = Color.DarkSlateGray; // Restore button color on mouse leave.
        }

        private void Dashpage_closeButton_Click(object sender, EventArgs e)
           // Closes the application with a confirmation prompt.
        {
            var result = MessageBox.Show("Do you want to Exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {


                this.Close();
            }
            else
            {

            }
        }

        Point lastpoint;
        // Enables dragging the form using the mouse.
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        // Captures the initial mouse position for dragging.
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void GotoEvents_DashPage_Click(object sender, EventArgs e)
        {
            Form1 homepageForm = new Form1(); //open homepage and then connect to events page
            homepageForm.Show();
            this.Hide();
        }
    }
}
