using System.Data.SqlClient;

namespace Proje03_VerilerinNesneyleTasınması;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1-Product list");
        Console.WriteLine("2-Customer list");
        Console.WriteLine("0-Exit");

        Console.Write("Product için 1 or Customer için 2 yi secınız");

        List<Product>products=GetAllProducts();
        foreach (var product in products)
        {
            Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}");
        }
    }
    static List<Product> GetAllProducts()
    {
        List<Product> products = new List<Product>();
        using (var connection = GetSqlConnection())
        {
            try
            {
                connection.Open();
                string queryString = "SELECT ProductId,ProductName,UnitPrice,UnitsInStock FROM Products";
                SqlCommand sqlCommand = new SqlCommand(queryString,connection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {   
                   products.Add(new Product(){
                      Id=int.Parse(sqlDataReader[0].ToString()),
                      Name=sqlDataReader[1].ToString(),
                      Price=decimal.Parse(sqlDataReader[2].ToString()),
                      Stock=int.Parse(sqlDataReader[3].ToString())
                   });
                }
                sqlDataReader.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Bir sorun oluştu");
            
            }
            finally
            {
                connection.Close();
            }
        }
        return products;
    }
    static SqlConnection GetSqlConnection(){
       string connectionString = "Server=DESKTOP-OFVK2FD;Database=Northwind;User=sa;Pwd=123";
       SqlConnection sqlConnection = new SqlConnection(connectionString);
       return sqlConnection;
    }
}
