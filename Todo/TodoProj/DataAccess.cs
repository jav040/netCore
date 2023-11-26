using System;
using System.Runtime.InteropServices;

public class DataAccess
{
	string connectionString = 'Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TodoDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False'
	sqlConnection conn = new sqlConnection(connectionString);
    conn.Open();

    public DataAccess()
	{
		throw NotImplementedException();
	}

	public getId()
	{

	}

}
