namespace SE_Project
{
    partial class Booking
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
            endLoc = new ComboBox();
            startLoc = new ComboBox();
            label1 = new Label();
            dec_LB = new Label();
            sloc_LB = new Label();
            trainSchView = new DataGridView();
            noseats_LB = new Label();
            noseat_TB = new TextBox();
            pricePnl = new Panel();
            show_BTN = new Button();
            bill_BTN = new Button();
            pay_BTN = new Button();
            backBTN = new Button();
            berthChk = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)trainSchView).BeginInit();
            SuspendLayout();
            // 
            // endLoc
            // 
            endLoc.FormattingEnabled = true;
            endLoc.Items.AddRange(new object[] { "Lahore", "Karachi", "Islamabad" });
            endLoc.Location = new Point(239, 155);
            endLoc.Name = "endLoc";
            endLoc.Size = new Size(151, 28);
            endLoc.TabIndex = 14;
            // 
            // startLoc
            // 
            startLoc.FormattingEnabled = true;
            startLoc.Items.AddRange(new object[] { "Lahore", "Karachi", "Islamabad" });
            startLoc.Location = new Point(239, 105);
            startLoc.Name = "startLoc";
            startLoc.Size = new Size(151, 28);
            startLoc.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 71);
            label1.Name = "label1";
            label1.Size = new Size(143, 20);
            label1.TabIndex = 12;
            label1.Text = "Select Your Location";
            // 
            // dec_LB
            // 
            dec_LB.AutoSize = true;
            dec_LB.Location = new Point(109, 163);
            dec_LB.Name = "dec_LB";
            dec_LB.Size = new Size(85, 20);
            dec_LB.TabIndex = 11;
            dec_LB.Text = "Destination";
            // 
            // sloc_LB
            // 
            sloc_LB.AutoSize = true;
            sloc_LB.Location = new Point(109, 105);
            sloc_LB.Name = "sloc_LB";
            sloc_LB.Size = new Size(40, 20);
            sloc_LB.TabIndex = 10;
            sloc_LB.Text = "Start";
            // 
            // trainSchView
            // 
            trainSchView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            trainSchView.Location = new Point(418, 50);
            trainSchView.Name = "trainSchView";
            trainSchView.RowHeadersWidth = 51;
            trainSchView.Size = new Size(410, 166);
            trainSchView.TabIndex = 15;
            // 
            // noseats_LB
            // 
            noseats_LB.AutoSize = true;
            noseats_LB.Location = new Point(57, 278);
            noseats_LB.Name = "noseats_LB";
            noseats_LB.Size = new Size(126, 20);
            noseats_LB.TabIndex = 16;
            noseats_LB.Text = "Total No. of Seats";
            // 
            // noseat_TB
            // 
            noseat_TB.Location = new Point(193, 275);
            noseat_TB.Name = "noseat_TB";
            noseat_TB.Size = new Size(145, 27);
            noseat_TB.TabIndex = 17;
            noseat_TB.Text = "1";
            // 
            // pricePnl
            // 
            pricePnl.Location = new Point(418, 253);
            pricePnl.Name = "pricePnl";
            pricePnl.Size = new Size(410, 125);
            pricePnl.TabIndex = 18;
            // 
            // show_BTN
            // 
            show_BTN.Location = new Point(193, 206);
            show_BTN.Name = "show_BTN";
            show_BTN.Size = new Size(94, 29);
            show_BTN.TabIndex = 6;
            show_BTN.Text = "Show";
            show_BTN.UseVisualStyleBackColor = true;
            show_BTN.Click += show_BTN_Click;
            // 
            // bill_BTN
            // 
            bill_BTN.Location = new Point(193, 358);
            bill_BTN.Name = "bill_BTN";
            bill_BTN.Size = new Size(94, 29);
            bill_BTN.TabIndex = 19;
            bill_BTN.Text = "Show Bill";
            bill_BTN.UseVisualStyleBackColor = true;
            bill_BTN.Click += bill_BTN_Click;
            // 
            // pay_BTN
            // 
            pay_BTN.Location = new Point(558, 397);
            pay_BTN.Name = "pay_BTN";
            pay_BTN.Size = new Size(94, 29);
            pay_BTN.TabIndex = 20;
            pay_BTN.Text = "Confirm";
            pay_BTN.UseVisualStyleBackColor = true;
            pay_BTN.Click += pay_BTN_Click;
            // 
            // backBTN
            // 
            backBTN.Location = new Point(12, 12);
            backBTN.Name = "backBTN";
            backBTN.Size = new Size(94, 29);
            backBTN.TabIndex = 21;
            backBTN.Text = "Main Menu";
            backBTN.UseVisualStyleBackColor = true;
            backBTN.Click += backBTN_Click;
            // 
            // berthChk
            // 
            berthChk.AutoSize = true;
            berthChk.Location = new Point(193, 318);
            berthChk.Name = "berthChk";
            berthChk.Size = new Size(138, 24);
            berthChk.TabIndex = 23;
            berthChk.Text = "Include Berth (s)";
            berthChk.UseVisualStyleBackColor = true;
            // 
            // Booking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(875, 450);
            Controls.Add(berthChk);
            Controls.Add(backBTN);
            Controls.Add(pay_BTN);
            Controls.Add(bill_BTN);
            Controls.Add(show_BTN);
            Controls.Add(pricePnl);
            Controls.Add(noseat_TB);
            Controls.Add(noseats_LB);
            Controls.Add(trainSchView);
            Controls.Add(endLoc);
            Controls.Add(startLoc);
            Controls.Add(label1);
            Controls.Add(dec_LB);
            Controls.Add(sloc_LB);
            Name = "Booking";
            Text = "Booking";
            Load += Booking_Load;
            ((System.ComponentModel.ISupportInitialize)trainSchView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox endLoc;
        private ComboBox startLoc;
        private Label label1;
        private Label dec_LB;
        private Label sloc_LB;
        private DataGridView trainSchView;
        private Label noseats_LB;
        private TextBox noseat_TB;
        private Panel pricePnl;
        private Button show_BTN;
        private Button bill_BTN;
        private Button pay_BTN;
        private Button backBTN;
        private CheckBox berthChk;
    }
}