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
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblPhoneNumber = new Label();
            txtPhoneNumber = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(24, 27);
            lblFirstName.Margin = new Padding(2, 0, 2, 0);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(67, 15);
            lblFirstName.TabIndex = 5;
            lblFirstName.Text = "First Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(108, 25);
            txtFirstName.Margin = new Padding(2);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(176, 23);
            txtFirstName.TabIndex = 0;
            txtFirstName.Click += txtClicked;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(24, 59);
            lblLastName.Margin = new Padding(2, 0, 2, 0);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(66, 15);
            lblLastName.TabIndex = 6;
            lblLastName.Text = "Last Name:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(108, 57);
            txtLastName.Margin = new Padding(2);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(176, 23);
            txtLastName.TabIndex = 1;
            txtLastName.Click += txtClicked;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(24, 91);
            lblEmail.Margin = new Padding(2, 0, 2, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(108, 89);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(176, 23);
            txtEmail.TabIndex = 2;
            txtEmail.Click += txtClicked;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(11, 126);
            lblPhoneNumber.Margin = new Padding(2, 0, 2, 0);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(91, 15);
            lblPhoneNumber.TabIndex = 9;
            lblPhoneNumber.Text = "Phone Number:";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(108, 123);
            txtPhoneNumber.Margin = new Padding(2);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(176, 23);
            txtPhoneNumber.TabIndex = 8;
            txtPhoneNumber.Click += txtClicked;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(108, 159);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 3;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(209, 159);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmAddCustomer
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(309, 201);
            ControlBox = false;
            Controls.Add(txtPhoneNumber);
            Controls.Add(lblPhoneNumber);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtLastName);
            Controls.Add(lblLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblFirstName);
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "frmAddCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Customer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFirstName;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Label lblLastName;
        private TextBox txtEmail;
        private Label lblEmail;
        private Button btnSave;
        private Button btnCancel;
        private TextBox txtPhoneNumber;
        private Label lblPhoneNumber;
    }
}