using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TogetherCultureApp;
////Form By STUDENT ID 2243328 /////

namespace TogetherCulture1
{
    public partial class MembForm : Form
    {
        public MembForm()
        {
            InitializeComponent();
        }

      

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void logoutMembPageButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you want to Logout?","Logout Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            // Displays a confirmation dialog. If the user confirms, it logs out by switching to the LoginForm.

            if (result == DialogResult.Yes)
            {
                
                LoginForm lForm = new LoginForm();
                lForm.Show(); // Show the login form.
                this.Hide(); // Hide the current form
            }
            else
            {
                
            }
            
        }

        private void memb1_GotoButton_Click(object sender, EventArgs e)
        {
            ComMembBenefitsForm benefits1Form = new ComMembBenefitsForm();
            benefits1Form.Show();   // Open the Community Benefits form.
            this.Close();
        }

        private void memb2_GotoButton_Click(object sender, EventArgs e)
        {
            KA_MembBenefitsForm benefits2Form = new KA_MembBenefitsForm();
            benefits2Form.Show(); // Open the Key Access Benefits form.
            this.Close();
        }

        private void memb3_GotoButton_Click(object sender, EventArgs e)
        {
            WorkMembBenefitsForm benefits3Form = new WorkMembBenefitsForm();
            benefits3Form.Show(); // Open the Workspace Benefits form.
            this.Close();
        }

       
        

       

    

        private void panel2_MouseEnter(object sender, EventArgs e)
        {

        }

        
        private void membpage_closeButton_Click_1(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you want to Exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Displays a confirmation dialog to exit the application.


            if (result == DialogResult.Yes)
            {


                this.Close();
            }
            else
            {

            }
        }

        private void membpage_closeButton_MouseEnter(object sender, EventArgs e)
        {
            membpage_closeButton.ForeColor = Color.Gray;  // Changes the "Close" button text color to gray when the mouse hovers over it.
        }

        private void membpage_closeButton_MouseLeave(object sender, EventArgs e)
        {
            membpage_closeButton.ForeColor = Color.Black; // Resets the "Close" button text color to black when the mouse leaves.
        }

        private void GotoDash_membPage_Click(object sender, EventArgs e)
        {
            DashboardForm dform = new DashboardForm();
            dform.Show(); // Open the Dashboard.
            this.Hide();
        }

        private void GotoEvents_membPage_Click_1(object sender, EventArgs e)
        {
            Form1 homepageForm = new Form1();
            homepageForm.Show(); // Open the Homepage.
            this.Hide();
        }

        private void GotoDash_membPage_MouseEnter_1(object sender, EventArgs e)
        {
            GotoDash_membPage.ForeColor= Color.Gray; // Changes the "Dashboard" button text color to gray when the mouse hovers over it.
        }

        private void GotoDash_membPage_MouseLeave_1(object sender, EventArgs e)
        {
            GotoDash_membPage.ForeColor = Color.Black; // Resets the "Dashboard" button text color to black when the mouse leaves.
        }

        private void GotoEvents_membPage_MouseEnter_1(object sender, EventArgs e)
        {
            GotoEvents_membPage.ForeColor = Color.Gray; // Changes the "Events" button text color to gray when the mouse hovers over it.
        }

        private void GotoEvents_membPage_MouseLeave_1(object sender, EventArgs e)
        {
            GotoEvents_membPage.ForeColor = Color.Black; // Resets the "Events" button text color to black when the mouse leaves.
        }

        private void gotoHome_membPage_MouseEnter_1(object sender, EventArgs e)
        {
            gotoHome_membPage.ForeColor = Color.Gray;   // Changes the "Home" button text color to gray when the mouse hovers over it.
        }

        private void gotoHome_membPage_MouseLeave_1(object sender, EventArgs e)
        {
            gotoHome_membPage.ForeColor = Color.Black; // Resets the "Home" button text color to black when the mouse leaves.
        }

        private void gotoHome_membPage_Click_1(object sender, EventArgs e)
        {
            Form1 homepageForm = new Form1();
            homepageForm.Show(); // Open the Homepage.
            this.Hide();
        }

        Point lastpoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        // Allows the user to drag the Membership Form using a mouse on the panel.
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

        private void logoutMembPageButton_Click_1(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you want to Logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                LoginForm lForm = new LoginForm();
                lForm.Show();
                this.Hide(); // Hide the current form
            }
            else
            {

            }
        }
    }
}
