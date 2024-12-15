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
//// FORM BY STUDENT ID 2243328 ////

namespace TogetherCulture1
{
    public partial class ViewMembersForm : Form
    {
        private DataTable membersTable; // DataTable to hold member data for display and manipulation.
        public ViewMembersForm()
        {
            InitializeComponent();
            LoadViewMembers(); // Load member data into the DataGridView on form initialization.
        }
        private void LoadViewMembers()
        // Method to load member data from the database and display it in the DataGridView.
        {
            using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\Documents\LoginData.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False"))
            // Establish a database connection.
            {
                connect.Open(); // Open the database connection.

                string query = "SELECT * FROM members"; // Query to fetch all member records.

                SqlDataAdapter adapter = new SqlDataAdapter(query, connect);// Use SqlDataAdapter to fill the DataTable with the results of the query.
                
                membersTable = new DataTable();
                adapter.Fill(membersTable);

                dataGridViewMemb.DataSource = membersTable; // Bind the DataTable to the DataGridView for display.
            }
        }

        private void Save_viewMembPage_Click(object sender, EventArgs e)
            //Save changes made in the DataGridView back to the database.
        {

            using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\Documents\LoginData.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False"))
            {
                connect.Open(); // Open the database connection.

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM members", connect);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                // SqlDataAdapter and SqlCommandBuilder used to handle update operations.

                adapter.Update(membersTable);
                MessageBox.Show("Changes saved successfully!");
                // Save changes from the DataTable back to the database.

                LoadViewMembers(); // Reload the updated data to reflect the latest state.
            }
        }

            private void ViewMembersForm_Load(object sender, EventArgs e)
        {

        }

        private void Viewmembpage_closeButton_Click(object sender, EventArgs e)
        //Closes the current form with an exit confirmation.
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
            dhform.Show(); //// Open the Dashboard form.
            this.Hide();
        }


        private void Edit_viewMembPage_Click(object sender, EventArgs e)
           // Enables editing in the DataGridView.
        {
            dataGridViewMemb.ReadOnly = false; //// Make the DataGridView editable.
        }

        private void Remove_ViewMembPage_Click(object sender, EventArgs e)
        //Removes the selected member from the database and the DataGridView.
        {
            if (dataGridViewMemb.SelectedRows.Count > 0)
            // Ensure a row is selected before attempting to remove.
            {

                DialogResult result = MessageBox.Show("Do you want to remove this member?", "Confirm Remove", MessageBoxButtons.YesNo);
                // Confirm the removal action.

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Lenovo\Documents\LoginData.mdf; Integrated Security = True; Connect Timeout = 30; Encrypt = False"))
                    {
                        connect.Open();// Open the database connection.


                        int selectedRowIndex = dataGridViewMemb.SelectedRows[0].Index; // Get the ID of the selected member from the DataGridView.
                        int memberId = Convert.ToInt32(dataGridViewMemb.Rows[selectedRowIndex].Cells["id"].Value);

                        
                        string deleteQuery = "DELETE FROM members WHERE id = @MemberId"; // SQL query to delete the member record.
                        SqlCommand cmd = new SqlCommand(deleteQuery, connect);
                        cmd.Parameters.AddWithValue("@MemberId", memberId);
                        cmd.ExecuteNonQuery(); // Execute the delete query.


                        dataGridViewMemb.Rows.RemoveAt(selectedRowIndex);  // Remove the selected row from the DataGridView.

                        MessageBox.Show("Member removed successfully!"); 
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a member to remove."); // Inform the user to select a row if none is selected.
            }
        }

        private void Viewmembpage_closeButton_MouseEnter(object sender, EventArgs e)
        {
            Viewmembpage_closeButton.ForeColor = Color.Gray; // Change color on hover.
        }

        private void Viewmembpage_closeButton_MouseLeave(object sender, EventArgs e)
        {
            Viewmembpage_closeButton.ForeColor = Color.Black;  // Restore color on mouse leave.
            ;
        }

        Point lastpoint; // Stores the last mouse position.
        private void ViewMembersForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void ViewMembersForm_MouseEnter(object sender, EventArgs e)
        // Captures the initial mouse position for dragging.
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

       
        
}
    

