using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace SQL
{
  class Program
  {
    static void Main(string[] args)
    {
      //a connection string is essentially the information you need to connect to the database
      var connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SqlForAustin;
Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;
ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

      //ADO.NET
      var customerList = new List<Customer>();

      //this is creating a sqlconnection object that passes in the connection info needed
      var connection = new SqlConnection(connectionString);
      var queryString = "SELECT * FROM CUSTOMERS";
      var command = new SqlCommand(queryString, connection);

      connection.Open();
      SqlDataReader reader = command.ExecuteReader();
      while (reader.Read())
      {
        customerList.Add(new Customer
        { Id = (int)reader[0], FirstName = (string)reader[1], LastName = (string)reader[2] });
      }
      reader.Close();
      connection.Close();

      foreach (var item in customerList)
      {
        Console.WriteLine(item.FirstName);
      }

      //Dapper without using statement, if an exception is thrown could have too many open connections causing issues.

      var conn = new SqlConnection(connectionString);
      var dapperList = conn.Query<Customer>(queryString).ToList();
      foreach (var item in dapperList)
      {
        Console.WriteLine(item.FirstName);
      }

      var dapperList2 = new List<Customer>();

      //Dapper with a using statement, the connection will always be destroyed even with an exception
      using (var conn2 = new SqlConnection(connectionString))
      {
        dapperList2 = conn2.Query<Customer>(queryString).ToList();
      }

      foreach (var item in dapperList2)
      {
        Console.WriteLine(item.FirstName);
      }

    }
  }
}
