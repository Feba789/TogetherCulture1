using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TogetherCulture1;

namespace TogetherCultureApp
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            LoadEvents();     // Load sample event data
            SetupListView();

        }
        private List<Event> events; // List to store events

        private void LoadEvents()
        {
            events = new List<Event>
    {
        new Event("Community Meetup", new DateTime(2025, 12, 1), "Main Hall", "A meetup to connect with the community."),
        new Event("Creative Leadership Workshop", new DateTime(2024, 12, 5), "Room A", "Learn creative leadership skills."),
        new Event("Networking Night", new DateTime(2025, 12, 10), "Lobby", "An opportunity to expand your network."),
        new Event("Holiday Gala", new DateTime(2025, 12, 20), "Grand Ballroom", "Celebrate the holiday season with the community.")
    };
        }
        private void SetupListView()
        {
            // Set ListView properties
            listView1.View = View.Details;  // Set to Details view
            listView1.FullRowSelect = true; // Allow full row selection
            listView1.GridLines = true;     // Add gridlines for clarity

            // Add columns to ListView (if not already added in the designer)
            listView1.Columns.Add("Event Name", 180);
            listView1.Columns.Add("Date", 70);
            listView1.Columns.Add("Location", 100);

            // Add events to the ListView
            foreach (var ev in events)
            {
                // Create a new ListViewItem
                ListViewItem item = new ListViewItem(ev.Name);  // Add Event Name
                item.SubItems.Add(ev.Date.ToShortDateString()); // Add Event Date
                item.SubItems.Add(ev.Location);                // Add Event Location
                listView1.Items.Add(item);                     // Add the item to the ListView
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UserProfileForm f2 = new UserProfileForm(this);
            f2.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int selectedIndex = listView1.SelectedItems[0].Index;
                Event selectedEvent = events[selectedIndex];

                // Open Event Page Form with the selected event
                EventPageForm f3 = new EventPageForm(selectedEvent, this);
                f3.Show();

            }
            else
            {
                MessageBox.Show("Please select an event to view.");
            }
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int selectedIndex = listView1.SelectedItems[0].Index;
                Event selectedEvent = events[selectedIndex];

                // Open Event Details Form
                EventPageForm detailsForm = new EventPageForm(selectedEvent, this);
                detailsForm.Show(); // Corrected the variable name to 'detailsForm'
                this.Hide(); // Show the details form as a modal dialog
            }
            else
            {
                MessageBox.Show("Please select an event to view details.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DashboardForm dhform = new DashboardForm();
            dhform.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MembForm mform = new MembForm();
            mform.Show();
            this.Hide();
        }
    }

    
}
