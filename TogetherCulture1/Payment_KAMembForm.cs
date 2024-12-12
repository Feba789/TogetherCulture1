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
            kform.Show();
            this.Close();
        }

        private void Payment2_closeButton_MouseEnter(object sender, EventArgs e)
        {
            Payment2_closeButton.ForeColor = Color.Gray;
        }

        private void Payment2_closeButton_MouseLeave(object sender, EventArgs e)
        {
            Payment2_closeButton.ForeColor = Color.Black;
        }

        private void PaymentButton2_Click(object sender, EventArgs e)
        {
            string cardHolderName2 = cardName2.Text.Trim();
            string cardNumber2 = cardNumb2.Text.Trim();
            string expiryMonth2 = mm2.Text.Trim();
            string expiryYear2 = yy2.Text.Trim();
            string CVV2 = cvv2.Text.Trim();

            if (!Regex.IsMatch(cardHolderName2, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Invalid Card Holder Name", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(cardNumber2, @"^\d{16}$"))
            {
                MessageBox.Show("Invalid Card Number", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(expiryMonth2, @"^(0[1-9]|1[0-2])$"))
            {
                MessageBox.Show("Invalid Month", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(expiryYear2, @"^([2-3][4-9]|40)$"))
            {
                MessageBox.Show("Invalid Year", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(CVV2, @"^\d{3}$"))
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
