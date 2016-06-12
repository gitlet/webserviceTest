using System;
using System.Data;
using System.Data.SqlClient;

public class Test
{
	public static void Main(string[] args)
	{
		string connectionString =
			"Data Source=86.96.194.194,1433;" +
			"Initial Catalog=Tracking_db;" +
			"User ID=jins;" +
			"Password=gl_programmer2;";
		IDbConnection dbcon;
		using (dbcon = new SqlConnection(connectionString)) {
			dbcon.Open();
			using (IDbCommand dbcmd = dbcon.CreateCommand()) {
				string sql =
					"SELECT * FROM View_LiveVehicleSignal";
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