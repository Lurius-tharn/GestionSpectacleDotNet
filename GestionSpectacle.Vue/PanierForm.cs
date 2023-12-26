using System.Globalization;
using GestionSpectacle.DAL.Context;
using GestionSpectacle.DAL.Entities;
using GestionSpectacle.Vue.utils;
using Microsoft.EntityFrameworkCore;

namespace GestionSpectacle.Vue;

public partial class PanierForm : Form
{
    private MyDbContext _myDbContext;

    public PanierForm()
    {
        InitializeComponent();
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        _myDbContext = new MyDbContext();
        _myDbContext.Utilisateurs.Load();
        _myDbContext.Billets.Load();
        _myDbContext.Spectacles.Load();
    }


    private void buttonPaye_Click(object sender, EventArgs e)
    {
    }

    public void GetCart()
    {
        cartDataGridView.Rows.Clear();
        if (CartManager.GetPanierItems() is not null)
        {
            foreach (var eventDetails in CartManager.GetPanierItems())
                cartDataGridView.Rows.Add(
                    eventDetails.Name,
                    eventDetails.StartDate,
                    eventDetails.Type,
                    eventDetails.Places,
                    eventDetails.Venue,
                    eventDetails.Prix
                );

            totalPriceText.Text = CartManager.GetCartTotalPrice().ToString(CultureInfo.CurrentCulture);
        }
    }

    private void buttonPaye_Click_1(object sender, EventArgs e)
    {
        if (!UserSingleton.Instance.IsConnected())
            MessageBox.Show(
                "Vous devez avoir un compte pour reserver ! Inscrivez vous pu connectez-vous via le menu Accueil");

        else if (CartManager.GetPanierItems().Count < 0)
            MessageBox.Show("Vous devez avoir au moins un artticle dans votre panier. ");
        else
            foreach (var eventDetails in CartManager.GetPanierItems())
            {
                var spectacle = new Spectacle
                {
                    Titre = eventDetails.Name,
                    Date = eventDetails.StartDate,
                    NbPlace = eventDetails.Places
                };
                _myDbContext.Spectacles.Add(spectacle);
                _myDbContext.SaveChanges();

                var spectacleId = spectacle.Id;

                _myDbContext.Billets.Add(new Billet
                {
                    Statut = eventDetails.Status,
                    IdSpectacle = spectacleId,
                    IdUtilisateur = UserSingleton.Instance.UtilisateurId
                });

                _myDbContext.SaveChanges();
            }

        MessageBox.Show(
            "Merci pour vos achats ! Nous avons bien pris en compte vos achats, vous les trouverez dans l'onglet Reservation");

        CartManager.ResetCart();
        Close();
    }
}