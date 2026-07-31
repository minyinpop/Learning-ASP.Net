using Learning_ASP.Net.Models;
using Microsoft.Data.Sqlite;

namespace Learning_ASP.Net.Database.Account;

public static class AccountDatabase
{
    private const string _filePath = "Data Source=Database/Account/Account.db";
    private const string _tableName = "Account";

    public static void Initialize()
    {
        using var connection = new SqliteConnection(_filePath);
        
        connection.Open();
        
        var command = connection.CreateCommand();

        command.CommandText = $"""
                               CREATE TABLE IF NOT EXISTS {_tableName}
                               (
                                   ID INTEGER PRIMARY KEY AUTOINCREMENT,
                                   CreatedAt TIMESTAMP,
                                   Email TEXT,
                                   Username TEXT,
                                   Password TEXT
                               )
                               """;
        
        command.ExecuteNonQuery();
    }

    public static AccountDatabaseResult CreateData(AccountInformationModel account)
    {
        using var connection = new SqliteConnection(_filePath);
        
        connection.Open();
        
        var command = connection.CreateCommand();

        if (DataExists(account))
        {
            Console.WriteLine("已經有這筆帳戶資料了。");
            return AccountDatabaseResult.AccountIsAlreadyExists;
        }
        
        command.CommandText = $"""
                               INSERT INTO {_tableName}
                               (
                                   CreatedAt,
                                   Email,
                                   Username,
                                   Password
                               )
                               VALUES
                               (
                                   CURRENT_TIMESTAMP,
                                   @Email,
                                   @Username,
                                   @Password
                               )
                               """;

        command.Parameters.AddWithValue("@Email", account.Email);
        command.Parameters.AddWithValue("@Username", account.Username);
        command.Parameters.AddWithValue("@Password", account.Password);

        command.ExecuteNonQuery();
        
        return AccountDatabaseResult.AccountRegisterSuccessfully;
    }

    private static bool DataExists(AccountInformationModel account)
    {
        using var connection = new SqliteConnection(_filePath);
        
        connection.Open();

        var command = connection.CreateCommand();
        
        command.CommandText = $"""
                               SELECT 1
                               FROM {_tableName}
                               WHERE Email = @Email
                               LIMIT 1
                               """;

        command.Parameters.AddWithValue("@Email", account.Email);

        using var reader = command.ExecuteReader();
        
        return reader.Read();
    }
}