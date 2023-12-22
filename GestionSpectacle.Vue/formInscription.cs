using System.ComponentModel;
using System.Data.Entity;
using System.Security.Cryptography;
using GestionSpectacle.DAL.Context;
using GestionSpectacle.DAL.Entities;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;

namespace GestionSpectacle.Vue;

public partial class formInscription : Form
{
    private MyDbContext _myDbContext;

    public formInscription()
    {
        InitializeComponent();
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        _myDbContext = new MyDbContext();
        _myDbContext.Utilisateurs.Load();
    }


    private void buttonInscription_Click(object sender, EventArgs e)
    {
    }

    private void label5_Click(object sender, EventArgs e)
    {
    }

    private void textBox5_TextChanged(object sender, EventArgs e)
    {
    }

    private void user_Name_Validating(object sender, CancelEventArgs e)
    {
        if (string.IsNullOrWhiteSpace(userNameInput.Text))
        {
            e.Cancel = true;
            userNameInput.Focus();
            errorProviderApp.SetError(userNameInput, "Inscrivez un nom !");
        }
        else
        {
            e.Cancel = false;
            errorProviderApp.SetError(userNameInput, "");
        }
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
    }

    private void buttonInscription_Click_1(object sender, EventArgs e)
    {
        if (ValidateChildren(ValidationConstraints.Enabled))
        {
            // hashage
            var salt = RandomNumberGenerator.GetBytes(128 / 8); // divide by 8 to convert bits to bytes
            Console.WriteLine($"Salt: {Convert.ToBase64String(salt)}");

            // derive a 256-bit subkey (use HMACSHA256 with 100,000 iterations)
            var hashedPassword = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                passwordnput.Text!,
                salt,
                KeyDerivationPrf.HMACSHA256,
                100000,
                256 / 8));


            _myDbContext.Utilisateurs.Add(new Utilisateur
            {
                Nom = userNameInput.Text,
                UserName = userNameInput.Text,
                Password = hashedPassword,
                Salt = salt
            });

            _myDbContext.SaveChanges();

            MessageBox.Show("Inscription r�ussie !");
            Close();
        }
    }
}