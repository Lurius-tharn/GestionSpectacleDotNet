using System.Data.Entity;
using GestionSpectacle.DAL.Context;
using GestionSpectacle.Vue.Properties;
using GestionSpectacle.Vue.utils;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using WindowsFormsApp1;

namespace GestionSpectacle.Vue;

public partial class ConnexionForm : Form
{
    private ListEventForm _listEventForm;
    private MyDbContext _myDbContext;

    public ConnexionForm()
    {
        InitializeComponent();
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        _myDbContext = new MyDbContext();
        _myDbContext.Utilisateurs.Load();
        _listEventForm = new ListEventForm();
    }

    private void buttonConnexion_Click(object sender, EventArgs e)
    {
        var utilisateur = _myDbContext.Utilisateurs.FirstOrDefault(u => u.UserName == textBoxAcceuilUser.Text);

        if (utilisateur != null)
        {
            var storedHashedPassword =
                utilisateur.Password;
            var salt = utilisateur.Salt;
            var hashedPasswordAttempt = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                textBoxAcceuilPassword.Text,
                salt,
                KeyDerivationPrf.HMACSHA256,
                100000,
                256 / 8));

            if (storedHashedPassword.Length == hashedPasswordAttempt.Length &&
                storedHashedPassword.SequenceEqual(hashedPasswordAttempt))
            {
                UserSingleton.Instance.SetUtilisateurInfo(utilisateur.Id, utilisateur.UserName);

                MessageBox.Show("Connexion r�ussie !");
                if (stayConnectedCheckBox.Checked)
                {
                    Settings.Default.UserId = utilisateur.Id;
                    Settings.Default.UserName = utilisateur.UserName;
                    Settings.Default.isConnected = true;
                    Settings.Default.Save();
                }

                FormUtilities.ShowFormInPanel(panelAcceuil, _listEventForm);
            }

            else
            {
                MessageBox.Show("Identifiant ou mot de passe incorrect !");
            }
        }
        else
        {
            MessageBox.Show("Identifiant ou mot de passe incorrect !");
        }
    }
}