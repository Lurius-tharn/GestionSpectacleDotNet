using GestionSpectacle.DAL.Context;
using GestionSpectacle.Data;
using GestionSpectacle.Vue.utils;
using Microsoft.EntityFrameworkCore;

namespace WindowsFormsApp1;

public partial class ReservationForm : Form
{
    private MyDbContext _myDbContext;
    private GestionnaireBillet gestionnaireBillet;

    public ReservationForm()
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
        gestionnaireBillet = new GestionnaireBillet();
        FillDataGridView();
    }

    private void FillDataGridView()
    {
        reservationDataGridView.Rows.Clear();


        _myDbContext.Billets.Where(billet => billet.IdUtilisateur == UserSingleton.Instance.UtilisateurId)
            .ToList()
            .ForEach(billet =>
            {
                // C comment le nb de place, faut faire le count 
                var imageUrl = billet.IdSpectacleNavigation.imageUrl;

                var image = new PictureBox();
                image.Load(imageUrl);
                var row = reservationDataGridView.Rows.Add(
                    billet.Id,
                    billet.IdSpectacleNavigation.Titre,
                    billet.numeroBillet,
                    billet.IdSpectacleNavigation.Type,
                    billet.IdSpectacleNavigation.Date,
                    billet.IdSpectacleNavigation.Lieu,
                    billet.IdSpectacleNavigation.NbPlace,
                    image.Image
                );

                // Stocker toutes les informations dans la propriété Tag de la ligne
                reservationDataGridView.Rows[row].Tag = new
                {
                    BilletId = billet,
                    SpectacleId = billet.IdSpectacleNavigation
                    // Ajoutez d'autres propriétés selon vos besoins
                };
            });
    }

    private void reservationDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.ColumnIndex == reservationDataGridView?.Columns["CancelButton"]?.Index)
        {
            var selectedRow = reservationDataGridView.Rows[e.RowIndex];
            var tag = selectedRow.Tag as dynamic;

            if (tag != null)
            {
                var billetId = tag.BilletId;
                var spectacleId = tag.SpectacleId;

                var resultat = MessageBox.Show("Voulez-vous ANNULER VOS RESERVATIONS ? VOUS NE SEREZ PAS REMBOURSÉ",
                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultat == DialogResult.Yes)
                {
                    gestionnaireBillet.AnnulerReservation(billetId, spectacleId);

                    reservationDataGridView.Rows.Remove(selectedRow);
                }
            }
        }
    }
}