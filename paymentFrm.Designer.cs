namespace SE_Project
{
    partial class paymentFrm
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
            paymentInfo = new Panel();
            Info = new Label();
            detailsInfo = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            bankOp = new ComboBox();
            accNo = new TextBox();
            pin = new TextBox();
            pymntBTN = new Button();
            SuspendLayout();
            // 
            // paymentInfo
            // 
            paymentInfo.Location = new Point(396, 63);
            paymentInfo.Name = "paymentInfo";
            paymentInfo.Size = new Size(392, 211);
            paymentInfo.TabIndex = 0;
            // 
            // Info
            // 
            Info.AutoSize = true;
            Info.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Info.Location = new Point(527, 20);
            Info.Name = "Info";
            Info.Size = new Size(139, 28);
            Info.TabIndex = 1;
            Info.Text = "Payment Info";
            // 
            // detailsInfo
            // 
            detailsInfo.AutoSize = true;
            detailsInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            detailsInfo.Location = new Point(105, 20);
            detailsInfo.Name = "detailsInfo";
            detailsInfo.Size = new Size(182, 28);
            detailsInfo.TabIndex = 2;
            detailsInfo.Text = "Enter Your Details";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 94);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 3;
            label1.Text = "Bank";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 162);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 4;
            label2.Text = "Account";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 219);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 5;
            label3.Text = "CVC";
            // 
            // bankOp
            // 
            bankOp.FormattingEnabled = true;
            bankOp.Items.AddRange(new object[] { "HBL", "UBL", "JazzCash", "EasyPaysa", "SadaPay", "NayaPay" });
            bankOp.Location = new Point(105, 91);
            bankOp.Name = "bankOp";
            bankOp.Size = new Size(151, 28);
            bankOp.TabIndex = 6;
            // 
            // accNo
            // 
            accNo.Location = new Point(105, 159);
            accNo.Name = "accNo";
            accNo.Size = new Size(151, 27);
            accNo.TabIndex = 7;
            // 
            // pin
            // 
            pin.Location = new Point(114, 219);
            pin.Name = "pin";
            pin.Size = new Size(55, 27);
            pin.TabIndex = 8;
            // 
            // pymntBTN
            // 
            pymntBTN.Location = new Point(88, 293);
            pymntBTN.Name = "pymntBTN";
            pymntBTN.Size = new Size(94, 29);
            pymntBTN.TabIndex = 9;
            pymntBTN.Text = "Confirm";
            pymntBTN.UseVisualStyleBackColor = true;
            pymntBTN.Click += pymntBTN_Click;
            // 
            // paymentFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(pymntBTN);
            Controls.Add(pin);
            Controls.Add(accNo);
            Controls.Add(bankOp);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(detailsInfo);
            Controls.Add(Info);
            Controls.Add(paymentInfo);
            Name = "paymentFrm";
            Text = "paymentFrm";
            Load += paymentFrm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel paymentInfo;
        private Label Info;
        private Label detailsInfo;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox bankOp;
        private TextBox accNo;
        private TextBox pin;
        private Button pymntBTN;
    }
}