using BV212_Tanks_1986.Game.Interfaces;

namespace BV212_Tanks_1986.Game;

public class Profile : IProfile
{
    private Dictionary<string, string> _profiles = new Dictionary<string, string>()
    {
        { "admin", "admin" },
        { "vasa", "vasa" },
        { "1234", "1234" },
    };

    public bool ValidateProfile(string login, string password)
    {
        if (!_profiles.TryGetValue(login, out var profilePassword)) return false;
        
        return profilePassword == password;
        
    }
    
    
    
    
}