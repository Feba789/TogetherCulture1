using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using TogetherCultureApp;

namespace TogetherCulture1
{
    public partial class EventBookingPage : Form
    {

        private readonly Form1 homePage;
        private readonly Event currentEvent;

        public EventBookingPage()
        {
            InitializeComponent();
        }

        public EventBookingPage(Event currentEvent, Form1 homePage)
        {
            InitializeComponent();
            this.homePage = homePage;
            this.currentEvent = currentEvent;

            textBoxEvent.Text = currentEvent.Name;

            textBoxDate.Text = currentEvent.Date.ToShortDateString(); 

            // Renamed from textBoxDate to textBoxEventDate
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 homepage = new Form1();
            homepage.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(numericUpDown1.Text) || comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all fields before submitting.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Booking Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            this.Close();
            homePage.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEvent_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EventBookingPage_Load(object sender, EventArgs e)
        {

        }
    }
}
