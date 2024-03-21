namespace InvoiceTotal
{
    public partial class frmInvoiceTotal : Form
    {
        public frmInvoiceTotal()
        {
            InitializeComponent();
        }

        private decimal[] InvoiceTotalsArray = new decimal[10];
        private int InvoiceIndex = 0;

        private List<decimal> InvoiceTotalsList = new List<decimal>();

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string customerType = txtCustomerType.Text;
            decimal subtotal = Convert.ToDecimal(txtSubtotal.Text);
            decimal discountPct = 0m;

            if (customerType == "R")
            {
                if (subtotal < 100)
                    discountPct = .0m;
                else if (subtotal >= 100 && subtotal < 250)
                    discountPct = .1m;
                else if (subtotal >= 250)
                    discountPct = .25m;
            }
            else if (customerType == "C")
            {
                if (subtotal < 250)
                    discountPct = .2m;
                else
                    discountPct = .3m;
            }
            else
            {
                discountPct = .4m;
            }

            decimal discountAmt = subtotal * discountPct;
            decimal invoiceTotal = subtotal - discountAmt;


            this.InvoiceTotalsArray[this.InvoiceIndex] = invoiceTotal;
            this.InvoiceIndex++;

            this.InvoiceTotalsList.Add(invoiceTotal);

            txtDiscountPct.Text = discountPct.ToString("p1");
            txtDiscountAmt.Text = discountAmt.ToString("c");
            txtTotal.Text = invoiceTotal.ToString("c");

            txtCustomerType.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Array.Sort(this.InvoiceTotalsArray);
            string ArrayTotals = "";
            foreach (decimal invoiceTotal in InvoiceTotalsArray)
            {
                if (invoiceTotal != 0)
                {
                    ArrayTotals += invoiceTotal.ToString("c");
                    ArrayTotals += "\n";
                }
            }

            string ListTotals = "";
            foreach (decimal invoiceTotal in InvoiceTotalsArray)
            {
                if (invoiceTotal != 0)
                {
                    ListTotals += invoiceTotal.ToString("c");
                    ListTotals += "\n";
                }
            }

            MessageBox.Show(ArrayTotals, "Order Totals - Array");
            MessageBox.Show(ListTotals, "Order Totals - List");
            this.Close();
        }
    }
}