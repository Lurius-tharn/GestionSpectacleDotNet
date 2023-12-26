﻿using System.Globalization;
using GestionSpectacle.Vue;
using GestionSpectacle.Vue.utils;
using Newtonsoft.Json;

namespace WindowsFormsApp1;

public partial class ListEventForm : Form
{
    private readonly string apiKey = "DdPB8GMtZ2bCJYNiH1pj48zEs1dN98gI";
    private readonly string classification = "Concert";
    private readonly EventForm eventForm;
    private readonly Stack<Form> formStack = new();
    private readonly List<EventDetail> storedEvents;
    private dynamic cachedEvents;

    public ListEventForm()
    {
        InitializeComponent();
        storedEvents = new List<EventDetail>();
        eventForm = new EventForm();
        eventForm.SetFormParent(this);
    }


    private string ConvertToIso8601DateTime(string inputDate)
    {
        if (DateTime.TryParseExact(inputDate, "dd/MM/yyyy HH:mm:ss", null, DateTimeStyles.None, out var parsedDate))
        {
            var iso8601Date = parsedDate.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ");
            return iso8601Date;
        }

        return null;
    }


    private async Task FillDataGridView(dynamic events)
    {
        spectaclesDataGridView.Rows.Clear();
        if (events == null) events = cachedEvents;

        foreach (var evenement in events._embedded.events)
        {
            var dynamicEvent = evenement;

            // Stocker l'ensemble des détails de l'événement
            var eventDetails = new EventDetail
            {
                Name = dynamicEvent.name,
                Type = dynamicEvent.type,
                StartDate = dynamicEvent.dates.start.localDate,
                Venue = dynamicEvent._embedded.venues[0].name,
                Status = GetDisponibility(dynamicEvent),
                ImageUrl = dynamicEvent.images[0].url,
                Description = dynamicEvent?.description ?? string.Empty,
                nbPlacesMax = dynamicEvent?._embedded.venues[0].upcomingEvents._total,
                Prix = dynamicEvent?.priceRanges[0].min,
                MainClassification = dynamicEvent?.classifications[0].genre.name,
                MainPromotor = dynamicEvent?.promoter.name,
                IdApi = dynamicEvent?.id
            };

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
                eventDetails.Prix,
                image.Image
            );
        }
    }

    private static string GetDisponibility(dynamic dynamicEvent)
    {
        return dynamicEvent.dates.status.code == "onsale" ? "Disponible" : "Non disponible";
    }


    private async void buttonRechercher_Click_1(object sender, EventArgs e)
    {
        var startDate = ConvertToIso8601DateTime(dateTimePickerFirst.Value.ToString(CultureInfo.CurrentCulture));
        var endDate = ConvertToIso8601DateTime(dateTimePickerLast.Value.ToString(CultureInfo.CurrentCulture));


        if (dateTimePickerLast.Value <= dateTimePickerFirst.Value)
        {
            MessageBox.Show("La date de fin doit être postérieure à la date de début");
            return;
        }

        var apiUrl = "https://app.ticketmaster.com/discovery/v2/events?" +
                     $"apikey={apiKey}" +
                     $"&city={VilleSpectacleInput.Text}" +
                     $"&classificationName={classification}" +
                     $"&startDateTime={startDate}" +
                     $"&endDateTime={endDate}" +
                     "&locale=fr" +
                     "&sort=date,asc";


        using (var client = new HttpClient())
        {
            try
            {
                var response = await Task.Run(() => client.GetAsync(apiUrl));

                if (response.IsSuccessStatusCode)
                {
                    var responseBody = await response.Content.ReadAsStringAsync();
                    var events = JsonConvert.DeserializeObject<dynamic>(responseBody);

                    FillDataGridView(events);
                }
                else
                {
                    MessageBox.Show($"Erreur de requête : {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur : {ex.Message}");
            }
        }
    }

    private void spectaclesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.ColumnIndex == spectaclesDataGridView.Columns["evenConsult"]!.Index)
        {
            var selectedEventDetails = storedEvents[e.RowIndex];

            eventForm.DisplayEventInfo(selectedEventDetails);
        }
    }
}