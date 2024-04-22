namespace OrderOptionsMaintenance
{
    partial class frmMain
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
            lstOrderOptions = new ListBox();
            btnExit = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // lstOrderOptions
            // 
            lstOrderOptions.FormattingEnabled = true;
            lstOrderOptions.ItemHeight = 20;
            lstOrderOptions.Location = new Point(12, 12);
            lstOrderOptions.Name = "lstOrderOptions";
            lstOrderOptions.Size = new Size(620, 284);
            lstOrderOptions.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(728, 267);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(728, 12);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 56);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete Item";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 340);
            Controls.Add(btnDelete);
            Controls.Add(btnExit);
            Controls.Add(lstOrderOptions);
            Name = "frmMain";
            Text = "Main";
            Load += frmMain_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstOrderOptions;
        private Button btnExit;
        private Button btnDelete;
    }
}