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
using static System.Net.Mime.MediaTypeNames;
//// FORM BY STUDENT ID 2243328 ////

namespace TogetherCulture1
{
    public partial class ComMembBenefitsForm : Form
    {
        public ComMembBenefitsForm()
        {
            InitializeComponent();
        }

        private void GotoHome_memb1Page_Click(object sender, EventArgs e)
        {
            
           Form1 fform = new Form1();
            fform.Show(); // Open homepage
            this.Hide(); //hide current page
        }

        private void gotomemb_memb1Page_Click(object sender, EventArgs e)
        {
            MembForm mform = new MembForm();
            mform.Show(); //go back to membership page
            this.Close();   // close the current page
        }

        private void logoutComPageButton_Click(object sender, EventArgs e)
        //Logs out the user when the Logout button is clicked.
        {
            var result = MessageBox.Show("Do you want to Logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                LoginForm lForm = new LoginForm();
                lForm.Show(); //open the login form
                this.Hide(); 
            }
            else
            {

            }
        }

        private void memb1page_closeButton_Click(object sender, EventArgs e)
        {
            this.Close(); //close the current form 
        }

        private void Sub_ComPageButton_Click(object sender, EventArgs e)
            // Navigates to the Payment Form for Community Membership when the "Subscribe" button is clicked.
        {
            Payment_ComMembForm p1Form = new Payment_ComMembForm();
            p1Form.Show();  
            this.Close();
        }

        private void GotoHome_memb1Page_MouseEnter(object sender, EventArgs e)
            //Changes the text color of "Go to Home" button to gray when the mouse hovers over it.
        {
            GotoHome_memb1Page.ForeColor = Color.Gray;
        }

        private void GotoHome_memb1Page_MouseLeave(object sender, EventArgs e)
        {
            GotoHome_memb1Page.ForeColor = Color.Black; //Changes the text color of " Home" button to blsck when the mouse hovers over it.
        }

        private void gotomemb_memb1Page_MouseEnter(object sender, EventArgs e)
        {
            gotomemb_memb1Page.ForeColor = Color.Gray; //Changes the text color of "membership" button to gray when the mouse hovers over it.
        }

        private void gotomemb_memb1Page_MouseLeave(object sender, EventArgs e)
        {
            gotomemb_memb1Page.ForeColor = Color.Black; //Changes the text color of "memberhsip" button to black when the mouse hovers over it.
        }

        private void GotoEvents_memb1Page_MouseEnter(object sender, EventArgs e)
        {
            GotoEvents_memb1Page.ForeColor = Color.Gray; //Changes the text color of "evennts" button to gray when the mouse hovers over it.
        }

        private void GotoEvents_memb1Page_MouseLeave(object sender, EventArgs e)
        {
            GotoEvents_memb1Page.ForeColor = Color.Black; //Changes the text color of "events" button to black when the mouse hovers over it.
        }

        private void GotoDash_memb1Page_MouseEnter(object sender, EventArgs e)
        {
            GotoDash_memb1Page.ForeColor = Color.Gray; //Changes the text color of "Dashboard" button to gray when the mouse hovers over it.
        }

        private void GotoDash_memb1Page_MouseLeave(object sender, EventArgs e)
        {
            GotoDash_memb1Page.ForeColor = Color.Black; //Changes the text color of "Dashboard" button to black when the mouse hovers over it.
        }

        private void memb1page_closeButton_MouseEnter(object sender, EventArgs e)
        {
            memb1page_closeButton.ForeColor = Color.Gray;   //Changes the text color of "close" button to gray when the mouse hovers over it.

        }

        private void memb1page_closeButton_MouseLeave(object sender, EventArgs e)
        {
            memb1page_closeButton.ForeColor = Color.Black; //Changes the text color of "close" button to black when the mouse hovers over it.
        }

        Point lastpoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        //// Enables the dragging of the form using the panel with the mouse.
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        // Captures the mouse position when the drag starts.
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
