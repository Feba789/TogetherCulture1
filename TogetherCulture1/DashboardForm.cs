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

namespace TogetherCulture1
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            loadMembCount();
        }

        private void membCountButton_Click(object sender, EventArgs e)
        {    
        }

        private void loadMembCount()
        {

            using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\Documents\logindata.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                connect.Open();
                string query = "SELECT COUNT(*) FROM members";
                SqlCommand cmd = new SqlCommand(query, connect);
                int memberCount = (int)cmd.ExecuteScalar();
                membCountButton.Text = " " + memberCount;
            }
        }

        private void logoutDashPageButton_Click(object sender, EventArgs e)
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
            vform.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GotoMemb_DashPage_Click(object sender, EventArgs e)
        {
            MembForm m4Form = new MembForm();
            m4Form.Show();
            this.Hide();
        }

        private void gotoHome_DashPage_Click(object sender, EventArgs e)
        {
            Form1 homepageForm = new Form1();
            homepageForm.Show();
            this.Hide();
        }

        private void viwMembDetails_Button_MouseEnter(object sender, EventArgs e)
        {
            viwMembDetails_Button.BackColor = Color.DimGray;   
        }

        private void viwMembDetails_Button_MouseLeave(object sender, EventArgs e)
        {
            viwMembDetails_Button.BackColor = Color.DarkSlateGray;
        }

        private void Dashpage_closeButton_Click(object sender, EventArgs e)
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

        private void GotoEvents_DashPage_Click(object sender, EventArgs e)
        {
            Form1 homepageForm = new Form1();
            homepageForm.Show();
            this.Hide();
        }
    }
}
