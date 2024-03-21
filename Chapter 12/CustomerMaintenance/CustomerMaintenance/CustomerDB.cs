using System.Windows.Forms;

namespace CustomerMaintenance
{
    public static class CustomerDB
    {

        //Made the path vairable and removed the variables up here because they threw errors 
        public static void SaveCustomers(List<Customer> customers)
        {
            // create the output stream for a text file that exists
            StreamWriter textOut =
                new StreamWriter(
                new FileStream($"{System.Windows.Forms.Application.StartupPath}/Customers.txt", FileMode.Create, FileAccess.Write));

            // write each customer
            foreach (Customer customer in customers)
            {
                textOut.Write(customer.FirstName + "|");
                textOut.Write(customer.LastName + "|");
                textOut.Write(customer.Email + "|");
                textOut.WriteLine(customer.PhoneNumber);
            }

            // write the end of the document
            textOut.Close();
        }

        public static List<Customer> GetCustomers()
        {
            // if the directory doesn't exist, create it
            if (!File.Exists($"{System.Windows.Forms.Application.StartupPath}/Customers.txt"))
                File.Create($"{System.Windows.Forms.Application.StartupPath}/Customers.txt");

            // create the object for the input stream for a text file
            StreamReader textIn =
                new StreamReader(
                    new FileStream($"{System.Windows.Forms.Application.StartupPath}/Customers.txt", FileMode.OpenOrCreate, FileAccess.Read));

            // create the array list for customers
            List<Customer> customers = new List<Customer>();

            // read the data from the file and store it in the ArrayList
            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine() ?? "";
                string[] columns = row.Split('|');
                Customer customer = new Customer(columns[0], columns[1], columns[2], columns[3]);
                customers.Add(customer);
            }

            textIn.Close();

            return customers;
        }
    }
}
