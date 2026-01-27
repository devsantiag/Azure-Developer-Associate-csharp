using MicrosoftAzure_Study.Models;
namespace MicrosoftAzure_Study.Services;

public class UserCredentialsServices
{

    private readonly List<UserCredentials> _userCredentialsT =

        [
            new() {
                    GameNickName = "Macklebee", 
                    Password = "your_password_here" 
            }
        ];


    public List<UserCredentials> GetAll()
    {
        return _userCredentialsT;
    }

    public UserCredentials? GetById(Guid id)
    {
        return _userCredentialsT.FirstOrDefault(uc => uc.Id_Game_Credentials == id);
    }
}