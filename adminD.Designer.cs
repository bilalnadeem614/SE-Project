namespace SE_Project
{
    partial class adminD
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
            usrBTN = new Button();
            TrnsBTN = new Button();
            panel1 = new Panel();
            bookngsBTN = new Button();
            SuspendLayout();
            // 
            // usrBTN
            // 
            usrBTN.Location = new Point(12, 25);
            usrBTN.Name = "usrBTN";
            usrBTN.Size = new Size(201, 97);
            usrBTN.TabIndex = 0;
            usrBTN.Text = "Users";
            usrBTN.UseVisualStyleBackColor = true;
            usrBTN.Click += usrBTN_Click;
            // 
            // TrnsBTN
            // 
            TrnsBTN.Location = new Point(12, 220);
            TrnsBTN.Name = "TrnsBTN";
            TrnsBTN.Size = new Size(201, 95);
            TrnsBTN.TabIndex = 1;
            TrnsBTN.Text = "Trains";
            TrnsBTN.UseVisualStyleBackColor = true;
            TrnsBTN.Click += TrnsBTN_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(219, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(862, 520);
            panel1.TabIndex = 2;
            // 
            // bookngsBTN
            // 
            bookngsBTN.Location = new Point(12, 413);
            bookngsBTN.Name = "bookngsBTN";
            bookngsBTN.Size = new Size(201, 96);
            bookngsBTN.TabIndex = 3;
            bookngsBTN.Text = "Bookings";
            bookngsBTN.UseVisualStyleBackColor = true;
            bookngsBTN.Click += bookngsBTN_Click;
            // 
            // adminD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1087, 536);
            Controls.Add(bookngsBTN);
            Controls.Add(panel1);
            Controls.Add(TrnsBTN);
            Controls.Add(usrBTN);
            Name = "adminD";
            Text = "adminD";
            ResumeLayout(false);
        }

        #endregion

        private Button usrBTN;
        private Button TrnsBTN;
        private Panel panel1;
        private Button bookngsBTN;
    }
}