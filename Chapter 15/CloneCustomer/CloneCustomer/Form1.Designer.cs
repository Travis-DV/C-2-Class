namespace CloneCustomer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCustomer = new Label();
            label1 = new Label();
            txtCopies = new TextBox();
            btnClone = new Button();
            lstCustomers = new ListBox();
            btnExit = new Button();
            btnShow = new Button();
            btnBetterShow = new Button();
            SuspendLayout();
            // 
            // lblCustomer
            // 
            lblCustomer.BorderStyle = BorderStyle.Fixed3D;
            lblCustomer.Location = new Point(17, 14);
            lblCustomer.Margin = new Padding(2, 0, 2, 0);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(297, 24);
            lblCustomer.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 59);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 1;
            label1.Text = "Copies:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCopies
            // 
            txtCopies.Location = new Point(94, 56);
            txtCopies.Margin = new Padding(2);
            txtCopies.Name = "txtCopies";
            txtCopies.Size = new Size(59, 23);
            txtCopies.TabIndex = 2;
            // 
            // btnClone
            // 
            btnClone.Location = new Point(175, 56);
            btnClone.Margin = new Padding(2);
            btnClone.Name = "btnClone";
            btnClone.Size = new Size(75, 23);
            btnClone.TabIndex = 3;
            btnClone.Text = "Clone";
            btnClone.UseVisualStyleBackColor = true;
            btnClone.Click += btnClone_Click;
            // 
            // lstCustomers
            // 
            lstCustomers.FormattingEnabled = true;
            lstCustomers.ItemHeight = 15;
            lstCustomers.Location = new Point(17, 97);
            lstCustomers.Margin = new Padding(2);
            lstCustomers.Name = "lstCustomers";
            lstCustomers.Size = new Size(297, 94);
            lstCustomers.TabIndex = 4;
            // 
            // btnExit
            // 
            btnExit.DialogResult = DialogResult.Cancel;
            btnExit.Location = new Point(331, 168);
            btnExit.Margin = new Padding(2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 5;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(254, 56);
            btnShow.Margin = new Padding(2);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(75, 23);
            btnShow.TabIndex = 6;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // btnBetterShow
            // 
            btnBetterShow.Location = new Point(333, 56);
            btnBetterShow.Margin = new Padding(2);
            btnBetterShow.Name = "btnBetterShow";
            btnBetterShow.Size = new Size(75, 23);
            btnBetterShow.TabIndex = 7;
            btnBetterShow.Text = "Better Show";
            btnBetterShow.UseVisualStyleBackColor = true;
            btnBetterShow.Click += btnBetterShow_Click;
            // 
            // Form1
            // 
            AcceptButton = btnClone;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(424, 203);
            Controls.Add(btnBetterShow);
            Controls.Add(btnShow);
            Controls.Add(btnExit);
            Controls.Add(lstCustomers);
            Controls.Add(btnClone);
            Controls.Add(txtCopies);
            Controls.Add(label1);
            Controls.Add(lblCustomer);
            Margin = new Padding(2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clone Customer";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCustomer;
        private Label label1;
        private TextBox txtCopies;
        private Button btnClone;
        private ListBox lstCustomers;
        private Button btnExit;
        private Button btnShow;
        private Button btnBetterShow;
    }
}