namespace SE_Project
{
    partial class userD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userD));
            label5 = new Label();
            panel1 = new Panel();
            cancelBtn = new Button();
            historyBtn = new Button();
            bookingBtn = new Button();
            scheduleBtn = new Button();
            pictureBox5 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(307, 18);
            label5.Name = "label5";
            label5.Size = new Size(385, 35);
            label5.TabIndex = 11;
            label5.Text = "Welcome to Pakistan Railway";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(cancelBtn);
            panel1.Controls.Add(historyBtn);
            panel1.Controls.Add(bookingBtn);
            panel1.Controls.Add(scheduleBtn);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-5, 91);
            panel1.Name = "panel1";
            panel1.Size = new Size(994, 337);
            panel1.TabIndex = 12;
            panel1.Paint += panel1_Paint;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(740, 249);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(115, 29);
            cancelBtn.TabIndex = 8;
            cancelBtn.Text = "Cancel Ticket";
            cancelBtn.UseVisualStyleBackColor = true;
            // 
            // historyBtn
            // 
            historyBtn.Location = new Point(510, 249);
            historyBtn.Name = "historyBtn";
            historyBtn.Size = new Size(115, 29);
            historyBtn.TabIndex = 7;
            historyBtn.Text = "See History";
            historyBtn.UseVisualStyleBackColor = true;
            // 
            // bookingBtn
            // 
            bookingBtn.Location = new Point(307, 249);
            bookingBtn.Name = "bookingBtn";
            bookingBtn.Size = new Size(115, 29);
            bookingBtn.TabIndex = 6;
            bookingBtn.Text = "Booking";
            bookingBtn.UseVisualStyleBackColor = true;
            // 
            // scheduleBtn
            // 
            scheduleBtn.Location = new Point(87, 249);
            scheduleBtn.Name = "scheduleBtn";
            scheduleBtn.Size = new Size(115, 29);
            scheduleBtn.TabIndex = 5;
            scheduleBtn.Text = "See Schedule";
            scheduleBtn.UseVisualStyleBackColor = true;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(726, 94);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(140, 111);
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(484, 94);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(137, 98);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(265, 94);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(136, 108);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(75, 94);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(127, 117);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // userD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(982, 553);
            Controls.Add(panel1);
            Controls.Add(label5);
            Name = "userD";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "userD";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Panel panel1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox5;
        private Button cancelBtn;
        private Button historyBtn;
        private Button bookingBtn;
        private Button scheduleBtn;
    }
}