using Newtonsoft.Json;

namespace GestionSpectacle.Vue.utils;

public class TicketMasterApi
{
    private readonly string apiKey = "DdPB8GMtZ2bCJYNiH1pj48zEs1dN98gI";
    private readonly string classification = "Concert";

    public async Task<dynamic> GetEventsAsync(string city, DateTime startDate, DateTime endDate)
    {
        var startDateString = ConvertToIso8601DateTime(startDate);
        var endDateString = ConvertToIso8601DateTime(endDate);

        var apiUrl = "https://app.ticketmaster.com/discovery/v2/events?" +
                     $"apikey={apiKey}" +
                     $"&city={city}" +
                     $"&classificationName={classification}" +
                     $"&startDateTime={startDateString}" +
                     $"&endDateTime={endDateString}" +
                     "&locale=fr" +
                     "&sort=date,asc";

        using (var client = new HttpClient())
        {
            var response = await client.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                var responseBody = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<dynamic>(responseBody);
            }

            throw new HttpRequestException($"Erreur de requête : {response.StatusCode}");
        }
    }

    public async Task<dynamic> GetEventDetailsAsync(string eventId)
    {
        var apiUrl = $"https://app.ticketmaster.com/discovery/v2/events/{eventId}?" +
                     $"apikey={apiKey}";

        using (var client = new HttpClient())
        {
            var response = await client.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                var responseBody = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<dynamic>(responseBody);
            }

            throw new HttpRequestException($"Erreur de requête : {response.StatusCode}");
        }
    }

    private static string ConvertToIso8601DateTime(DateTime date)
    {
        return date.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ");
    }

    public EventDetail SetEventDetail(dynamic dynamicEvent)
    {
        return new EventDetail
        {
            Name = dynamicEvent.name,
            Type = dynamicEvent.type,
            StartDate = dynamicEvent.dates.start.localDate,
            Venue = dynamicEvent._embedded.venues[0].name,
            Status = "",
            ImageUrl = dynamicEvent.images[0].url,
            Description = dynamicEvent?.description ?? string.Empty,
            nbPlacesMax = dynamicEvent?._embedded.venues[0].upcomingEvents._total,
            Prix = dynamicEvent?.priceRanges[0].min,
            MainClassification = dynamicEvent?.classifications[0].genre.name,
            MainPromotor = dynamicEvent?.promoter.name,
            IdApi = dynamicEvent?.id
        };
    }
}