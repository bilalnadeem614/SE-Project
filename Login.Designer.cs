namespace SE_Project
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            sideimg = new PictureBox();
            label1 = new Label();
            label5 = new Label();
            passwordTB = new TextBox();
            label3 = new Label();
            emailTB = new TextBox();
            label2 = new Label();
            loginBtn = new Button();
            signupBtn = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)sideimg).BeginInit();
            SuspendLayout();
            // 
            // sideimg
            // 
            sideimg.BackgroundImageLayout = ImageLayout.Zoom;
            sideimg.Image = (Image)resources.GetObject("sideimg.Image");
            sideimg.Location = new Point(12, 73);
            sideimg.Name = "sideimg";
            sideimg.Size = new Size(528, 392);
            sideimg.TabIndex = 10;
            sideimg.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(565, 73);
            label1.Name = "label1";
            label1.Size = new Size(89, 35);
            label1.TabIndex = 11;
            label1.Text = "Login";
            label1.Click += label1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(403, 9);
            label5.Name = "label5";
            label5.Size = new Size(198, 35);
            label5.TabIndex = 12;
            label5.Text = "Welcome Back";
            // 
            // passwordTB
            // 
            passwordTB.Location = new Point(578, 281);
            passwordTB.Name = "passwordTB";
            passwordTB.Size = new Size(277, 27);
            passwordTB.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(565, 246);
            label3.Name = "label3";
            label3.Size = new Size(90, 23);
            label3.TabIndex = 15;
            label3.Text = "Password";
            // 
            // emailTB
            // 
            emailTB.Location = new Point(578, 197);
            emailTB.Name = "emailTB";
            emailTB.Size = new Size(277, 27);
            emailTB.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(562, 153);
            label2.Name = "label2";
            label2.Size = new Size(58, 23);
            label2.TabIndex = 13;
            label2.Text = "Email";
            // 
            // loginBtn
            // 
            loginBtn.Location = new Point(578, 348);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(94, 29);
            loginBtn.TabIndex = 17;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            // 
            // signupBtn
            // 
            signupBtn.Location = new Point(589, 498);
            signupBtn.Name = "signupBtn";
            signupBtn.Size = new Size(94, 29);
            signupBtn.TabIndex = 19;
            signupBtn.Text = "Sign Up";
            signupBtn.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(352, 500);
            label6.Name = "label6";
            label6.Size = new Size(193, 23);
            label6.TabIndex = 18;
            label6.Text = "Create a new account";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(932, 553);
            Controls.Add(signupBtn);
            Controls.Add(label6);
            Controls.Add(loginBtn);
            Controls.Add(passwordTB);
            Controls.Add(label3);
            Controls.Add(emailTB);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(sideimg);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)sideimg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox sideimg;
        private Label label1;
        private Label label5;
        private TextBox passwordTB;
        private Label label3;
        private TextBox emailTB;
        private Label label2;
        private Button loginBtn;
        private Button signupBtn;
        private Label label6;
    }
}