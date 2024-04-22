using CustomerMaintenance.Models.DataLayer;

namespace CustomerMaintenance;

public partial class frmCustomerMaintenance : Form
{
    public frmCustomerMaintenance()
    {
        InitializeComponent();
    }

    private MMABooksDataAccess data = new();
    private Customer selectedCustomer = null!;

    // private constants for the index values of the Modify and Delete button columns
    private const int ModifyIndex = 6;
    private const int DeleteIndex = 7;
    private const int MaxRows = 10;
    private int totalRows = 0;
    private int pages = 0;
    private int pageNumber = 1;

    private void frmCustomerDisplay_Load(object sender, EventArgs e)
    {
        totalRows = data.CustomerCount;

        pages = totalRows / MaxRows;
        if (totalRows % MaxRows != 0)
        {
            pages += 1;
        }
        pageNumber = 1;
        DisplayCustomers();
    }

    private void DisplayCustomers()
    {
        // get customers and bind grid
        DGVCustomers.Columns.Clear();
        //DGVCustomers.DataSource = data.GetCustomers();

        int skip = MaxRows * (pageNumber - 1);
        int take = MaxRows;

        if (pageNumber == pages)
        {
            take = totalRows - skip;
        }
        if (totalRows <= MaxRows)
        {
            take = totalRows;
        }
        DGVCustomers.DataSource = data.GetCustomers(skip, take);

        // format grid
        DGVCustomers.Columns[0].Visible = false;
        DGVCustomers.Columns[1].Width = 150;
        DGVCustomers.Columns[2].Width = 150;
        DGVCustomers.Columns[5].HeaderText = "Zip Code";
        DGVCustomers.AlternatingRowsDefaultCellStyle.BackColor = Color.Green;
        DGVCustomers.EnableHeadersVisualStyles = false;
        DGVCustomers.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGreen;
        DGVCustomers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        DataGridViewButtonColumn modifyColumn = new()
        {
            UseColumnTextForButtonValue = true,
            HeaderText = "",
            Text = "Modify"
        };
        DGVCustomers.Columns.Insert(ModifyIndex, modifyColumn);

        DataGridViewButtonColumn deleteColumn = new()
        {
            UseColumnTextForButtonValue = true,
            HeaderText = "",
            Text = "Delete"
        };
        DGVCustomers.Columns.Insert(DeleteIndex, deleteColumn);
    }

    private void  EnableDisableButtons()
    {
        if (pageNumber == 1)
        {
            BTFirst.Enabled = false;
            BTPrevious.Enabled = false;
        }
        else
        {
            BTFirst.Enabled = true;
            BTPrevious.Enabled = true;
        }

        if (pageNumber == pages)
        {
            BTNext.Enabled = false;
            BTLast.Enabled = false;
        }
        else
        {
            BTNext.Enabled = true;
            BTLast.Enabled = true;
        }
    }

    private void ModifyCustomer()
    {
        frmAddModifyCustomer addModifyCustomerForm = new()
        {
            Customer = selectedCustomer,
            States = data.GetStates()
        };

        DialogResult result = addModifyCustomerForm.ShowDialog();
        if (result == DialogResult.OK)
        {
            try
            {
                selectedCustomer = addModifyCustomerForm.Customer;
                data.UpdateCustomer(selectedCustomer);
                DisplayCustomers();
            }
            catch (DataAccessException ex)
            {
                HandleDataAccessError(ex);
            }
        }
    }

    private void DeleteCustomer()
    {
        DialogResult result =
            MessageBox.Show($"Delete {selectedCustomer.Name}?",
            "Confirm Delete",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
        {
            try
            {
                data.RemoveCustomer(selectedCustomer);
                DisplayCustomers();
            }
            catch (DataAccessException ex)
            {
                HandleDataAccessError(ex);
            }
        }
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        frmAddModifyCustomer addModifyCustomerForm = new()
        {
            States = data.GetStates()
        };
        DialogResult result = addModifyCustomerForm.ShowDialog();
        if (result == DialogResult.OK)
        {
            try
            {
                selectedCustomer = addModifyCustomerForm.Customer;
                data.AddCustomer(selectedCustomer);
                DisplayCustomers();
            }
            catch (DataAccessException ex)
            {
                HandleDataAccessError(ex);
            }
        }
    }

    private void HandleDataAccessError(DataAccessException ex)
    {
        // if concurrency conflict, re-display products
        if (ex.IsConcurrencyError)
        {
            DisplayCustomers();
        }

        // display error message in dialog with error type as title
        MessageBox.Show(ex.Message, ex.ErrorType);
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void DGVCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex > -1)
        {
            if (e.ColumnIndex == ModifyIndex || e.ColumnIndex == DeleteIndex)
            {
                int customerID = Convert.ToInt32(DGVCustomers.Rows[e.RowIndex].Cells[0].Value);
                selectedCustomer = data.FindCustomer(customerID);
            }

            if (selectedCustomer != null)
            {
                if (e.ColumnIndex == ModifyIndex)
                {
                    ModifyCustomer();
                }
                else if (e.ColumnIndex == DeleteIndex)
                {
                    DeleteCustomer();
                }
            }
        }
    }

    private void BTFirst_Click(object sender, EventArgs e)
    {
        pageNumber = 1;
        DisplayCustomers();
    }

    private void BTPrevious_Click(object sender, EventArgs e)
    {
        pageNumber--;
        DisplayCustomers();
    }

    private void BTNext_Click(object sender, EventArgs e)
    {
        pageNumber++;
        DisplayCustomers();
    }

    private void BTLast_Click(object sender, EventArgs e)
    {
        pageNumber = pages;
        DisplayCustomers();
    }
}
