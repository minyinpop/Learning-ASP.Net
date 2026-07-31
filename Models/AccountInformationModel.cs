namespace Learning_ASP.Net.Models;

public sealed class AccountInformationModel(string email, string username, string password)
{
    public string Email { get; private set; } = email;

    public string Username { get; private set; } = username;
    
    public string Password { get; private set; } = password;
}