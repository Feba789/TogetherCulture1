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
//// form by student ID 2243328 ////

namespace TogetherCulture1
{
    public partial class Payment_WorkMembForm : Form
    {
        public Payment_WorkMembForm()
        {
            InitializeComponent();
        }

        private void Payment3_closeButton_Click(object sender, EventArgs e)
        {
            WorkMembBenefitsForm wbform = new WorkMembBenefitsForm();
            wbform.Show(); // Open the workspace Membership Benefits Form.
            this.Close();
        }

        private void Payment3_closeButton_MouseEnter(object sender, EventArgs e)
        {
            Payment3_closeButton.ForeColor = Color.Gray; //Changes the close button text color to gray when the mouse hovers over it.
        }

        private void Payment3_closeButton_MouseLeave(object sender, EventArgs e)
        {
            Payment3_closeButton.ForeColor = Color.Black; //Changes the close button text color to black when the mouse hovers over it.
        }

        private void PaymentButton3_Click(object sender, EventArgs e)
        {
            string cardHolderName3 = cardName3.Text.Trim();
            string cardNumber3 = cardNumb3.Text.Trim();
            string expiryMonth3 = mm3.Text.Trim();
            string expiryYear3 = yy3.Text.Trim();
            string CVV3 = cvv3.Text.Trim();
            // Retrieve input values from text fields.

            if (!Regex.IsMatch(cardHolderName3, @"^[a-zA-Z\s]+$"))
            // Validate Card Holder Name: Only letters and spaces are allowed.
            {
                MessageBox.Show("Invalid Card Holder Name", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(cardNumber3, @"^\d{16}$"))
            // Validate Card Number: Must be a 16-digit number.
            {
                MessageBox.Show("Invalid Card Number", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(expiryMonth3, @"^(0[1-9]|1[0-2])$"))
            // Validate Expiry Month: Must be in the format 01-12.
            {
                MessageBox.Show("Invalid Month", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(expiryYear3, @"^([2-3][4-9]|40)$"))
            // Validate Expiry Year: Accepts years between 2024 and 2040 (last two digits).
            {
                MessageBox.Show("Invalid Year", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(CVV3, @"^\d{3}$"))
            // Validate CVV: Must be a 3-digit number.
            {
                MessageBox.Show("Invalid CVV", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Payment Successful", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // If all validations pass, show a success message.

            memb1PersonalForm mpForm = new memb1PersonalForm();
            mpForm.Show(); // Open the Personal Membership Form.
            this.Close();
        }

        Point lastpoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        // Enables dragging the form using the mouse.
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

        private void cardName3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
