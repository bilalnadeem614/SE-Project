namespace SE_Project
{
    partial class history
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
            historyV = new DataGridView();
            refreshBTN = new Button();
            backBTN = new Button();
            ((System.ComponentModel.ISupportInitialize)historyV).BeginInit();
            SuspendLayout();
            // 
            // historyV
            // 
            historyV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            historyV.Location = new Point(12, 60);
            historyV.Name = "historyV";
            historyV.RowHeadersWidth = 51;
            historyV.Size = new Size(776, 269);
            historyV.TabIndex = 0;
            // 
            // refreshBTN
            // 
            refreshBTN.Location = new Point(342, 358);
            refreshBTN.Name = "refreshBTN";
            refreshBTN.Size = new Size(94, 29);
            refreshBTN.TabIndex = 1;
            refreshBTN.Text = "Refersh";
            refreshBTN.UseVisualStyleBackColor = true;
            refreshBTN.Click += refreshBTN_Click;
            // 
            // backBTN
            // 
            backBTN.Location = new Point(12, 12);
            backBTN.Name = "backBTN";
            backBTN.Size = new Size(94, 29);
            backBTN.TabIndex = 11;
            backBTN.Text = "Main Menu";
            backBTN.UseVisualStyleBackColor = true;
            backBTN.Click += backBTN_Click;
            // 
            // history
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(backBTN);
            Controls.Add(refreshBTN);
            Controls.Add(historyV);
            Name = "history";
            Text = "history";
            Load += history_Load;
            ((System.ComponentModel.ISupportInitialize)historyV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView historyV;
        private Button refreshBTN;
        private Button backBTN;
    }
}