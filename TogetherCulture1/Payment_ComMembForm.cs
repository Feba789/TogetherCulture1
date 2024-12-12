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
    public partial class Payment_ComMembForm : Form
    {
        public Payment_ComMembForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Payment1_closeButton_Click(object sender, EventArgs e)
        {
            ComMembBenefitsForm cbForm = new ComMembBenefitsForm();
            cbForm.Show();
            this.Close();
        }

        private void Payment1_closeButton_MouseEnter(object sender, EventArgs e)
        {
            Payment1_closeButton.ForeColor = Color.Gray;
        }

        private void Payment1_closeButton_MouseLeave(object sender, EventArgs e)
        {
            Payment1_closeButton.ForeColor = Color.Black;
        }

        private void PaymentButton1_Click(object sender, EventArgs e)
        {
            string cardHolderName1 = cardName1.Text.Trim();
            string cardNumber1 = cardNumb1.Text.Trim();
            string expiryMonth1 = mm1.Text.Trim();
            string expiryYear1 = yy1.Text.Trim();
            string CVV1 = cvv1.Text.Trim();

            if (!Regex.IsMatch(cardHolderName1, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Invalid Card Holder Name", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(cardNumber1, @"^\d{16}$"))
            {
                MessageBox.Show("Invalid Card Number", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(expiryMonth1, @"^(0[1-9]|1[0-2])$"))
            {
                MessageBox.Show("Invalid Month", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(expiryYear1, @"^([2-3][4-9]|40)$"))
            {
                MessageBox.Show("Invalid Year", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(CVV1, @"^\d{3}$"))
            {
                MessageBox.Show("Invalid CVV", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Payment Successful", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            memb1PersonalForm mpForm = new memb1PersonalForm();
            mpForm.Show(); 
            this.Close();

        }

        private void cardName1_TextChanged(object sender, EventArgs e)
        {

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
