using Dapper;
using Microsoft.Extensions.Options;
using MySqlConnector;
using System.Data;
using Cmr.Pecas.Acessorios.Infra.Context;
public abstract class DatabaseConnection
{
    private readonly string _connectionString;

    protected DatabaseConnection(IOptionsSnapshot<ConnectionString> conectionString)
    {
        _connectionString = conectionString.Value.Conection;
    }

    protected System.Data.IDbConnection CreateConnection()
    {
        var connection = new MySqlConnection(_connectionString);
        connection.Open(); // <=== ESSENCIAL
        return connection;
    }
}
