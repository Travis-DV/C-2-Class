using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CustomerMaintenance
{
    public class WholesaleCustomer : Customer
    {
        public string Company { get; set; } = "";

        public WholesaleCustomer() { }

        public WholesaleCustomer(string firstName, string lastName, string email) : base(firstName, lastName, email) { }

        public WholesaleCustomer(string firstName, string lastName, string email, string Company) 
            : base(firstName, lastName, email) => this.Company = Company;

        public override string GetDisplayText() => 
            $"{base.GetDisplayText()} {this.Company}";
    }
}
