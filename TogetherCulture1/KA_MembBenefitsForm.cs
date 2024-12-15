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
// fORM BY STUDENT id 2243328

namespace TogetherCulture1
{
    public partial class KA_MembBenefitsForm : Form
    {
        public KA_MembBenefitsForm()
        {
            InitializeComponent();
        }

        private void GotoHome_memb2Page_Click(object sender, EventArgs e)
        {
            Form1 homepageForm = new Form1();
            homepageForm.Show();
            this.Hide();
        }

        private void Gotomemb_memb2Page_Click(object sender, EventArgs e)
        {
            MembForm mform = new MembForm();
            mform.Show();
            this.Close();
        }

        private void logoutKAPageButton_Click(object sender, EventArgs e)
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

        private void memb2page_closeButton_Click(object sender, EventArgs e)
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

        private void Sub_KAPageButton_Click(object sender, EventArgs e)
        {
            Payment_KAMembForm p2Form = new Payment_KAMembForm();
            p2Form.Show();
            this.Close();
        }

        private void panel4_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void GotoHome_memb2Page_MouseEnter(object sender, EventArgs e)
        {
            GotoHome_memb2Page.ForeColor = Color.Gray;
        }

        private void GotoHome_memb2Page_MouseLeave(object sender, EventArgs e)
        {
            GotoHome_memb2Page.ForeColor = Color.Black;
        }

        private void Gotomemb_memb2Page_MouseEnter(object sender, EventArgs e)
        {
            Gotomemb_memb2Page.ForeColor = Color.Gray;
        }

        private void Gotomemb_memb2Page_MouseLeave(object sender, EventArgs e)
        {
            Gotomemb_memb2Page.ForeColor = Color.Black;
        }

        private void GotoEvents_memb2Page_MouseEnter(object sender, EventArgs e)
        {
            GotoEvents_memb2Page.ForeColor = Color.Gray;
        }

        private void GotoEvents_memb2Page_MouseLeave(object sender, EventArgs e)
        {
            GotoEvents_memb2Page.ForeColor = Color.Black;
        }

        private void GotoDash_memb2Page_MouseEnter(object sender, EventArgs e)
        {
            GotoDash_memb2Page.ForeColor = Color.Gray;
        }

        private void GotoDash_memb2Page_MouseLeave(object sender, EventArgs e)
        {
            GotoDash_memb2Page.ForeColor = Color.Black;
        }

        private void memb2page_closeButton_MouseLeave(object sender, EventArgs e)
        {
            memb2page_closeButton.ForeColor = Color.Black;
        }

        private void memb2page_closeButton_MouseEnter(object sender, EventArgs e)
        {
            memb2page_closeButton.ForeColor = Color.Gray;
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

        private void GotoEvents_memb2Page_Click(object sender, EventArgs e)
        {
            Form1 homepageForm = new Form1();
            homepageForm.Show();
            this.Hide();
        }
    }
}
