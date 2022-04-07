using System.Data.SqlClient;
using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace DataAccess.DbAccess;

public class SQLDataAcces
{
    private readonly IConfiguration _confiq;
    public SQLDataAcces(IConfiguration confiq)
    {
        _confiq = confiq;  
    }

    public async Task<IEnumerable<T>> LoadData<T, U>(
        string storedProcedure,
        U parameters,
        string connectionId = "Default")
    {
        using IDbConnection connection = new SqlConnection(_confiq.GetConnectionString(connectionId));
    }
}