namespace SE_Project
{
    partial class usersC
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
            usersGridView = new DataGridView();
            addUserRB = new RadioButton();
            updateUserRB = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            nameTB = new TextBox();
            emailTB = new TextBox();
            passwordTB = new TextBox();
            saveBTN = new Button();
            rollCB = new ComboBox();
            delbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)usersGridView).BeginInit();
            SuspendLayout();
            // 
            // usersGridView
            // 
            usersGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            usersGridView.Location = new Point(322, 3);
            usersGridView.Name = "usersGridView";
            usersGridView.RowHeadersWidth = 51;
            usersGridView.Size = new Size(535, 504);
            usersGridView.TabIndex = 0;
            // 
            // addUserRB
            // 
            addUserRB.AutoSize = true;
            addUserRB.Location = new Point(33, 80);
            addUserRB.Name = "addUserRB";
            addUserRB.Size = new Size(137, 24);
            addUserRB.TabIndex = 1;
            addUserRB.TabStop = true;
            addUserRB.Text = "Add a New User";
            addUserRB.UseVisualStyleBackColor = true;
            // 
            // updateUserRB
            // 
            updateUserRB.AutoSize = true;
            updateUserRB.Location = new Point(33, 110);
            updateUserRB.Name = "updateUserRB";
            updateUserRB.Size = new Size(157, 24);
            updateUserRB.TabIndex = 2;
            updateUserRB.TabStop = true;
            updateUserRB.Text = "Update User's Data";
            updateUserRB.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 30);
            label1.Name = "label1";
            label1.Size = new Size(280, 38);
            label1.TabIndex = 3;
            label1.Text = "What do you want ?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 192);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 4;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 252);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 5;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 306);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 6;
            label4.Text = "Password";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 371);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 7;
            label5.Text = "Role";
            label5.Click += label5_Click;
            // 
            // nameTB
            // 
            nameTB.Location = new Point(90, 185);
            nameTB.Name = "nameTB";
            nameTB.Size = new Size(125, 27);
            nameTB.TabIndex = 8;
            // 
            // emailTB
            // 
            emailTB.Location = new Point(90, 249);
            emailTB.Name = "emailTB";
            emailTB.Size = new Size(125, 27);
            emailTB.TabIndex = 9;
            // 
            // passwordTB
            // 
            passwordTB.Location = new Point(90, 303);
            passwordTB.Name = "passwordTB";
            passwordTB.Size = new Size(125, 27);
            passwordTB.TabIndex = 10;
            // 
            // saveBTN
            // 
            saveBTN.Location = new Point(24, 423);
            saveBTN.Name = "saveBTN";
            saveBTN.Size = new Size(94, 29);
            saveBTN.TabIndex = 12;
            saveBTN.Text = "Save";
            saveBTN.UseVisualStyleBackColor = true;
            saveBTN.Click += saveBTN_Click;
            // 
            // rollCB
            // 
            rollCB.FormattingEnabled = true;
            rollCB.Items.AddRange(new object[] { "1", "2" });
            rollCB.Location = new Point(90, 371);
            rollCB.Name = "rollCB";
            rollCB.Size = new Size(125, 28);
            rollCB.TabIndex = 13;
            // 
            // delbtn
            // 
            delbtn.Location = new Point(153, 423);
            delbtn.Name = "delbtn";
            delbtn.Size = new Size(94, 29);
            delbtn.TabIndex = 14;
            delbtn.Text = "Delete";
            delbtn.UseVisualStyleBackColor = true;
            delbtn.Click += delbtn_Click;
            // 
            // usersC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(delbtn);
            Controls.Add(rollCB);
            Controls.Add(saveBTN);
            Controls.Add(passwordTB);
            Controls.Add(emailTB);
            Controls.Add(nameTB);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(updateUserRB);
            Controls.Add(addUserRB);
            Controls.Add(usersGridView);
            Name = "usersC";
            Size = new Size(860, 510);
            Load += usersC_Load;
            ((System.ComponentModel.ISupportInitialize)usersGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView usersGridView;
        private RadioButton addUserRB;
        private RadioButton updateUserRB;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox nameTB;
        private TextBox emailTB;
        private TextBox passwordTB;
        private Button saveBTN;
        private ComboBox rollCB;
        private Button delbtn;
    }
}
