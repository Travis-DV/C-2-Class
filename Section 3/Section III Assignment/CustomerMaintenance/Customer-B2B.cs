using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CustomerMaintenance
{
    public sealed class Customer_B2B : Customer
    {
        public string Company { get; set; } = "";

        public Customer_B2B() { }

        public Customer_B2B(string firstName, string lastName, string email) : base(firstName, lastName, email) { }

        public Customer_B2B(string firstName, string lastName, string email, string Company) 
            : base(firstName, lastName, email) => this.Company = Company;

        public override string GetDisplayText() => 
            $"{base.GetDisplayText()} {this.Company}";

        public override string GetDisplayTextLong() =>
            $"Wholesale Customer\n{base.GetDisplayTextLong()}\nCompany Name: {this.Company}";
    }
}
