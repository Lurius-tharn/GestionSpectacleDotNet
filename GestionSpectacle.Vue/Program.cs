using GestionSpectacle.Vue.Properties;
using GestionSpectacle.Vue.utils;

namespace WindowsFormsApp1;

internal static class Program
{
    /// <summary>
    ///     The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
        UserSingleton.Instance.SetUtilisateurInfo(
            Settings.Default.UserId,
            Settings.Default.UserName
        );
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new AcceuilForm());
    }
}