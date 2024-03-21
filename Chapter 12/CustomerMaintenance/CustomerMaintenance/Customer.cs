using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMaintenance
{
    public struct Customer
    {

        #region CustomerDataVariables
        public string FirstName;
        public string LastName;
        public string Email;
        public string PhoneNumber;
        #endregion

        public Customer(string FirstName, string LastName, string Email, string PhoneNumber)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.PhoneNumber = PhoneNumber;
        }

        //Instead of GetDisplayText() I overwrote the ToString() method because it makes more sence to me as a name and function
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

        //Prints all info kinda hard to read in listbox so I made it so that if you click on a name in the listbox it opens a message box with this info
        public string ToStringLong()
        {
            return $"Name: {FirstName} {LastName}\nEmail: {Email}\nPhone Number: {PhoneNumber}";
        }

    }
}
