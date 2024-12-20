namespace SE_Project
{
    partial class trainsC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            delbtn = new Button();
            saveBTN = new Button();
            tSeats = new TextBox();
            trainNameTB = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            updateTrainRB = new RadioButton();
            addTrainRB = new RadioButton();
            trainsGridView = new DataGridView();
            startLoc = new ComboBox();
            endLoc = new ComboBox();
            label5 = new Label();
            avlSeats = new TextBox();
            label6 = new Label();
            ppS = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)trainsGridView).BeginInit();
            SuspendLayout();
            // 
            // delbtn
            // 
            delbtn.Location = new Point(143, 457);
            delbtn.Name = "delbtn";
            delbtn.Size = new Size(94, 29);
            delbtn.TabIndex = 28;
            delbtn.Text = "Delete";
            delbtn.UseVisualStyleBackColor = true;
            delbtn.Click += delbtn_Click;
            // 
            // saveBTN
            // 
            saveBTN.Location = new Point(14, 457);
            saveBTN.Name = "saveBTN";
            saveBTN.Size = new Size(94, 29);
            saveBTN.TabIndex = 26;
            saveBTN.Text = "Save";
            saveBTN.UseVisualStyleBackColor = true;
            saveBTN.Click += saveBTN_Click;
            // 
            // tSeats
            // 
            tSeats.Location = new Point(101, 303);
            tSeats.Name = "tSeats";
            tSeats.Size = new Size(125, 27);
            tSeats.TabIndex = 25;
            // 
            // trainNameTB
            // 
            trainNameTB.Location = new Point(101, 149);
            trainNameTB.Name = "trainNameTB";
            trainNameTB.Size = new Size(125, 27);
            trainNameTB.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 306);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 21;
            label4.Text = "Total Seats";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 204);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 20;
            label3.Text = "Start Loc";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 156);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 19;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 30);
            label1.Name = "label1";
            label1.Size = new Size(280, 38);
            label1.TabIndex = 18;
            label1.Text = "What do you want ?";
            // 
            // updateTrainRB
            // 
            updateTrainRB.AutoSize = true;
            updateTrainRB.Location = new Point(29, 110);
            updateTrainRB.Name = "updateTrainRB";
            updateTrainRB.Size = new Size(160, 24);
            updateTrainRB.TabIndex = 17;
            updateTrainRB.TabStop = true;
            updateTrainRB.Text = "Update Train's Data";
            updateTrainRB.UseVisualStyleBackColor = true;
            // 
            // addTrainRB
            // 
            addTrainRB.AutoSize = true;
            addTrainRB.Location = new Point(29, 80);
            addTrainRB.Name = "addTrainRB";
            addTrainRB.Size = new Size(140, 24);
            addTrainRB.TabIndex = 16;
            addTrainRB.TabStop = true;
            addTrainRB.Text = "Add a New Train";
            addTrainRB.UseVisualStyleBackColor = true;
            // 
            // trainsGridView
            // 
            trainsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            trainsGridView.Location = new Point(318, 3);
            trainsGridView.Name = "trainsGridView";
            trainsGridView.RowHeadersWidth = 51;
            trainsGridView.Size = new Size(535, 504);
            trainsGridView.TabIndex = 15;
            // 
            // startLoc
            // 
            startLoc.FormattingEnabled = true;
            startLoc.Items.AddRange(new object[] { "Lahore", "Karachi", "Islamabad" });
            startLoc.Location = new Point(101, 204);
            startLoc.Name = "startLoc";
            startLoc.Size = new Size(124, 28);
            startLoc.TabIndex = 29;
            // 
            // endLoc
            // 
            endLoc.FormattingEnabled = true;
            endLoc.Items.AddRange(new object[] { "Lahore", "Karachi", "Islamabad" });
            endLoc.Location = new Point(101, 258);
            endLoc.Name = "endLoc";
            endLoc.Size = new Size(124, 28);
            endLoc.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 261);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 30;
            label5.Text = "End Loc";
            label5.Click += label5_Click;
            // 
            // avlSeats
            // 
            avlSeats.Location = new Point(101, 360);
            avlSeats.Name = "avlSeats";
            avlSeats.Size = new Size(125, 27);
            avlSeats.TabIndex = 33;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 363);
            label6.Name = "label6";
            label6.Size = new Size(80, 20);
            label6.TabIndex = 32;
            label6.Text = "Aval. Seats";
            // 
            // ppS
            // 
            ppS.Location = new Point(100, 404);
            ppS.Name = "ppS";
            ppS.Size = new Size(125, 27);
            ppS.TabIndex = 35;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 407);
            label7.Name = "label7";
            label7.Size = new Size(74, 20);
            label7.TabIndex = 34;
            label7.Text = "Prc P Seat";
            // 
            // trainsC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ppS);
            Controls.Add(label7);
            Controls.Add(avlSeats);
            Controls.Add(label6);
            Controls.Add(endLoc);
            Controls.Add(label5);
            Controls.Add(startLoc);
            Controls.Add(delbtn);
            Controls.Add(saveBTN);
            Controls.Add(tSeats);
            Controls.Add(trainNameTB);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(updateTrainRB);
            Controls.Add(addTrainRB);
            Controls.Add(trainsGridView);
            Name = "trainsC";
            Size = new Size(860, 510);
            Load += trainsC_Load;
            ((System.ComponentModel.ISupportInitialize)trainsGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button delbtn;
        private Button saveBTN;
        private TextBox tSeats;
        private TextBox trainNameTB;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private RadioButton updateTrainRB;
        private RadioButton addTrainRB;
        private DataGridView trainsGridView;
        private ComboBox startLoc;
        private ComboBox endLoc;
        private Label label5;
        private TextBox avlSeats;
        private Label label6;
        private TextBox ppS;
        private Label label7;
    }
}
