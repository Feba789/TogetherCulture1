using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            HomepageForm hpform = new HomepageForm();
            hpform.Show();
            this.Close();
        }

        private void gotomemb_memb1Page_Click(object sender, EventArgs e)
        {
            MembForm mform = new MembForm();
            mform.Show();
            this.Close();   
        }

        private void logoutComPageButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you want to Logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                LoginForm lForm = new LoginForm();
                lForm.Show();
                this.Hide(); 
            }
            else
            {

            }
        }

        private void memb1page_closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Sub_ComPageButton_Click(object sender, EventArgs e)
        {
            Payment_ComMembForm p1Form = new Payment_ComMembForm();
            p1Form.Show();  
            this.Close();
        }

        private void GotoHome_memb1Page_MouseEnter(object sender, EventArgs e)
        {
            GotoHome_memb1Page.ForeColor = Color.Gray;
        }

        private void GotoHome_memb1Page_MouseLeave(object sender, EventArgs e)
        {
            GotoHome_memb1Page.ForeColor = Color.Black;
        }

        private void gotomemb_memb1Page_MouseEnter(object sender, EventArgs e)
        {
            gotomemb_memb1Page.ForeColor = Color.Gray;
        }

        private void gotomemb_memb1Page_MouseLeave(object sender, EventArgs e)
        {
            gotomemb_memb1Page.ForeColor = Color.Black;
        }

        private void GotoEvents_memb1Page_MouseEnter(object sender, EventArgs e)
        {
            GotoEvents_memb1Page.ForeColor = Color.Gray;
        }

        private void GotoEvents_memb1Page_MouseLeave(object sender, EventArgs e)
        {
            GotoEvents_memb1Page.ForeColor = Color.Black;
        }

        private void GotoDash_memb1Page_MouseEnter(object sender, EventArgs e)
        {
            GotoDash_memb1Page.ForeColor = Color.Gray;
        }

        private void GotoDash_memb1Page_MouseLeave(object sender, EventArgs e)
        {
            GotoDash_memb1Page.ForeColor = Color.Black;
        }

        private void memb1page_closeButton_MouseEnter(object sender, EventArgs e)
        {
            memb1page_closeButton.ForeColor = Color.Gray;   

        }

        private void memb1page_closeButton_MouseLeave(object sender, EventArgs e)
        {
            memb1page_closeButton.ForeColor = Color.Black;
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
