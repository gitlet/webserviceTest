using System;
using System.Data;
using System.Data.SqlClient;

public class Test
{
	public static void Main(string[] args)
	{
		string connectionString =
			"Data Source=192.168.1.5,1433;" +
			"Initial Catalog=Test;" +
			"User ID=DevUser;" +
			"Password=Admin@123;";
		IDbConnection dbcon;
		using (dbcon = new SqlConnection(connectionString)) {
			dbcon.Open();
			using (IDbCommand dbcmd = dbcon.CreateCommand()) {
				string sql =
					"SELECT * FROM VehicleDetails";
				dbcmd.CommandText = sql;
				//using (IDataReader reader = dbcmd.ExecuteReader()) {
				//	while(reader.Read()) {
				//		string FirstName = (string) reader["fname"];
				//		string LastName = (string) reader["lname"];
				//		Console.WriteLine("Name: " +
				//			FirstName + " " + LastName);
				//	}
				//}
			}
		}
	}
}