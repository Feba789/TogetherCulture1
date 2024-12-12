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
using TogetherCulture1;

namespace TogetherCultureApp
{
    public partial class EventPageForm : Form
    {
        private Event currentEvent; 
        private Form1 homePage;
        public EventPageForm(Event selectedEvent, Form1 homePage)
        {
            InitializeComponent();
            currentEvent = selectedEvent;
            this.homePage = homePage;

            LoadEventDetails();
            
        }
        private void LoadEventDetails()
        {
            textBoxEvent.Text = currentEvent.Name;
            textBoxDate.Text = currentEvent.Date.ToShortDateString();
            textBoxLocation.Text = currentEvent.Location;
            textBoxDescription.Text = currentEvent.Description;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            homePage.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EventBookingPage eventBookingPage = new EventBookingPage(currentEvent, homePage);
            eventBookingPage.Show();
            this.Hide();
        }

        private void textBoxLocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEvent_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
