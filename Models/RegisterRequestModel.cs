namespace Learning_ASP.Net.Models;

public sealed class RegisterRequestModel(string email, string username, string password, string confirmPassword)
{
    public string Email { get; private set; } = email;

    public string Username { get; private set; } = username;

    public string Password { get; private set; } = password;

    public string ConfirmPassword { get; private set; } = confirmPassword;
}