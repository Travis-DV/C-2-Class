using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMaintenance
{
    public sealed class Customer_B2C : Customer
    {
        public PhoneNumber HomePhone { get; set; } = new();

        public Customer_B2C() { }

        public Customer_B2C(string firstName, string lastName, string email) : base(firstName, lastName, email) { }

        public Customer_B2C(string firstName, string lastName, string email, string HomePhone)
            : base(firstName, lastName, email) => this.HomePhone.PhoneNum = HomePhone;

        public override string GetDisplayText() =>
            $"{base.GetDisplayText()} {this.HomePhone}";

        public override string GetDisplayTextLong() =>
            $"Retail Customer\n{base.GetDisplayTextLong()}\nHome Phone Number: {this.HomePhone}";

    }
}
