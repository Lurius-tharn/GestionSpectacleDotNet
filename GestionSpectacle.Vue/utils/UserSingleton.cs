namespace GestionSpectacle.Vue.utils;

public class UserSingleton
{
    private static UserSingleton _instance;
    public int UtilisateurId { get; private set; }
    public string Nom { get; private set; }
    public string UserName { get; private set; }

    public static UserSingleton Instance
    {
        get
        {
            if (_instance == null) _instance = new UserSingleton();
            return _instance;
        }
    }

    public void SetUtilisateurInfo(int utilisateurId, string userName)
    {
        UtilisateurId = utilisateurId;
        UserName = userName;
    }

    public static void ResetInstance()
    {
        _instance = null;
    }

    public bool IsConnected()
    {
        return UtilisateurId != 0 && UserName is not null;
    }
}