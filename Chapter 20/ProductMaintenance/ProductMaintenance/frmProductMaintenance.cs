using ProductMaintenance.Models.DataLayer;

namespace ProductMaintenance;

public partial class frmProductMaintenance : Form
{
    public frmProductMaintenance()
    {
        InitializeComponent();
    }

    // add class variables for the DB context and Product entity 
    MMABooksContext context = new();
    Product selectedProduct = null!;

    private void btnGetProduct_Click(object sender, EventArgs e)
    {
        if (IsValidData())
        {
            try
            {
                string productCode = txtProductCode.Text;

                // get product from database by product code and display; 
                // notify user and clear controls if no product is returned 
                selectedProduct = context.Products.Find(productCode)!;
                if (selectedProduct == null)
                {
                    MessageBox.Show("No product found with this code. " +
                        "Please try again.", "Product Not Found");
                    ClearControls();
                }
                else
                {
                    DisplayProduct();
                }

            }
            catch (Exception ex)
            {
                this.HandleDataAccessError(ex);
            }
        }
    }

    private bool IsValidData()
    {
        bool success = true;
        string errorMessage = "";

        errorMessage = Validator.IsPresent(txtProductCode.Text, "Product Code");
        if (!string.IsNullOrEmpty(errorMessage))
        {
            success = false;
            MessageBox.Show(errorMessage, "Entry Error");
            txtProductCode.Focus();
        }
        return success;
    }

    private void DisplayProduct()
    {
        // display the product information
        txtProductCode.Text = selectedProduct.ProductCode;
        txtDescription.Text = selectedProduct.Description;
        txtUnitPrice.Text = selectedProduct.UnitPrice.ToString("c");
        txtOnHand.Text = selectedProduct.OnHandQuantity.ToString();
        txtProductCode.Focus();
    }

    private void ClearControls()
    {
        txtProductCode.Text = "";
        txtDescription.Text = "";
        txtUnitPrice.Text = "";
        txtOnHand.Text = "";
        txtProductCode.Focus();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        frmAddModify addModifyForm = new()
        {
            IsAdd = true
        };
        DialogResult result = addModifyForm.ShowDialog();  

        if (result == DialogResult.OK)
        {
            try
            {
                // get new product, add to database, display product
                selectedProduct = addModifyForm.Product;
                context.Products.Add(selectedProduct);
                context.SaveChanges();
                DisplayProduct();
            }
            catch (Exception ex)
            {
                HandleDataAccessError(ex);
            }
        }
    }

    private void btnModify_Click(object sender, EventArgs e)
    {
        frmAddModify addModifyForm = new()
        {
            IsAdd = false,
            Product = selectedProduct
            // assign class variable to Product property
        };

        DialogResult result = addModifyForm.ShowDialog();

        if (result == DialogResult.OK)
        {
            try
            {
                // get modified product, update database, display product
                selectedProduct = addModifyForm.Product;
                context.SaveChanges();
                DisplayProduct();
            }
            catch (Exception ex)
            {
                HandleDataAccessError(ex);
            }
        }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        var desc = ""; // get description from class variable
        DialogResult result =
            MessageBox.Show($"Delete {desc}?", "Confirm Delete",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
        {
            try
            {
                // delete product from database, clear controls
                context.Products.Remove(selectedProduct);
                context.SaveChanges();
                ClearControls();
            }
            catch (Exception ex)
            {
                HandleDataAccessError(ex);
            }
        }
    }

    private void HandleDataAccessError(Exception ex)
    {
        // if concurrency error, clear controls if deleted, otherwise display current data

        // display error message in dialog with error type as title
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
