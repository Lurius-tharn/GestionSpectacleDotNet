using GestionSpectacle.DAL.Context;
using GestionSpectacle.Vue.utils;
using Microsoft.EntityFrameworkCore;

namespace GestionSpectacle.Vue;

public partial class HistoriqueForm : Form
{
    private MyDbContext _myDbContext;

    public HistoriqueForm()
    {
        InitializeComponent();
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        _myDbContext = new MyDbContext();
        _myDbContext.Utilisateurs.Load();
        _myDbContext.BilletHistoriques.Load();
        _myDbContext.Spectacles.Load();

        FillDataGridView();
    }

    private void FillDataGridView()
    {
        historiqueDataGridView.Rows.Clear();


        _myDbContext.BilletHistoriques.Where(historique =>
                historique.IdUtilisateur == UserSingleton.Instance.UtilisateurId)
            .ToList()
            .ForEach(billet =>
            {
                // C comment le nb de place, faut faire le count 
                var imageUrl = billet.IdSpectacleNavigation.imageUrl;

                var image = new PictureBox();
                image.Load(imageUrl);
                var row = historiqueDataGridView.Rows.Add(
                    billet.Id,
                    billet.IdSpectacleNavigation.Titre,
                    billet.numeroBillet,
                    billet.IdSpectacleNavigation.Type,
                    billet.IdSpectacleNavigation.Date,
                    billet.IdSpectacleNavigation.Lieu,
                    billet.IdSpectacleNavigation.NbPlace,
                    image.Image,
                    billet.DateSuppression.ToString()
                );

                // Stocker toutes les informations dans la propriété Tag de la ligne
                historiqueDataGridView.Rows[row].Tag = new
                {
                    BilletId = billet,
                    SpectacleId = billet.IdSpectacleNavigation
                    // Ajoutez d'autres propriétés selon vos besoins
                };
            });
    }
}