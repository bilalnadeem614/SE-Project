namespace SE_Project
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            label1 = new Label();
            NameL = new Label();
            nameTB = new TextBox();
            emailTB = new TextBox();
            label2 = new Label();
            passwordTB = new TextBox();
            label3 = new Label();
            confPassTB = new TextBox();
            label4 = new Label();
            sideimg = new PictureBox();
            label5 = new Label();
            signupBtn = new Button();
            label6 = new Label();
            loginBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)sideimg).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(565, 77);
            label1.Name = "label1";
            label1.Size = new Size(118, 35);
            label1.TabIndex = 0;
            label1.Text = "Sign Up";
            label1.Click += label1_Click;
            // 
            // NameL
            // 
            NameL.AutoSize = true;
            NameL.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NameL.Location = new Point(565, 131);
            NameL.Name = "NameL";
            NameL.Size = new Size(59, 23);
            NameL.TabIndex = 1;
            NameL.Text = "Name";
            // 
            // nameTB
            // 
            nameTB.Location = new Point(581, 167);
            nameTB.Name = "nameTB";
            nameTB.Size = new Size(277, 27);
            nameTB.TabIndex = 2;
            // 
            // emailTB
            // 
            emailTB.Location = new Point(581, 262);
            emailTB.Name = "emailTB";
            emailTB.Size = new Size(277, 27);
            emailTB.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(565, 218);
            label2.Name = "label2";
            label2.Size = new Size(58, 23);
            label2.TabIndex = 3;
            label2.Text = "Email";
            // 
            // passwordTB
            // 
            passwordTB.Location = new Point(581, 346);
            passwordTB.Name = "passwordTB";
            passwordTB.Size = new Size(277, 27);
            passwordTB.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(568, 311);
            label3.Name = "label3";
            label3.Size = new Size(90, 23);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // confPassTB
            // 
            confPassTB.Location = new Point(581, 442);
            confPassTB.Name = "confPassTB";
            confPassTB.Size = new Size(277, 27);
            confPassTB.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(568, 404);
            label4.Name = "label4";
            label4.Size = new Size(164, 23);
            label4.TabIndex = 7;
            label4.Text = "Confirm Password";
            // 
            // sideimg
            // 
            sideimg.BackgroundImageLayout = ImageLayout.Zoom;
            sideimg.Image = (Image)resources.GetObject("sideimg.Image");
            sideimg.Location = new Point(12, 77);
            sideimg.Name = "sideimg";
            sideimg.Size = new Size(528, 392);
            sideimg.TabIndex = 9;
            sideimg.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(273, 9);
            label5.Name = "label5";
            label5.Size = new Size(385, 35);
            label5.TabIndex = 10;
            label5.Text = "Welcome to Pakistan Railway";
            // 
            // signupBtn
            // 
            signupBtn.Location = new Point(661, 496);
            signupBtn.Name = "signupBtn";
            signupBtn.Size = new Size(94, 29);
            signupBtn.TabIndex = 11;
            signupBtn.Text = "Register";
            signupBtn.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 498);
            label6.Name = "label6";
            label6.Size = new Size(207, 23);
            label6.TabIndex = 12;
            label6.Text = "Already have a account";
            // 
            // loginBtn
            // 
            loginBtn.Location = new Point(249, 496);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(94, 29);
            loginBtn.TabIndex = 13;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(932, 553);
            Controls.Add(loginBtn);
            Controls.Add(label6);
            Controls.Add(signupBtn);
            Controls.Add(label5);
            Controls.Add(sideimg);
            Controls.Add(confPassTB);
            Controls.Add(label4);
            Controls.Add(passwordTB);
            Controls.Add(label3);
            Controls.Add(emailTB);
            Controls.Add(label2);
            Controls.Add(nameTB);
            Controls.Add(NameL);
            Controls.Add(label1);
            Name = "Signup";
            Text = "Signup";
            Load += Signup_Load;
            ((System.ComponentModel.ISupportInitialize)sideimg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label NameL;
        private TextBox nameTB;
        private TextBox emailTB;
        private Label label2;
        private TextBox passwordTB;
        private Label label3;
        private TextBox confPassTB;
        private Label label4;
        private PictureBox sideimg;
        private Label label5;
        private Button signupBtn;
        private Label label6;
        private Button loginBtn;
    }
}