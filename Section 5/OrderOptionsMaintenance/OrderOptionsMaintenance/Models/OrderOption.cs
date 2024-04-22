using System.Diagnostics;

namespace OrderOptionsMaintenance.Models
{
    //STEP 5: CREATE IDisplayable INTERFACE (SEPARATE FILE) FIRST
    //STEP 6: IMPLEMENT IDisplayable HERE
    public partial class OrderOption : IDisplayable
    {
        public int OptionId { get; set; }
        public decimal SalesTaxRate { get; set; }
        public decimal FirstBookShipCharge { get; set; }
        public decimal AdditionalBookShipCharge { get; set; }

        //STEP 6 DEFINE GetDisplayText() HERE
        public string GetDisplayText() => $"{OptionId} {SalesTaxRate:c} {FirstBookShipCharge:c} {AdditionalBookShipCharge:c})";
    }
}