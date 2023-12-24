using Newtonsoft.Json;
using System.Globalization;

namespace WindowsFormsApp1;

public partial class formEvenem : Form
{
    private readonly string apiKey = "DdPB8GMtZ2bCJYNiH1pj48zEs1dN98gI";
    private readonly string classification = "Concert";
    private string city = "Paris";

    public formEvenem()
    {
        InitializeComponent();
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

        foreach (var evenement in events._embedded.events)
        {
            var imageUrl = evenement.images[0].url; // Assurez-vous de gérer les cas où il y a plusieurs images

            var image = new PictureBox();
            image.Load(imageUrl.ToString());
            spectaclesDataGridView.Rows.Add(
                evenement.name,
                evenement.type,
                evenement.dates.start.localDate,
                evenement._embedded.venues[0].name,
                evenement.dates.status.code == "onsale"
                    ? "Disponible"
                    : "Non disponible",
                evenement.dates.start.localDate,
                image.Image
            );
        }
    }

    private async void buttonRechercher_Click(object sender, EventArgs e)
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
}