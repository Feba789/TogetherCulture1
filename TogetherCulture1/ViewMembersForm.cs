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

namespace TogetherCulture1
{
    public partial class ViewMembersForm : Form
    {
        private DataTable membersTable;
        public ViewMembersForm()
        {
            InitializeComponent();
            LoadViewMembers();
        }
        private void LoadViewMembers()
        {
            using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\Documents\LoginData.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False"))
            {
                connect.Open();
                string query = "SELECT * FROM members";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
                 membersTable = new DataTable();
                adapter.Fill(membersTable);
                dataGridViewMemb.DataSource = membersTable;
            }
        }

        private void Save_viewMembPage_Click(object sender, EventArgs e)
        {

            using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\Documents\logindata.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                connect.Open();

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM members", connect);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                adapter.Update(membersTable);
                MessageBox.Show("Changes saved successfully!");

                LoadViewMembers();
            }
        }

            private void ViewMembersForm_Load(object sender, EventArgs e)
        {

        }

        private void Viewmembpage_closeButton_Click(object sender, EventArgs e)
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

        private void GobackDash_Button_Click(object sender, EventArgs e)
        {
            DashboardForm dhform = new DashboardForm();
            dhform.Show();
            this.Hide();
        }


        private void Edit_viewMembPage_Click(object sender, EventArgs e)
        {
            dataGridViewMemb.ReadOnly = false;
        }

        private void Remove_ViewMembPage_Click(object sender, EventArgs e)
        {
            if (dataGridViewMemb.SelectedRows.Count > 0)
            {
                
                DialogResult result = MessageBox.Show("Do you want to remove this member?", "Confirm Remove", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Lenovo\Documents\LoginData.mdf; Integrated Security = True; Connect Timeout = 30; Encrypt = False"))
                    {
                        connect.Open();

                       
                        int selectedRowIndex = dataGridViewMemb.SelectedRows[0].Index;
                        int memberId = Convert.ToInt32(dataGridViewMemb.Rows[selectedRowIndex].Cells["id"].Value);

                        
                        string deleteQuery = "DELETE FROM members WHERE id = @MemberId";
                        SqlCommand cmd = new SqlCommand(deleteQuery, connect);
                        cmd.Parameters.AddWithValue("@MemberId", memberId);
                        cmd.ExecuteNonQuery();

                        
                        dataGridViewMemb.Rows.RemoveAt(selectedRowIndex);

                        MessageBox.Show("Member removed successfully!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a member to remove.");
            }
        }

        private void Viewmembpage_closeButton_MouseEnter(object sender, EventArgs e)
        {
            Viewmembpage_closeButton.ForeColor = Color.Gray;
        }

        private void Viewmembpage_closeButton_MouseLeave(object sender, EventArgs e)
        {
            Viewmembpage_closeButton.ForeColor = Color.Black;
               ;
        }

        Point lastpoint;
        private void ViewMembersForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void ViewMembersForm_MouseEnter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

       
        
}
    

