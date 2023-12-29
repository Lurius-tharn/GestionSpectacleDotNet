using GestionSpectacle.Vue;
using GestionSpectacle.Vue.utils;

namespace WindowsFormsApp1;

public partial class ListEventForm : Form
{
    private readonly string apiKey = "DdPB8GMtZ2bCJYNiH1pj48zEs1dN98gI";
    private readonly string classification = "Concert";
    private readonly EventForm eventForm;
    private readonly List<EventDetail> storedEvents;
    private readonly TicketMasterApi ticketMasterApi;
    private dynamic cachedEvents;

    public ListEventForm()
    {
        InitializeComponent();
        storedEvents = new List<EventDetail>();
        eventForm = new EventForm();
        ticketMasterApi = new TicketMasterApi();
    }


    private async Task FillDataGridView(dynamic events)
    {
        spectaclesDataGridView.Rows.Clear();
        if (events == null) events = cachedEvents;

        foreach (var evenement in events._embedded.events)
        {
            var dynamicEvent = evenement;

            EventDetail eventDetails = ticketMasterApi.SetEventDetail(dynamicEvent);

            storedEvents.Add(eventDetails);

            var imageUrl = evenement.images[0].url;

            var image = new PictureBox();
            image.Load(imageUrl.ToString());
            spectaclesDataGridView.Rows.Add(
                eventDetails.Name,
                eventDetails.Type,
                eventDetails.StartDate,
                eventDetails.Venue,
                eventDetails.nbPlacesMax,
                eventDetails.Status,
                eventDetails.Prix,
                image.Image
            );
        }
    }


    private async void buttonRechercher_Click_1(object sender, EventArgs e)
    {
        var startDate = dateTimePickerFirst.Value;
        var endDate = dateTimePickerLast.Value;
        var city = VilleSpectacleInput.Text;

        if (endDate <= startDate)
        {
            MessageBox.Show("La date de fin doit être postérieure à la date de début");
            return;
        }

        try
        {
            var events = await ticketMasterApi.GetEventsAsync(city, startDate, endDate);
        
            FillDataGridView(events);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erreur : {ex.Message}");
        }
    }

    private void spectaclesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.ColumnIndex > 0 && e.ColumnIndex == spectaclesDataGridView.Columns["evenConsult"]!.Index)
        {
            var selectedEventDetails = storedEvents[e.RowIndex];
            eventForm.DisableActions(true);
            eventForm.DisplayEventInfo(selectedEventDetails);
        }
    }


}