namespace Learning_ASP.Net.Models.Login;

public sealed class LoginRequest(string email, string password)
{
    public string Email { get; private set; } = email;
    
    public string Password { get; private set; } = password;
}