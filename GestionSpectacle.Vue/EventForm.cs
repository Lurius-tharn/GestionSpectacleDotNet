using GestionSpectacle.Vue.utils;
using WindowsFormsApp1;

namespace GestionSpectacle.Vue;

public partial class EventForm : Form
{
    private EventDetail eventDetail;

    private Form formParent;

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
        ShowDialog();
    }

    internal void SetFormParent(ListEventForm formEvenem)
    {
        formParent = formEvenem;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        formParent.Show();
        Close();
    }

    private void buttonPanier_Click(object sender, EventArgs e)
    {
        eventDetail.Places += (int)nbPlacesNumericUpDown.Value;

        CartManager.AjouterAuPanier(eventDetail);

        MessageBox.Show($"Spectacle {eventDetail.Name} a été ajouté au panier !");
    }
}