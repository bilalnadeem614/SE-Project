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
            show_BTN = new Button();
            trainSchView = new DataGridView();
            book_BTN = new Button();
            startLoc = new ComboBox();
            endLoc = new ComboBox();
            backBTN = new Button();
            ((System.ComponentModel.ISupportInitialize)trainSchView).BeginInit();
            SuspendLayout();
            // 
            // sloc_LB
            // 
            sloc_LB.AutoSize = true;
            sloc_LB.Location = new Point(138, 150);
            sloc_LB.Name = "sloc_LB";
            sloc_LB.Size = new Size(40, 20);
            sloc_LB.TabIndex = 0;
            sloc_LB.Text = "Start";
            // 
            // dec_LB
            // 
            dec_LB.AutoSize = true;
            dec_LB.Location = new Point(138, 208);
            dec_LB.Name = "dec_LB";
            dec_LB.Size = new Size(85, 20);
            dec_LB.TabIndex = 1;
            dec_LB.Text = "Destination";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 83);
            label1.Name = "label1";
            label1.Size = new Size(143, 20);
            label1.TabIndex = 2;
            label1.Text = "Select Your Location";
            label1.Click += label1_Click;
            // 
            // show_BTN
            // 
            show_BTN.Location = new Point(197, 304);
            show_BTN.Name = "show_BTN";
            show_BTN.Size = new Size(94, 29);
            show_BTN.TabIndex = 5;
            show_BTN.Text = "Show";
            show_BTN.UseVisualStyleBackColor = true;
            show_BTN.Click += show_BTN_Click;
            // 
            // trainSchView
            // 
            trainSchView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            trainSchView.Location = new Point(470, 34);
            trainSchView.Name = "trainSchView";
            trainSchView.RowHeadersWidth = 51;
            trainSchView.Size = new Size(410, 363);
            trainSchView.TabIndex = 6;
            // 
            // book_BTN
            // 
            book_BTN.Location = new Point(325, 304);
            book_BTN.Name = "book_BTN";
            book_BTN.Size = new Size(94, 29);
            book_BTN.TabIndex = 7;
            book_BTN.Text = "Book Ticket";
            book_BTN.UseVisualStyleBackColor = true;
            book_BTN.Click += book_BTN_Click;
            // 
            // startLoc
            // 
            startLoc.FormattingEnabled = true;
            startLoc.Items.AddRange(new object[] { "Lahore", "Islamabad", "Karachi" });
            startLoc.Location = new Point(268, 150);
            startLoc.Name = "startLoc";
            startLoc.Size = new Size(151, 28);
            startLoc.TabIndex = 8;
            // 
            // endLoc
            // 
            endLoc.FormattingEnabled = true;
            endLoc.Items.AddRange(new object[] { "Lahore", "Islamabad", "Karachi" });
            endLoc.Location = new Point(268, 200);
            endLoc.Name = "endLoc";
            endLoc.Size = new Size(151, 28);
            endLoc.TabIndex = 9;
            // 
            // backBTN
            // 
            backBTN.Location = new Point(12, 12);
            backBTN.Name = "backBTN";
            backBTN.Size = new Size(94, 29);
            backBTN.TabIndex = 10;
            backBTN.Text = "Main Menu";
            backBTN.UseVisualStyleBackColor = true;
            backBTN.Click += backBTN_Click;
            // 
            // schedule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(957, 440);
            Controls.Add(backBTN);
            Controls.Add(endLoc);
            Controls.Add(startLoc);
            Controls.Add(book_BTN);
            Controls.Add(trainSchView);
            Controls.Add(show_BTN);
            Controls.Add(label1);
            Controls.Add(dec_LB);
            Controls.Add(sloc_LB);
            Name = "schedule";
            Text = "schedule";
            ((System.ComponentModel.ISupportInitialize)trainSchView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label sloc_LB;
        private Label dec_LB;
        private Label label1;
        private Button show_BTN;
        private DataGridView trainSchView;
        private Button book_BTN;
        private ComboBox startLoc;
        private ComboBox endLoc;
        private Button backBTN;
    }
}