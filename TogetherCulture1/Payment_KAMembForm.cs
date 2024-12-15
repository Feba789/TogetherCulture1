using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
//// form by student id 2243328 ////

namespace TogetherCulture1
{
    public partial class Payment_KAMembForm : Form
    {
        public Payment_KAMembForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Payment2_closeButton_Click(object sender, EventArgs e)
        {
            KA_MembBenefitsForm kform = new KA_MembBenefitsForm();
            kform.Show(); // Open the key access Membership Benefits Form.
            this.Close();
        }

        private void Payment2_closeButton_MouseEnter(object sender, EventArgs e)
        {
            Payment2_closeButton.ForeColor = Color.Gray; //Changes the close button text color to gray when the mouse hovers over it.
        }

        private void Payment2_closeButton_MouseLeave(object sender, EventArgs e)
        {
            Payment2_closeButton.ForeColor = Color.Black; //Changes the close button text color to black when the mouse hovers over it.
        }

        private void PaymentButton2_Click(object sender, EventArgs e)
        //Handles the payment process when the "Payment" button is clicked.
        {
            string cardHolderName2 = cardName2.Text.Trim();
            string cardNumber2 = cardNumb2.Text.Trim();
            string expiryMonth2 = mm2.Text.Trim();
            string expiryYear2 = yy2.Text.Trim();
            string CVV2 = cvv2.Text.Trim();
            // Retrieve input values from text fields.

            if (!Regex.IsMatch(cardHolderName2, @"^[a-zA-Z\s]+$"))
            // Validate Card Holder Name: Only letters and spaces are allowed.
            {
                MessageBox.Show("Invalid Card Holder Name", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(cardNumber2, @"^\d{16}$"))
            // Validate Card Number: Must be a 16-digit number.
            {
                MessageBox.Show("Invalid Card Number", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(expiryMonth2, @"^(0[1-9]|1[0-2])$"))
            // Validate Expiry Month: Must be in the format 01-12.
            {
                MessageBox.Show("Invalid Month", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(expiryYear2, @"^([2-3][4-9]|40)$"))
            // Validate Expiry Year: Accepts years between 2024 and 2040 (last two digits).
            {
                MessageBox.Show("Invalid Year", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(CVV2, @"^\d{3}$"))
            // Validate CVV: Must be a 3-digit number.
            {
                MessageBox.Show("Invalid CVV", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error); // If all validations pass, show a success message
                return;
            }

            MessageBox.Show("Payment Successful", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // If all validations pass,

            memb1PersonalForm mpForm = new memb1PersonalForm();
            mpForm.Show();
            this.Close();
        }

        Point lastpoint; // Enables dragging the form using the mouse.
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        // Captures the initial mouse position when dragging starts.
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void cardName2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
