using GestionSpectacle.Vue.utils;

namespace GestionSpectacle.Vue;

public partial class EventForm : Form
{
    private EventDetail eventDetail;

    public EventForm()
    {
        InitializeComponent();
    }

    internal void DisplayEventInfo(EventDetail eventDetail)
    {
        this.eventDetail = eventDetail;
        eventNameLabel.Text = eventDetail.Name;
        descriptionTextLabel.Text = eventDetail.Description;
        spectaclePictureBox.Load(eventDetail.ImageUrl);
        priceLabel.Text = eventDetail.Prix.ToString();
        promotorLabel.Text = eventDetail.MainPromotor;
        classificationLabel.Text = eventDetail.MainClassification;
        startDateLabel.Text = eventDetail.StartDate;
        nbPlaceMaxLabel.Text = eventDetail.nbPlacesMax.ToString();
        if (eventDetail.nbPlacesMax == 0 || eventDetail.Status == "Non disponible")
        {
            nbPlacesNumericUpDown.Minimum = 0;
            nbPlacesNumericUpDown.Enabled = false;
            placeInfoLabel.Text = "( Il n'y as actuellement pas de places disponibles) ";
            buttonPanier.Enabled = false;
        }

        else
        {
            nbPlacesNumericUpDown.Maximum = eventDetail.nbPlacesMax;
            placeInfoLabel.Text = $"Vous pouvez prendre {eventDetail.nbPlacesMax} places";
        }

        ShowDialog();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void buttonPanier_Click(object sender, EventArgs e)
    {
        eventDetail.nbPlaces = (int)nbPlacesNumericUpDown.Value;

        CartManager.AjouterAuPanier(eventDetail);

        MessageBox.Show($"Spectacle {eventDetail.Name} a été ajouté au panier !");
    }

    public void DisableActions(bool disable)
    {
        buttonPanier.Enabled = disable;
        nbPlacesNumericUpDown.Enabled = disable;
    }
}