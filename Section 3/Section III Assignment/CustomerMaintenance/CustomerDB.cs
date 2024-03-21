namespace CustomerMaintenance
{
    public static class CustomerDB
    {

        private static string dir = $"{Application.CommonAppDataPath}/CustomerSave/";

        public static void SaveCustomers(List<Customer> customers)
        {
            // create the output stream for a text file that exists
            StreamWriter textOut =
                new StreamWriter(
                new FileStream(dir + "Customers.txt", FileMode.Create, FileAccess.Write));

            // write each customer
            foreach (Customer customer in customers)
            {
                if (customer is Customer_B2B wholesale)
                {
                    WriteB2B(wholesale, textOut);
                }
                else if (customer is Customer_B2C retail)
                {
                    WriteB2C(retail, textOut);
                }
                else if (customer is Customer_C2C C2C)
                {
                    WriteC2C(C2C, textOut);
                }
            }

            // write the end of the document
            textOut.Close();

        }

        public static void WriteB2B(Customer_B2B customer, StreamWriter textOut)
        {
            textOut.Write("B2B" + "|");
            textOut.Write(customer.FirstName + "|");
            textOut.Write(customer.LastName + "|");
            textOut.Write(customer.Email + "|");
            textOut.WriteLine(customer.Company);
        }

        public static void WriteB2C(Customer_B2C customer, StreamWriter textOut)
        {
            textOut.Write("B2C" + "|");
            textOut.Write(customer.FirstName + "|");
            textOut.Write(customer.LastName + "|");
            textOut.Write(customer.Email + "|");
            textOut.WriteLine(customer.HomePhone.SaveText());
        }

        public static void WriteC2C(Customer_C2C customer, StreamWriter textOut)
        {
            textOut.Write("C2C" + "|");
            textOut.Write(customer.FirstName + "|");
            textOut.Write(customer.LastName + "|");
            textOut.Write(customer.Email + "|");
            textOut.WriteLine(customer.HomePhone.SaveText());
        }

        public static List<Customer> GetCustomers()
        {
            // if the directory doesn't exist, create it
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            // create the object for the input stream for a text file
            StreamReader textIn =
                new StreamReader(
                    new FileStream(dir + "Customers.txt", FileMode.OpenOrCreate, FileAccess.Read));

            // create the array list for customers
            List<Customer> customers = new();

            // read the data from the file and store it in the ArrayList
            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine() ?? "";
                string[] columns = row.Split('|');
                if (columns[0] == "B2B")
                {
                    customers.Add(GetB2B(columns));
                }
                else if (columns[0] == "B2C")
                {
                    customers.Add(GetB2C(columns));
                }
                else if (columns[0] == "C2C")
                {
                    customers.Add(GetC2C(columns));
                }
            }

            textIn.Close();

            return customers;
        }

        public static Customer_B2B GetB2B(string[] columns)
        {
            Customer_B2B customer = new()
            {
                FirstName = columns[1],
                LastName = columns[2],
                Email = columns[3],
                Company = columns[4]
            };
            return customer;
        }

        public static Customer_B2C GetB2C(string[] columns)
        {
            Customer_B2C customer = new()
            {
                FirstName = columns[1],
                LastName = columns[2],
                Email = columns[3],
                HomePhone = new PhoneNumber(columns[4])
            };
            return customer;
        }

        public static Customer_C2C GetC2C(string[] columns)
        {
            Customer_C2C customer = new()
            {
                FirstName = columns[1],
                LastName = columns[2],
                Email = columns[3],
                HomePhone = new PhoneNumber(columns[4])
            };
            return customer;
        }
    }
}
