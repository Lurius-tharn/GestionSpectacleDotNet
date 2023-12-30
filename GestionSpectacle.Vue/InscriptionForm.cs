using System.ComponentModel;
using System.Data.Entity;
using System.Security.Cryptography;
using GestionSpectacle.DAL.Context;
using GestionSpectacle.DAL.Entities;
using GestionSpectacle.Vue.Properties;
using GestionSpectacle.Vue.utils;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using WindowsFormsApp1;

namespace GestionSpectacle.Vue;

public partial class InscriptionForm : Form
{
    private ListEventForm _listEventForm;
    private MyDbContext _myDbContext;

    public InscriptionForm()
    {
        InitializeComponent();
    }

    public AcceuilForm AcceuilForm { get; set; } = null!;

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        _myDbContext = new MyDbContext();
        _myDbContext.Utilisateurs.Load();
        _listEventForm = new ListEventForm();
    }


    private void label5_Click(object sender, EventArgs e)
    {
    }

    private void textBox5_TextChanged(object sender, EventArgs e)
    {
    }

    private void userNameInput_Validating(object sender, CancelEventArgs e)
    {
        if (string.IsNullOrWhiteSpace(userNameInput.Text))
        {
            errorProviderApp.SetError(userNameInput, "Inscrivez un nom valide (sans caractères spéciaux) !");
            e.Cancel = true;
        }
        else
        {
            var enteredUserName = userNameInput.Text;

            if (_myDbContext.Utilisateurs.Any(u => u.UserName == enteredUserName))
            {
                errorProviderApp.SetError(userNameInput,
                    "Ce nom d'utilisateur est déjà pris. Veuillez choisir un autre nom.");
                e.Cancel = true;
            }
            else
            {
                errorProviderApp.SetError(userNameInput, "");
                e.Cancel = false;
            }
        }
    }

    private void ValidatePassword(object sender, CancelEventArgs e)
    {
        var passwordTextBox = (TextBox)sender;

        if (string.IsNullOrWhiteSpace(passwordTextBox.Text))
        {
            errorProviderApp.SetError(passwordTextBox, "Le mot de passe ne peut pas être vide !");
            e.Cancel = true;
        }
        else
        {
            errorProviderApp.SetError(passwordTextBox, "");
            e.Cancel = false;

            // Déplacer le focus vers le contrôle suivant
            SelectNextControl(passwordTextBox, true, true, true, true);
        }
    }

    private void ValidatePasswordConfirmation(object sender, CancelEventArgs e)
    {
        if (passwordnput.Text != passwordComfirmInput.Text)
        {
            errorProviderApp.SetError(passwordComfirmInput, "Les mots de passe ne correspondent pas !");
            e.Cancel = true;
        }
        else
        {
            errorProviderApp.SetError(passwordComfirmInput, "");
            e.Cancel = false;

            // Déplacer le focus vers le contrôle suivant
            SelectNextControl(passwordComfirmInput, true, true, true, true);
        }
    }


    private void buttonInscription_Click_1(object sender, EventArgs e)
    {
        if (ValidateChildren(ValidationConstraints.Enabled))
        {
            // hashage
            var salt = RandomNumberGenerator.GetBytes(128 / 8);
            Console.WriteLine($"Salt: {Convert.ToBase64String(salt)}");

            var hashedPassword = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                passwordnput.Text!,
                salt,
                KeyDerivationPrf.HMACSHA256,
                100000,
                256 / 8));

            var user = new Utilisateur
            {
                Nom = userNameInput.Text,
                UserName = userNameInput.Text,
                Password = hashedPassword,
                Salt = salt
            };
            _myDbContext.Utilisateurs.Add(user);

            _myDbContext.SaveChanges();

            MessageBox.Show("Inscription réussie !");
            UserSingleton.Instance.SetUtilisateurInfo(user.Id, user.UserName);
            if (stayConnectedCheckBox.Checked)
            {
                Settings.Default.UserId = user.Id;
                Settings.Default.UserName = user.UserName;
                Settings.Default.isConnected = true;
                Settings.Default.Save();
            }

            AcceuilForm.SetMenuConnect();

            FormUtilities.ShowFormInPanel(panelAcceuil, _listEventForm);

            Close();
        }
    }
}