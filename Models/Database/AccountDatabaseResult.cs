namespace Learning_ASP.Net.Models;

public enum AccountDatabaseResult
{
    // When user login account. ( 100 )
    Login_Successfully = 101,
    Login_AccountNotExists = 102,
    
    // When user register account. ( 200 )
    Register_Successfully = 201,
    Register_AccountIsExists = 202,
}