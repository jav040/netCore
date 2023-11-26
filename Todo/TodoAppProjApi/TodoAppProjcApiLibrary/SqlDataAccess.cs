using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoAppProjcApiLibrary;

public class SqlDataAccess
{

    private readonly IConfiguration _config;


    public async Task<List<T>> LoadData<T,U>(
        string storedProcedure, 
        U parameters, 
        string connectionStringName)
    {
        string connectionString = _config.GetConnectionString(connectionStringName);
        using IDbConnection connection = new SqlConnection(connectionString);


    }



}
