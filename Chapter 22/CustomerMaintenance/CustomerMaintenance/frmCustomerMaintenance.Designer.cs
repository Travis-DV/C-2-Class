namespace CustomerMaintenance;

partial class frmCustomerMaintenance
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
        btnExit = new Button();
        btnAdd = new Button();
        DGVCustomers = new DataGridView();
        BTFirst = new Button();
        BTNext = new Button();
        BTPrevious = new Button();
        BTLast = new Button();
        ((System.ComponentModel.ISupportInitialize)DGVCustomers).BeginInit();
        SuspendLayout();
        // 
        // btnExit
        // 
        btnExit.Location = new Point(843, 303);
        btnExit.Margin = new Padding(2);
        btnExit.Name = "btnExit";
        btnExit.Size = new Size(75, 23);
        btnExit.TabIndex = 1;
        btnExit.Text = "Exit";
        btnExit.UseVisualStyleBackColor = true;
        btnExit.Click += btnExit_Click;
        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(16, 303);
        btnAdd.Margin = new Padding(2);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(75, 23);
        btnAdd.TabIndex = 0;
        btnAdd.Text = "Add";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += btnAdd_Click;
        // 
        // DGVCustomers
        // 
        DGVCustomers.AllowUserToAddRows = false;
        DGVCustomers.AllowUserToDeleteRows = false;
        DGVCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        DGVCustomers.Location = new Point(12, 12);
        DGVCustomers.Name = "DGVCustomers";
        DGVCustomers.ReadOnly = true;
        DGVCustomers.RowTemplate.Height = 25;
        DGVCustomers.Size = new Size(905, 277);
        DGVCustomers.TabIndex = 2;
        DGVCustomers.CellClick += DGVCustomers_CellClick;
        // 
        // BTFirst
        // 
        BTFirst.Location = new Point(326, 306);
        BTFirst.Name = "BTFirst";
        BTFirst.Size = new Size(75, 23);
        BTFirst.TabIndex = 3;
        BTFirst.Text = "<<";
        BTFirst.UseVisualStyleBackColor = true;
        BTFirst.Click += BTFirst_Click;
        // 
        // BTNext
        // 
        BTNext.Location = new Point(488, 306);
        BTNext.Name = "BTNext";
        BTNext.Size = new Size(75, 23);
        BTNext.TabIndex = 4;
        BTNext.Text = ">";
        BTNext.UseVisualStyleBackColor = true;
        BTNext.Click += BTNext_Click;
        // 
        // BTPrevious
        // 
        BTPrevious.Location = new Point(407, 306);
        BTPrevious.Name = "BTPrevious";
        BTPrevious.Size = new Size(75, 23);
        BTPrevious.TabIndex = 5;
        BTPrevious.Text = "<";
        BTPrevious.UseVisualStyleBackColor = true;
        BTPrevious.Click += BTPrevious_Click;
        // 
        // BTLast
        // 
        BTLast.Location = new Point(569, 306);
        BTLast.Name = "BTLast";
        BTLast.Size = new Size(75, 23);
        BTLast.TabIndex = 6;
        BTLast.Text = ">>";
        BTLast.UseVisualStyleBackColor = true;
        BTLast.Click += BTLast_Click;
        // 
        // frmCustomerMaintenance
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        CancelButton = btnExit;
        ClientSize = new Size(929, 341);
        Controls.Add(BTLast);
        Controls.Add(BTPrevious);
        Controls.Add(BTNext);
        Controls.Add(BTFirst);
        Controls.Add(DGVCustomers);
        Controls.Add(btnAdd);
        Controls.Add(btnExit);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Margin = new Padding(2);
        Name = "frmCustomerMaintenance";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Customer Maintenance";
        Load += frmCustomerDisplay_Load;
        ((System.ComponentModel.ISupportInitialize)DGVCustomers).EndInit();
        ResumeLayout(false);
    }

    #endregion
    private Button btnExit;
    private Button btnAdd;
    private DataGridView DGVCustomers;
    private Button BTFirst;
    private Button BTNext;
    private Button BTPrevious;
    private Button BTLast;
}