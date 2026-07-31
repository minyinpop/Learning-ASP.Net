namespace Learning_ASP.Net.Models;

public enum AccountDatabaseResult
{
    // When user login account. ( 100 )
    Login_Successfully = 101,
    Login_AccountNotExists = 102,
    
    // When user register account. ( 200 )
    AccountRegisterSuccessfully = 201,
    AccountIsAlreadyExists = 202,
}