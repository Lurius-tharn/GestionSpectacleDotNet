using System.Data.Entity;
using GestionSpectacle.DAL.Context;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;

namespace GestionSpectacle.Vue;

public partial class FormConnexion : Form
{
    private MyDbContext _myDbContext;

    public FormConnexion()
    {
        InitializeComponent();
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        _myDbContext = new MyDbContext();
        _myDbContext.Utilisateurs.Load();
    }

    private void textBoxAcceuilUser_TextChanged(object sender, EventArgs e)
    {
    }

    private void buttonDeconnexion_Click(object sender, EventArgs e)
    {
    }


    private void label2_Click(object sender, EventArgs e)
    {
    }

    private void textBoxAcceuilPassword_TextChanged(object sender, EventArgs e)
    {
    }

    private void label1_Click(object sender, EventArgs e)
    {
    }

    private void buttonConnexion_Click(object sender, EventArgs e)
    {
        var utilisateur = _myDbContext.Utilisateurs.FirstOrDefault(u => u.UserName == textBoxAcceuilUser.Text);

        if (utilisateur != null)
        {
            var storedHashedPassword =
                utilisateur.Password; // R�cup�rer le mot de passe hash� depuis la base de donn�es
            var salt = utilisateur.Salt; // divide by 8 to convert bits to bytes
            // Utiliser la m�me m�thode de d�rivation pour hasher le mot de passe fourni par l'utilisateur
            var hashedPasswordAttempt = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                textBoxAcceuilPassword.Text,
                salt,
                KeyDerivationPrf.HMACSHA256,
                100000,
                256 / 8));

            // Comparer les deux mots de passe hash�s de mani�re constante en utilisant SequenceEqual
            if (storedHashedPassword.Length == hashedPasswordAttempt.Length &&
                storedHashedPassword.SequenceEqual(hashedPasswordAttempt))
                // Mot de passe correct
                MessageBox.Show("Connexion r�ussie !");
            else
                // Mot de passe incorrect
                MessageBox.Show("Identifiant ou mot de passe incorrect !");
        }
        else
        {
            // Utilisateur non trouv�
            MessageBox.Show("Identifiant ou mot de passe incorrect !");
        }
    }
}