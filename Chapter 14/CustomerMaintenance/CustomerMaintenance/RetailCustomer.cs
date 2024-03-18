using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMaintenance
{
    public class RetailCustomer : Customer
    {
        public string HomePhone { get; set; } = "";

        public RetailCustomer() { }

        public RetailCustomer(string firstName, string lastName, string email) : base(firstName, lastName, email) { }

        public RetailCustomer(string firstName, string lastName, string email, string HomePhone)
            : base(firstName, lastName, email) => this.HomePhone = HomePhone;

        public override string GetDisplayText() =>
            $"{base.GetDisplayText()} {this.HomePhone}";

    }
}
