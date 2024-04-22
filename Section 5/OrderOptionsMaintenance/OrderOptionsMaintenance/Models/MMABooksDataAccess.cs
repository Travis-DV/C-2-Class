using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace OrderOptionsMaintenance.Models
{
    public class MMABooksDataAccess
    {
        private string ConnectionString =>
            ConfigurationManager.ConnectionStrings["MMABooks"].ConnectionString;
        
        public OrderOption GetOrderOptions()
        {
            string selectStatement = "SELECT OptionID, SalesTaxRate, FirstBookShipCharge, AdditionalBookShipCharge " +
                                     "FROM OrderOptions";

            using SqlConnection connection = new(ConnectionString);
            using SqlCommand command = new(selectStatement, connection);
            connection.Open();

            OrderOption options = null!;
            using SqlDataReader reader = command.ExecuteReader(
                CommandBehavior.SingleRow & CommandBehavior.CloseConnection);
            if (reader.Read())
            {
                options = new OrderOption
                {
                    OptionId = (int)reader["OptionID"],
                    SalesTaxRate = (decimal)reader["SalesTaxRate"],
                    FirstBookShipCharge = (decimal)reader["FirstBookShipCharge"],
                    AdditionalBookShipCharge = (decimal)reader["AdditionalBookShipCharge"]
                };
            }
            return options;
        }

        ////STEP 7, CODE GetOrderOptionsAll() HERE
        public OrderOptionList GetOrderOptionsAll()
        {
            OrderOptionList orderOptionList = new();

            string selectStatement = "SELECT OptionID, SalesTaxRate, FirstBookShipCharge, AdditionalBookShipCharge " +
                                     "FROM OrderOptions";

            using SqlConnection connection = new(ConnectionString);
            using SqlCommand command = new(selectStatement, connection);
            connection.Open();

            OrderOption options = null!;
            using SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                options = new OrderOption
                {
                    OptionId = (int)reader["OptionID"],
                    SalesTaxRate = (decimal)reader["SalesTaxRate"],
                    FirstBookShipCharge = (decimal)reader["FirstBookShipCharge"],
                    AdditionalBookShipCharge = (decimal)reader["AdditionalBookShipCharge"]
                };
                orderOptionList += options;
            }
            return orderOptionList;
        }

        public void UpdateOrderOptions(OrderOption options)
        {
            try
            {
                string updateStatement = "UPDATE OrderOptions SET " +
                    "SalesTaxRate = @SalesTaxRate, " +
                    "FirstBookShipCharge = @FirstBookShipCharge, " +
                    "AdditionalBookShipCharge = @AdditionalBookShipCharge " +
                    "WHERE OptionID = @OptionId";

                using SqlConnection connection = new(ConnectionString);
                using SqlCommand command = new(updateStatement, connection);
                command.Parameters.AddWithValue("@SalesTaxRate", options.SalesTaxRate);
                command.Parameters.AddWithValue("@FirstBookShipCharge", options.FirstBookShipCharge);
                command.Parameters.AddWithValue("@AdditionalBookShipCharge", options.AdditionalBookShipCharge);
                command.Parameters.AddWithValue("@OptionId", options.OptionId);
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new DataAccessException(ex.Message, "Update Error");
            }
        }

        //STEP 8, CODE AddOrderOptions() HERE
        public void AddOrderOptions(OrderOption options)
        {
            try
            {
                string updateStatement = "INSERT INTO OrderOptions (SalesTaxRate, FirstBookShipCharge, AdditionalBookShipCharge)\r\nVALUES (@SalesTaxRate, @FirstBookShipCharge, @AdditionalBookShipCharge)\r\n";

                using SqlConnection connection = new(ConnectionString);
                using SqlCommand command = new(updateStatement, connection);
                command.Parameters.AddWithValue("@SalesTaxRate", options.SalesTaxRate);
                command.Parameters.AddWithValue("@FirstBookShipCharge", options.FirstBookShipCharge);
                command.Parameters.AddWithValue("@AdditionalBookShipCharge", options.AdditionalBookShipCharge);
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new DataAccessException(ex.Message, "Add Error");
            }
        }

        //STEP 9, CODE DeleteOrderOptions() HERE
        public void DeleteOrderOptions(OrderOption options)
        {
            try
            {
                string updateStatement = "DELETE FROM OrderOptions WHERE OptionID = @OptionId";

                using SqlConnection connection = new(ConnectionString);
                using SqlCommand command = new(updateStatement, connection);
                command.Parameters.AddWithValue("@OptionId", options.OptionId);
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new DataAccessException(ex.Message, "Add Error");
            }
        }

    }

    public class DataAccessException : Exception
    {
        public DataAccessException(string msg, string errorType) : base(msg) =>
            ErrorType = errorType;

        public string ErrorType { get; init; }
    }
}
