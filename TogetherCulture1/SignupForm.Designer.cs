namespace TogetherCulture1
{
    partial class SignupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignupForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.create_showpass = new System.Windows.Forms.CheckBox();
            this.confirm_passField = new System.Windows.Forms.TextBox();
            this.confirmPassField = new System.Windows.Forms.Label();
            this.confirm_showpass = new System.Windows.Forms.CheckBox();
            this.signup_closeButton = new System.Windows.Forms.Label();
            this.gotoLoginButton = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SignupButton = new System.Windows.Forms.Button();
            this.create_passField = new System.Windows.Forms.TextBox();
            this.createPassField = new System.Windows.Forms.Label();
            this.signup_emailField = new System.Windows.Forms.TextBox();
            this.createEmailField = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.create_showpass);
            this.panel1.Controls.Add(this.confirm_passField);
            this.panel1.Controls.Add(this.confirmPassField);
            this.panel1.Controls.Add(this.confirm_showpass);
            this.panel1.Controls.Add(this.signup_closeButton);
            this.panel1.Controls.Add(this.gotoLoginButton);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.SignupButton);
            this.panel1.Controls.Add(this.create_passField);
            this.panel1.Controls.Add(this.createPassField);
            this.panel1.Controls.Add(this.signup_emailField);
            this.panel1.Controls.Add(this.createEmailField);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1032, 500);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // create_showpass
            // 
            this.create_showpass.AutoSize = true;
            this.create_showpass.Location = new System.Drawing.Point(898, 265);
            this.create_showpass.Name = "create_showpass";
            this.create_showpass.Size = new System.Drawing.Size(125, 20);
            this.create_showpass.TabIndex = 14;
            this.create_showpass.Text = "Show Password";
            this.create_showpass.UseVisualStyleBackColor = true;
            this.create_showpass.CheckedChanged += new System.EventHandler(this.create_showpass_CheckedChanged);
            // 
            // confirm_passField
            // 
            this.confirm_passField.Location = new System.Drawing.Point(604, 308);
            this.confirm_passField.Name = "confirm_passField";
            this.confirm_passField.PasswordChar = '*';
            this.confirm_passField.Size = new System.Drawing.Size(419, 22);
            this.confirm_passField.TabIndex = 13;
            this.confirm_passField.TextChanged += new System.EventHandler(this.confirm_passField_TextChanged);
            // 
            // confirmPassField
            // 
            this.confirmPassField.AutoSize = true;
            this.confirmPassField.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPassField.Location = new System.Drawing.Point(600, 284);
            this.confirmPassField.Name = "confirmPassField";
            this.confirmPassField.Size = new System.Drawing.Size(138, 21);
            this.confirmPassField.TabIndex = 12;
            this.confirmPassField.Text = "Confirm Password";
            this.confirmPassField.Click += new System.EventHandler(this.confirmPassField_Click);
            // 
            // confirm_showpass
            // 
            this.confirm_showpass.AutoSize = true;
            this.confirm_showpass.Location = new System.Drawing.Point(898, 336);
            this.confirm_showpass.Name = "confirm_showpass";
            this.confirm_showpass.Size = new System.Drawing.Size(125, 20);
            this.confirm_showpass.TabIndex = 11;
            this.confirm_showpass.Text = "Show Password";
            this.confirm_showpass.UseVisualStyleBackColor = true;
            this.confirm_showpass.CheckedChanged += new System.EventHandler(this.confirm_showpass_CheckedChanged);
            // 
            // signup_closeButton
            // 
            this.signup_closeButton.AutoSize = true;
            this.signup_closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signup_closeButton.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_closeButton.Location = new System.Drawing.Point(1011, 8);
            this.signup_closeButton.Name = "signup_closeButton";
            this.signup_closeButton.Size = new System.Drawing.Size(16, 18);
            this.signup_closeButton.TabIndex = 10;
            this.signup_closeButton.Text = "X";
            this.signup_closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.signup_closeButton.MouseEnter += new System.EventHandler(this.signup_closeButton_MouseEnter);
            this.signup_closeButton.MouseLeave += new System.EventHandler(this.signup_closeButton_MouseLeave);
            // 
            // gotoLoginButton
            // 
            this.gotoLoginButton.AutoSize = true;
            this.gotoLoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gotoLoginButton.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gotoLoginButton.Location = new System.Drawing.Point(863, 420);
            this.gotoLoginButton.Name = "gotoLoginButton";
            this.gotoLoginButton.Size = new System.Drawing.Size(41, 18);
            this.gotoLoginButton.TabIndex = 9;
            this.gotoLoginButton.Text = "Login";
            this.gotoLoginButton.Click += new System.EventHandler(this.gotoLoginButton_Click);
            this.gotoLoginButton.MouseEnter += new System.EventHandler(this.gotoLoginButton_MouseEnter);
            this.gotoLoginButton.MouseLeave += new System.EventHandler(this.gotoLoginButton_MouseLeave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(692, 423);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Already have an account ?";
            // 
            // SignupButton
            // 
            this.SignupButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.SignupButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignupButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SignupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignupButton.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignupButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SignupButton.Location = new System.Drawing.Point(604, 354);
            this.SignupButton.Name = "SignupButton";
            this.SignupButton.Size = new System.Drawing.Size(107, 38);
            this.SignupButton.TabIndex = 7;
            this.SignupButton.Text = "Sign Up";
            this.SignupButton.UseVisualStyleBackColor = false;
            this.SignupButton.Click += new System.EventHandler(this.SignupButton_Click);
            // 
            // create_passField
            // 
            this.create_passField.Location = new System.Drawing.Point(604, 237);
            this.create_passField.Name = "create_passField";
            this.create_passField.PasswordChar = '*';
            this.create_passField.Size = new System.Drawing.Size(419, 22);
            this.create_passField.TabIndex = 6;
            this.create_passField.TextChanged += new System.EventHandler(this.create_passField_TextChanged);
            // 
            // createPassField
            // 
            this.createPassField.AutoSize = true;
            this.createPassField.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPassField.Location = new System.Drawing.Point(600, 213);
            this.createPassField.Name = "createPassField";
            this.createPassField.Size = new System.Drawing.Size(129, 21);
            this.createPassField.TabIndex = 5;
            this.createPassField.Text = "Create Password";
            // 
            // signup_emailField
            // 
            this.signup_emailField.Location = new System.Drawing.Point(604, 164);
            this.signup_emailField.Name = "signup_emailField";
            this.signup_emailField.Size = new System.Drawing.Size(419, 22);
            this.signup_emailField.TabIndex = 4;
            this.signup_emailField.TextChanged += new System.EventHandler(this.signup_emailField_TextChanged);
            // 
            // createEmailField
            // 
            this.createEmailField.AutoSize = true;
            this.createEmailField.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createEmailField.Location = new System.Drawing.Point(600, 140);
            this.createEmailField.Name = "createEmailField";
            this.createEmailField.Size = new System.Drawing.Size(48, 21);
            this.createEmailField.TabIndex = 3;
            this.createEmailField.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(753, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter your Details";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(749, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sign Up";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(536, 498);
            this.panel2.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Yu Gothic Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Salmon;
            this.label7.Location = new System.Drawing.Point(146, 383);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(223, 46);
            this.label7.TabIndex = 3;
            this.label7.Text = "CAMBRIDGE";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "TOGETHER CULTURE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(106, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 271);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SignupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 500);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignupForm";
            this.Text = "SignupForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox confirm_showpass;
        private System.Windows.Forms.Label signup_closeButton;
        private System.Windows.Forms.Label gotoLoginButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SignupButton;
        private System.Windows.Forms.TextBox create_passField;
        private System.Windows.Forms.Label createPassField;
        private System.Windows.Forms.TextBox signup_emailField;
        private System.Windows.Forms.Label createEmailField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox confirm_passField;
        private System.Windows.Forms.Label confirmPassField;
        private System.Windows.Forms.CheckBox create_showpass;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}