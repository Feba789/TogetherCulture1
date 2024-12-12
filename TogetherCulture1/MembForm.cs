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

        private void memb1_GotoButton_Click(object sender, EventArgs e)
        {
            ComMembBenefitsForm benefits1Form = new ComMembBenefitsForm();
            benefits1Form.Show();   
            this.Close();
        }

        private void memb2_GotoButton_Click(object sender, EventArgs e)
        {
            KA_MembBenefitsForm benefits2Form = new KA_MembBenefitsForm();
            benefits2Form.Show();
            this.Close();
        }

        private void memb3_GotoButton_Click(object sender, EventArgs e)
        {
            WorkMembBenefitsForm benefits3Form = new WorkMembBenefitsForm();
            benefits3Form.Show();
            this.Close();
        }

       
        

       

    

        private void panel2_MouseEnter(object sender, EventArgs e)
        {

        }

        
        private void membpage_closeButton_Click_1(object sender, EventArgs e)
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

        private void membpage_closeButton_MouseEnter(object sender, EventArgs e)
        {
            membpage_closeButton.ForeColor = Color.Gray;
        }

        private void membpage_closeButton_MouseLeave(object sender, EventArgs e)
        {
            membpage_closeButton.ForeColor = Color.Black;
        }

        private void GotoDash_membPage_Click(object sender, EventArgs e)
        {
            DashboardForm dform = new DashboardForm();
            dform.Show();
            this.Hide();
        }

        private void GotoEvents_membPage_Click_1(object sender, EventArgs e)
        {
            Form1 homepageForm = new Form1();
            homepageForm.Show();
            this.Hide();
        }

        private void GotoDash_membPage_MouseEnter_1(object sender, EventArgs e)
        {
            GotoDash_membPage.ForeColor= Color.Gray;
        }

        private void GotoDash_membPage_MouseLeave_1(object sender, EventArgs e)
        {
            GotoDash_membPage.ForeColor = Color.Black;
        }

        private void GotoEvents_membPage_MouseEnter_1(object sender, EventArgs e)
        {
            GotoEvents_membPage.ForeColor = Color.Gray;
        }

        private void GotoEvents_membPage_MouseLeave_1(object sender, EventArgs e)
        {
            GotoEvents_membPage.ForeColor = Color.Black;
        }

        private void gotoHome_membPage_MouseEnter_1(object sender, EventArgs e)
        {
            gotoHome_membPage.ForeColor = Color.Gray;   
        }

        private void gotoHome_membPage_MouseLeave_1(object sender, EventArgs e)
        {
            gotoHome_membPage.ForeColor = Color.Black;
        }

        private void gotoHome_membPage_Click_1(object sender, EventArgs e)
        {
            Form1 homepageForm = new Form1();
            homepageForm.Show();
            this.Hide();
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
