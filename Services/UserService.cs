using MicrosoftAzure_Study.Models;

namespace MicrosoftAzure_Study.Services;


public class UserService
{
    private static readonly List<User> UserInformation =
        [
            new() { Id = 1, Name = "Macklebee", Email = "mmdom@sulake.com" },
            new() { Id = 2, Name = "Johno", Email = "johno@sulake.com" },
            new() { Id = 3, Name = "Callie", Email = "callie@sulake.com" },
            new() { Id = 4, Name = "Norman", Email = "norman@sulake.com" },
            new() { Id = 5, Name = "Frank", Email = "frank@sulake.com" },
            new() { Id = 6, Name = "PixelBR", Email = "pixel.br@sulake.com" },
            new() { Id = 7, Name = "GuardBR", Email = "guard.br@sulake.com" },
            new() { Id = 8, Name = "HelperBR", Email = "helper.br@sulake.com" },
            new() { Id = 9, Name = "Crumple", Email = "crumple@sulake.com" },
            new() { Id = 10, Name = "Pineapple", Email = "pineapple@sulake.com" },
            new() { Id = 11, Name = "Alba", Email = "alba@sulake.com" },
            new() { Id = 12, Name = "Toro", Email = "toro@sulake.com" },
            new() { Id = 13, Name = "Kettu", Email = "kettu@sulake.com" },
            new() { Id = 14, Name = "SuomiMod", Email = "suomimod@sulake.com" },
            new() { Id = 15, Name = "BackendOps", Email = "backend@sulake.com" },
            new() { Id = 16, Name = "InfraCore", Email = "infra@sulake.com" },
            new() { Id = 17, Name = "LiveOps", Email = "liveops@sulake.com" },
            new() { Id = 18, Name = "NetAdmin", Email = "netadmin@sulake.com" },
            new() { Id = 19, Name = "Security", Email = "security@sulake.com" }
        ];


    public List<User> GetAll()
    {
        return UserInformation;
    }

    public User? GetById(int id)
    {
        return UserInformation.FirstOrDefault(u => u.Id == id);
    }

    public User Add(User user)
    {
        user.Id = UserInformation.Count + 1;
        UserInformation.Add(user);
        return user;
    }

}