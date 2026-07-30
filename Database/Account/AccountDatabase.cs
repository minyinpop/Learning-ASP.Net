using Microsoft.Data.Sqlite;

namespace Learning_ASP.Net.Database.Account;

public static class AccountDatabase
{
    public static void InitializeDatabase()
    {
        using var connection = new SqliteConnection("Data Source=Database/Account/Account.db");
        
        connection.Open();
        
        var command = connection.CreateCommand();

        command.CommandText = """
                              CREATE TABLE IF NOT EXISTS Account
                              (
                                  Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                  CreatedAt TIMESTAMP,
                                  Email TEXT,
                                  Username TEXT,
                                  Password TEXT
                              )
                              """;

        try
        {
            command.ExecuteNonQuery();
            Console.WriteLine("Database Initialize Success!");
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.Message);
        }
    }
}