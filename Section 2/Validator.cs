using System.Text;
using System.Xml.Linq;

namespace StudentScores
{
    static internal class Validator
    {
        static internal bool IsValidScore(string text, string type, int min = 0, int max = 100)
        {
            bool success = true;

            StringBuilder sb = new();
            sb.Append(IsPresent(text, type));
            sb.Append(IsInt32(text, type));
            sb.Append(IsWithinRange(text, type, min, max));
            string errorMsg = sb.ToString();

            if (!String.IsNullOrEmpty(errorMsg))
            {
                success = false;
                MessageBox.Show(errorMsg, "Entry Error");
            }
            return success;
        }

        static internal string IsPresent(string value, string name)
        {
            string errorMsg = "";
            if (String.IsNullOrEmpty(value))
            {
                errorMsg = $"{name} is a required field.\n";
            }
            return errorMsg;
        }

        static internal string IsInt32(string value, string name)
        {
            string errorMsg = "";
            if (!Int32.TryParse(value, out _))
            {
                errorMsg = $"{name} must be a valid integer.\n";
            }
            return errorMsg;
        }

        static internal string IsWithinRange(string value, string name, decimal min, decimal max)
        {
            string errorMsg = "";
            if (Decimal.TryParse(value, out decimal number))
            {
                if (number < min || number > max)
                {
                    errorMsg = $"{name} must be between {min} and {max}.\n";
                }
            }
            return errorMsg;
        }

        static internal bool IsValidName(string text, string type)
        {
            bool success = true;
            string errorMsg = IsPresent(text, type);
            if (!String.IsNullOrEmpty(errorMsg))
            {
                success = false;
                MessageBox.Show(errorMsg, "Entry Error");
            }
            return success;
        }
    }

}