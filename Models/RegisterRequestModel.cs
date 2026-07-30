namespace Learning_ASP.Net.Models;

public sealed class RegisterRequestModel()
{
    public string Email { get; set; }

    public string Username { get; set; }

    public string Password { get; set; }

    public string ConfirmPassword { get; set; }
}