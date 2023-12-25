using GestionSpectacle.Vue.utils;
using WindowsFormsApp1;

namespace GestionSpectacle.Vue;

public partial class EventForm : Form
{

    private Form formParent;
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
    }

    internal void SetFormParent(formEvenem formEvenem)
    {
        this.formParent = formEvenem;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        formParent.Show();  
        this.Close();
    }

    private void buttonPanier_Click(object sender, EventArgs e)
    {

    }
}