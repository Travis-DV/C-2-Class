SELECT Address1 
FROM Address 
WHERE State = "Missouri";

SELECT Sum(InvoiceAmount) AS Total 
FROM Invoice 
WHERE YEAR(InvoiceDate) = 2022;

SELECT *
FROM Customer
ORDER BY Phone DESC;

SELECT Sum(InvoiceAmount) AS Total
FROM Invoice
INNER JOIN Customer ON Invoice.CustomerID = Customer.CustomerID
INNER JOIN Address ON Customer.AddressID = Address.AddressID
WHERE Address.ZipCode = '63101';

SELECT Count(*) AS Total
FROM Invoice
INNER JOIN Customer ON Invoice.CustomerID = Customer.CustomerID
INNER JOIN Address ON Customer.AddressID = Address.AddressID
WHERE Address.State = 'Illinois';