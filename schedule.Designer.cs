namespace SE_Project
{
    partial class schedule
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
            sloc_LB = new Label();
            dec_LB = new Label();
            label1 = new Label();
            submit_BTN = new Button();
            dataGridView1 = new DataGridView();
            book_BTN = new Button();
            start_CB = new ComboBox();
            des_CB = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // sloc_LB
            // 
            sloc_LB.AutoSize = true;
            sloc_LB.Location = new Point(75, 88);
            sloc_LB.Name = "sloc_LB";
            sloc_LB.Size = new Size(40, 20);
            sloc_LB.TabIndex = 0;
            sloc_LB.Text = "Start";
            // 
            // dec_LB
            // 
            dec_LB.AutoSize = true;
            dec_LB.Location = new Point(75, 146);
            dec_LB.Name = "dec_LB";
            dec_LB.Size = new Size(85, 20);
            dec_LB.TabIndex = 1;
            dec_LB.Text = "Destination";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 21);
            label1.Name = "label1";
            label1.Size = new Size(143, 20);
            label1.TabIndex = 2;
            label1.Text = "Select Your Location";
            label1.Click += label1_Click;
            // 
            // submit_BTN
            // 
            submit_BTN.Location = new Point(134, 242);
            submit_BTN.Name = "submit_BTN";
            submit_BTN.Size = new Size(94, 29);
            submit_BTN.TabIndex = 5;
            submit_BTN.Text = "Show";
            submit_BTN.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(470, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(410, 363);
            dataGridView1.TabIndex = 6;
            // 
            // book_BTN
            // 
            book_BTN.Location = new Point(262, 242);
            book_BTN.Name = "book_BTN";
            book_BTN.Size = new Size(94, 29);
            book_BTN.TabIndex = 7;
            book_BTN.Text = "Book Ticket";
            book_BTN.UseVisualStyleBackColor = true;
            // 
            // start_CB
            // 
            start_CB.FormattingEnabled = true;
            start_CB.Location = new Point(205, 88);
            start_CB.Name = "start_CB";
            start_CB.Size = new Size(151, 28);
            start_CB.TabIndex = 8;
            // 
            // des_CB
            // 
            des_CB.FormattingEnabled = true;
            des_CB.Location = new Point(205, 138);
            des_CB.Name = "des_CB";
            des_CB.Size = new Size(151, 28);
            des_CB.TabIndex = 9;
            // 
            // schedule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(957, 440);
            Controls.Add(des_CB);
            Controls.Add(start_CB);
            Controls.Add(book_BTN);
            Controls.Add(dataGridView1);
            Controls.Add(submit_BTN);
            Controls.Add(label1);
            Controls.Add(dec_LB);
            Controls.Add(sloc_LB);
            Name = "schedule";
            Text = "schedule";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label sloc_LB;
        private Label dec_LB;
        private Label label1;
        private Button submit_BTN;
        private DataGridView dataGridView1;
        private Button book_BTN;
        private ComboBox start_CB;
        private ComboBox des_CB;
    }
}