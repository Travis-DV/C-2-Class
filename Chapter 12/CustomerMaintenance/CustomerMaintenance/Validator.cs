namespace CustomerMaintenance
{
    public static class Validator
    {
        
        //Removed most validations because they didn't return a true or false and were useless therein
        //also removed "LineEnd" variable because it was useless just type "\n"

        public static bool IsPresent(string value)
        {
            return !string.IsNullOrEmpty(value);
        }

        public static bool IsValidEmail(string value)
        {
            if (value.Contains('@') && value.Contains('.'))
            {
                return true;
            }
            return false;
        }

        public static bool IsValidPhoneNumber(string value)
        {
            while (value.Contains("-"))
            {
                value.Replace("-", "");
            }
            if (value.Length == 10)
            {
                
                return true;
            }
            return false;
        }
    }
}
