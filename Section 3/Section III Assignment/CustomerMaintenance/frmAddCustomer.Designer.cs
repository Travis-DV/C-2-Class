namespace CustomerMaintenance
{
    partial class frmAddCustomer
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
            label1 = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            RB_B2B = new RadioButton();
            RB_B2C = new RadioButton();
            lblCompanyOrPhone = new Label();
            txtCompanyOrPhone = new TextBox();
            RB_C2C = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 87);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 2;
            label1.Text = "First Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(112, 85);
            txtFirstName.Margin = new Padding(2);
            txtFirstName.MaxLength = 30;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(176, 23);
            txtFirstName.TabIndex = 3;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(112, 115);
            txtLastName.Margin = new Padding(2);
            txtLastName.MaxLength = 30;
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(176, 23);
            txtLastName.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 119);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 4;
            label2.Text = "Last Name:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(112, 145);
            txtEmail.Margin = new Padding(2);
            txtEmail.MaxLength = 30;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(176, 23);
            txtEmail.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 151);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 6;
            label3.Text = "Email:";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(112, 208);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 10;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(213, 208);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // RB_B2B
            // 
            RB_B2B.AutoSize = true;
            RB_B2B.Checked = true;
            RB_B2B.Location = new Point(6, 22);
            RB_B2B.Name = "RB_B2B";
            RB_B2B.Size = new Size(79, 19);
            RB_B2B.TabIndex = 0;
            RB_B2B.TabStop = true;
            RB_B2B.Text = "Wholesale";
            RB_B2B.UseVisualStyleBackColor = true;
            RB_B2B.CheckedChanged += RadialButton_CheckedChanged;
            // 
            // RB_B2C
            // 
            RB_B2C.AutoSize = true;
            RB_B2C.Location = new Point(91, 22);
            RB_B2C.Name = "RB_B2C";
            RB_B2C.Size = new Size(54, 19);
            RB_B2C.TabIndex = 1;
            RB_B2C.Text = "Retail";
            RB_B2C.UseVisualStyleBackColor = true;
            // 
            // lblCompanyOrPhone
            // 
            lblCompanyOrPhone.AutoSize = true;
            lblCompanyOrPhone.Location = new Point(30, 178);
            lblCompanyOrPhone.Name = "lblCompanyOrPhone";
            lblCompanyOrPhone.Size = new Size(62, 15);
            lblCompanyOrPhone.TabIndex = 8;
            lblCompanyOrPhone.Text = "Company:";
            // 
            // txtCompanyOrPhone
            // 
            txtCompanyOrPhone.Location = new Point(112, 175);
            txtCompanyOrPhone.Name = "txtCompanyOrPhone";
            txtCompanyOrPhone.Size = new Size(176, 23);
            txtCompanyOrPhone.TabIndex = 9;
            // 
            // RB_C2C
            // 
            RB_C2C.AutoSize = true;
            RB_C2C.Location = new Point(151, 22);
            RB_C2C.Name = "RB_C2C";
            RB_C2C.Size = new Size(47, 19);
            RB_C2C.TabIndex = 12;
            RB_C2C.Text = "C2C";
            RB_C2C.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(RB_B2B);
            groupBox1.Controls.Add(RB_C2C);
            groupBox1.Controls.Add(RB_B2C);
            groupBox1.Location = new Point(42, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(236, 59);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer Type";
            // 
            // frmAddCustomer
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(318, 265);
            ControlBox = false;
            Controls.Add(groupBox1);
            Controls.Add(txtCompanyOrPhone);
            Controls.Add(lblCompanyOrPhone);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtLastName);
            Controls.Add(label2);
            Controls.Add(txtFirstName);
            Controls.Add(label1);
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "frmAddCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Customer";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Label label2;
        private TextBox txtEmail;
        private Label label3;
        private Button btnSave;
        private Button btnCancel;
        private RadioButton RB_B2B;
        private RadioButton RB_B2C;
        private Label lblCompanyOrPhone;
        private TextBox txtCompanyOrPhone;
        private RadioButton RB_C2C;
        private GroupBox groupBox1;
    }
}