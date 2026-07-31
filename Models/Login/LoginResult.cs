namespace Learning_ASP.Net.Models.Login;

public sealed class LoginResult(AccountDatabaseResult result, AccountInformationModel model)
{
    public AccountDatabaseResult Result { get; private set; } = result;

    public AccountInformationModel Model { get; private set; } = model;
}