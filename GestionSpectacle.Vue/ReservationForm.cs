using GestionSpectacle.DAL.Context;
using GestionSpectacle.Data;
using GestionSpectacle.Vue;
using GestionSpectacle.Vue.utils;
using Microsoft.EntityFrameworkCore;

namespace WindowsFormsApp1;

public partial class ReservationForm : Form
{
    private readonly EventForm eventForm;
    private MyDbContext _myDbContext;
    private TicketMasterApi _ticketMasterApi;
    private GestionnaireBillet gestionnaireBillet;

    public ReservationForm()
    {
        InitializeComponent();
        eventForm = new EventForm();
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        _myDbContext = new MyDbContext();
        _myDbContext.Utilisateurs.Load();
        _myDbContext.Billets.Load();
        _myDbContext.Spectacles.Load();
        gestionnaireBillet = new GestionnaireBillet();
        _ticketMasterApi = new TicketMasterApi();

        FillDataGridView();
    }

    private void FillDataGridView()
    {
        reservationDataGridView.Rows.Clear();


        _myDbContext.Billets.Where(billet => billet.IdUtilisateur == UserSingleton.Instance.UtilisateurId)
            .ToList()
            .ForEach(billet =>
            {
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

                reservationDataGridView.Rows[row].Tag = new
                {
                    BilletId = billet,
                    SpectacleId = billet.IdSpectacleNavigation
                };
            });
    }

    private async void reservationDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.ColumnIndex > 0 && e.ColumnIndex == reservationDataGridView?.Columns["CancelButton"]?.Index)
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
        else if (e.ColumnIndex > 0 && e.ColumnIndex == reservationDataGridView?.Columns["evenConsult"]?.Index)
        {
            var selectedRow = reservationDataGridView.Rows[e.RowIndex];
            var tag = selectedRow.Tag as dynamic;

            if (tag != null)
            {
                var spectacleIdApi = tag.SpectacleId.IdApi;

                var dynamicEvent = await _ticketMasterApi.GetEventDetailsAsync(spectacleIdApi);
                var eventDetail = _ticketMasterApi.SetEventDetail(dynamicEvent);
                eventForm.DisplayEventInfo(eventDetail);
                eventForm.DisableActions(false);
                eventForm.Show();
            }
        }
    }
}