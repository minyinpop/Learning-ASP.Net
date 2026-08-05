using Learning_ASP.Net.Models.Register;

namespace Learning_ASP.Net.Models.Login;

public sealed class LoginResult(AccountDatabaseResult result, RegisterRequest model)
{
    public AccountDatabaseResult Result { get; private set; } = result;

    public RegisterRequest Model { get; private set; } = model;
}