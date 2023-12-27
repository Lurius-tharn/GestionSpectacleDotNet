using System.Globalization;
using GestionSpectacle.DAL.Context;
using GestionSpectacle.DAL.Entities;
using GestionSpectacle.Data;
using GestionSpectacle.Vue.utils;
using Microsoft.EntityFrameworkCore;

namespace GestionSpectacle.Vue;

public partial class PanierForm : Form
{
    private GestionnaireBillet _gestionnaireBillet;
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
        _gestionnaireBillet = new GestionnaireBillet();
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
                    eventDetails.nbPlaces,
                    eventDetails.Venue,
                    eventDetails.Prix
                );

            totalPriceText.Text = CartManager.GetCartTotalPrice().ToString(CultureInfo.CurrentCulture);
        }
    }

    private void buttonPaye_Click_1(object sender, EventArgs e)
    {
        if (!UserSingleton.Instance.IsConnected())
        {
            MessageBox.Show(
                "Vous devez avoir un compte pour reserver ! Inscrivez vous pu connectez-vous via le menu Accueil");
            return;
        }

        if (CartManager.GetPanierItems().Count < 0)
        {
            MessageBox.Show("Vous devez avoir au moins un artticle dans votre panier. ");
            return;
        }

        foreach (var eventDetails in CartManager.GetPanierItems())
        {
            var spectacle = new Spectacle
            {
                Titre = eventDetails.Name,
                Date = eventDetails.StartDate,
                NbPlace = eventDetails.nbPlacesMax,
                imageUrl = eventDetails.ImageUrl,
                Lieu = eventDetails.Venue,
                Type = eventDetails.Type,
                IdApi = eventDetails.IdApi
            };
            _gestionnaireBillet.ReserverBillets(spectacle, UserSingleton.Instance.UtilisateurId,
                eventDetails.nbPlaces);
        }

        MessageBox.Show(
            "Merci pour vos achats ! Nous avons bien pris en compte vos achats, vous les trouverez dans l'onglet Reservation");

        CartManager.ResetCart();
        Close();
    }
}