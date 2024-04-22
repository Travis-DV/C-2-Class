using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using System.Configuration;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProductMaintenance.Models.DataLayer;

public class MMABooksDataAccess
{
    // the code to get the connection string
    private string ConnectionString =>
        ConfigurationManager.ConnectionStrings["MMABooks"].ConnectionString;

    public Product? FindProduct(string productCode)
    {
        try
        {
            Product product = null!; // default return value

            // the code to get the product
            string sqlSelect = "SELECT ProductCode, Description, UnitPrice, OnHandQuantity, Rowversion FROM Products WHERE ProductCode = @ProductCode";

            using SqlConnection connection = new(ConnectionString);
            using SqlCommand command = new(sqlSelect, connection);
            command.Parameters.AddWithValue("@ProductCode", productCode);
            connection.Open();
            using SqlDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow & CommandBehavior.CloseConnection);

            if (reader.Read())
            {
                product = new()
                {
                    ProductCode = reader["ProductCode"].ToString()!,
                    Description = reader["Description"].ToString()!,
                    UnitPrice = (decimal)reader["UnitPrice"],
                    OnHandQuantity = (int)reader["OnHandQuantity"],
                    Rowversion = (byte[])reader["Rowversion"]
                };
            }

            

            return product;
        }
        catch (SqlException ex)
        {
            throw CreateDataAccessException(ex);
        }
        catch (Exception e)
        {
            return null;
        }
    }

    public void AddProduct(Product product)
    {
        try
        {
            string sqlCommand = "INSERT Products (ProductCode, Description, UnitPrice, OnHandQuantity) VALUES (@ProductCode, @Description, @UnitPrice, @OnHandQuantity)";

            using SqlConnection connection = new(ConnectionString);
            using SqlCommand command = new(sqlCommand, connection);
            command.Parameters.AddWithValue("@ProductCode", product.ProductCode);
            command.Parameters.AddWithValue("@Description", product.Description);
            command.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@OnHandQuantity", product.OnHandQuantity);

            connection.Open();
            int count = command.ExecuteNonQuery();

            if (count > 0)
            {
                Refresh(product);
            }
        }
        catch (SqlException ex)
        {
            throw CreateDataAccessException(ex);
        }
        catch (Exception e)
        {
            return;
        }
    }

    private string Refresh(Product product)
    {
        Product current = FindProduct(product.ProductCode)!;

        if (current == null)
        {
            return "Deleted";
        }
        else
        {

            product.ProductCode = current.ProductCode;
            product.Description = current.Description;
            product.UnitPrice = current.UnitPrice;
            product.OnHandQuantity = current.OnHandQuantity;
            product.Rowversion = current.Rowversion;

            return "Updated";
        }
    }

    public void UpdateProduct(Product product)
    {
        try
        {
            // the code to update the product
            string sqlCommand = "UPDATE Products SET Description = @NewDescription, UnitPrice = @NewUnitPrice, OnHandQuantity = @NewOnHandQuantity WHERE ProductCode = @ProductCode AND Rowversion = @Rowversion";

            using SqlConnection connection = new(ConnectionString);
            using SqlCommand command = new(sqlCommand, connection);
            command.Parameters.AddWithValue("@ProductCode", product.ProductCode);
            command.Parameters.AddWithValue("@NewDescription", product.Description);
            command.Parameters.AddWithValue("@NewUnitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@NewOnHandQuantity", product.OnHandQuantity);
            command.Parameters.AddWithValue("@Rowversion", product.Rowversion);
            connection.Open();

            int count = command.ExecuteNonQuery();

            string status = Refresh(product);
            if (count == 0)
            {
                throw CreateConcurrencyException(status);
            }
        }
        catch (SqlException ex)
        {
            throw CreateDataAccessException(ex);
        }
        catch (Exception e)
        {
            return;
        }
    }

    public void RemoveProduct(Product product)
    {
        try
        {
            // the code to delete the product
            string sqlCommand = "DELETE FROM Products WHERE ProductCode = @ProductCode AND Rowversion = @Rowversion";

            using SqlConnection connection = new(ConnectionString);
            using SqlCommand command = new(sqlCommand, connection);
            command.Parameters.AddWithValue("@ProductCode", product.ProductCode);
            command.Parameters.AddWithValue("@Rowversion", product.Rowversion);
            connection.Open();

            int count = command.ExecuteNonQuery();

            if (count == 0)
            {
                string status = Refresh(product);
                throw CreateConcurrencyException(status);
            }
        }
        catch (SqlException ex)
        {
            throw CreateDataAccessException(ex);
        }
        catch (Exception e)
        {
            return;
        }
    }

    private DataAccessException CreateConcurrencyException(string status)
    {
        string msg = "";
        if (status.ToLower() == "deleted")
            msg = "Another user has deleted that record.";
        else
            msg = "Another user has updated that record.\n" +
            "The current database values will be displayed.";

        return new DataAccessException(msg, "Concurrency Error");
    }

    private DataAccessException CreateDataAccessException(SqlException ex)
    {
        string msg = "";
        foreach (SqlError error in ex.Errors)
        {
            msg += $"ERROR CODE {error.Number}: {error.Message}\n";
        }

        return new DataAccessException(msg, "Database Error");
    }

    public void ConcurrencySimulation(string productCode)
    {
        string updateStatement =
            "UPDATE Products SET OnHandQuantity = -1 " +
            "WHERE ProductCode = @ProductCode";

        using SqlConnection connection = new(ConnectionString);
        using SqlCommand command = new(updateStatement, connection);
        command.Parameters.AddWithValue("@ProductCode", productCode);
        connection.Open();
        command.ExecuteNonQuery();
    }
}
