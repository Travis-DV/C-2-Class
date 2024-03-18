namespace StudentScores
{
    partial class frmAddUpdateScore
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
            txtScore = new TextBox();
            btnAddUpdate = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 22);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Score:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtScore
            // 
            txtScore.Location = new Point(67, 19);
            txtScore.Margin = new Padding(2);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(101, 23);
            txtScore.TabIndex = 1;
            // 
            // btnAddUpdate
            // 
            btnAddUpdate.Location = new Point(21, 50);
            btnAddUpdate.Margin = new Padding(2);
            btnAddUpdate.Name = "btnAddUpdate";
            btnAddUpdate.Size = new Size(69, 23);
            btnAddUpdate.TabIndex = 2;
            btnAddUpdate.Text = "&Add";
            btnAddUpdate.UseVisualStyleBackColor = true;
            btnAddUpdate.Click += btnAddUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(99, 50);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(69, 23);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmAddUpdateScore
            // 
            AcceptButton = btnAddUpdate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(194, 86);
            ControlBox = false;
            Controls.Add(btnCancel);
            Controls.Add(btnAddUpdate);
            Controls.Add(txtScore);
            Controls.Add(label1);
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAddUpdateScore";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Score";
            Load += frmAddUpdateScore_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtScore;
        private Button btnAddUpdate;
        private Button btnCancel;
    }
}