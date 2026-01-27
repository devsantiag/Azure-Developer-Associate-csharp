namespace MicrosoftAzure_Study.Models;

public class UserCredentials
{
    public Guid Id_Game_Credentials { get; set; }
    public string GameNickName { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}
