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
            wbform.Show();
            this.Close();
        }

        private void Payment3_closeButton_MouseEnter(object sender, EventArgs e)
        {
            Payment3_closeButton.ForeColor = Color.Gray;
        }

        private void Payment3_closeButton_MouseLeave(object sender, EventArgs e)
        {
            Payment3_closeButton.ForeColor = Color.Black;
        }

        private void PaymentButton3_Click(object sender, EventArgs e)
        {
            string cardHolderName3 = cardName3.Text.Trim();
            string cardNumber3 = cardNumb3.Text.Trim();
            string expiryMonth3 = mm3.Text.Trim();
            string expiryYear3 = yy3.Text.Trim();
            string CVV3 = cvv3.Text.Trim();

            if (!Regex.IsMatch(cardHolderName3, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Invalid Card Holder Name", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(cardNumber3, @"^\d{16}$"))
            {
                MessageBox.Show("Invalid Card Number", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(expiryMonth3, @"^(0[1-9]|1[0-2])$"))
            {
                MessageBox.Show("Invalid Month", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(expiryYear3, @"^([2-3][4-9]|40)$"))
            {
                MessageBox.Show("Invalid Year", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(CVV3, @"^\d{3}$"))
            {
                MessageBox.Show("Invalid CVV", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Payment Successful", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            memb1PersonalForm mpForm = new memb1PersonalForm();
            mpForm.Show();
            this.Close();
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
