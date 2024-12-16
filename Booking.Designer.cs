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
            des_CB = new ComboBox();
            start_CB = new ComboBox();
            label1 = new Label();
            dec_LB = new Label();
            sloc_LB = new Label();
            dataGridView1 = new DataGridView();
            noseats_LB = new Label();
            noseat_TB = new TextBox();
            panel1 = new Panel();
            show_BTN = new Button();
            bill_BTN = new Button();
            pay_BTN = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // des_CB
            // 
            des_CB.FormattingEnabled = true;
            des_CB.Location = new Point(178, 117);
            des_CB.Name = "des_CB";
            des_CB.Size = new Size(151, 28);
            des_CB.TabIndex = 14;
            // 
            // start_CB
            // 
            start_CB.FormattingEnabled = true;
            start_CB.Location = new Point(178, 67);
            start_CB.Name = "start_CB";
            start_CB.Size = new Size(151, 28);
            start_CB.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 33);
            label1.Name = "label1";
            label1.Size = new Size(143, 20);
            label1.TabIndex = 12;
            label1.Text = "Select Your Location";
            // 
            // dec_LB
            // 
            dec_LB.AutoSize = true;
            dec_LB.Location = new Point(48, 125);
            dec_LB.Name = "dec_LB";
            dec_LB.Size = new Size(85, 20);
            dec_LB.TabIndex = 11;
            dec_LB.Text = "Destination";
            // 
            // sloc_LB
            // 
            sloc_LB.AutoSize = true;
            sloc_LB.Location = new Point(48, 67);
            sloc_LB.Name = "sloc_LB";
            sloc_LB.Size = new Size(40, 20);
            sloc_LB.TabIndex = 10;
            sloc_LB.Text = "Start";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(418, 50);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(410, 166);
            dataGridView1.TabIndex = 15;
            // 
            // noseats_LB
            // 
            noseats_LB.AutoSize = true;
            noseats_LB.Location = new Point(42, 241);
            noseats_LB.Name = "noseats_LB";
            noseats_LB.Size = new Size(126, 20);
            noseats_LB.TabIndex = 16;
            noseats_LB.Text = "Total No. of Seats";
            // 
            // noseat_TB
            // 
            noseat_TB.Location = new Point(178, 238);
            noseat_TB.Name = "noseat_TB";
            noseat_TB.Size = new Size(145, 27);
            noseat_TB.TabIndex = 17;
            noseat_TB.Text = "1";
            // 
            // panel1
            // 
            panel1.Location = new Point(418, 253);
            panel1.Name = "panel1";
            panel1.Size = new Size(410, 125);
            panel1.TabIndex = 18;
            // 
            // show_BTN
            // 
            show_BTN.Location = new Point(132, 168);
            show_BTN.Name = "show_BTN";
            show_BTN.Size = new Size(94, 29);
            show_BTN.TabIndex = 6;
            show_BTN.Text = "Show";
            show_BTN.UseVisualStyleBackColor = true;
            // 
            // bill_BTN
            // 
            bill_BTN.Location = new Point(132, 293);
            bill_BTN.Name = "bill_BTN";
            bill_BTN.Size = new Size(94, 29);
            bill_BTN.TabIndex = 19;
            bill_BTN.Text = "Show Bill";
            bill_BTN.UseVisualStyleBackColor = true;
            // 
            // pay_BTN
            // 
            pay_BTN.Location = new Point(558, 397);
            pay_BTN.Name = "pay_BTN";
            pay_BTN.Size = new Size(94, 29);
            pay_BTN.TabIndex = 20;
            pay_BTN.Text = "Pay Now";
            pay_BTN.UseVisualStyleBackColor = true;
            // 
            // Booking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(875, 450);
            Controls.Add(pay_BTN);
            Controls.Add(bill_BTN);
            Controls.Add(show_BTN);
            Controls.Add(panel1);
            Controls.Add(noseat_TB);
            Controls.Add(noseats_LB);
            Controls.Add(dataGridView1);
            Controls.Add(des_CB);
            Controls.Add(start_CB);
            Controls.Add(label1);
            Controls.Add(dec_LB);
            Controls.Add(sloc_LB);
            Name = "Booking";
            Text = "Booking";
            Load += Booking_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox des_CB;
        private ComboBox start_CB;
        private Label label1;
        private Label dec_LB;
        private Label sloc_LB;
        private DataGridView dataGridView1;
        private Label noseats_LB;
        private TextBox noseat_TB;
        private Panel panel1;
        private Button show_BTN;
        private Button bill_BTN;
        private Button pay_BTN;
    }
}