using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMaintenance
{
    public class PhoneNumber
    {
        private string[] Parts = new string[] { "#", "###", "###", "####" };

        private string temp = "";

        public string PhoneNum
        {
            get => $"+{Parts[0]} ({Parts[1]}) {Parts[2]}-{Parts[3]}";
            set
            {
                temp = value;
                Parts[3] = $"{temp[^4]}{temp[^3]}{temp[^2]}{temp[^1]}";
                temp = temp.Replace(Parts[3], "");
                Parts[2] = $"{temp[^3]}{temp[^2]}{temp[^1]}";
                temp = temp.Replace(Parts[2], "");
                Parts[1] = $"{temp[^3]}{temp[^2]}{temp[^1]}";
                temp = temp.Replace(Parts[1], "");
                if (temp.Length != 0) { Parts[0] = temp; }
                else { Parts[0] = "1";  }
            }
        }

        public PhoneNumber() { }

        public PhoneNumber(string PhoneNum) =>
            this.PhoneNum = PhoneNum;

        public override string ToString() => this.PhoneNum;

        public string SaveText() => $"{Parts[0]}{Parts[1]}{Parts[2]}{Parts[3]}";
    }
}
