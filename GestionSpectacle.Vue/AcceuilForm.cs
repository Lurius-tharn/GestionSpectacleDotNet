using GestionSpectacle.Vue;
using GestionSpectacle.Vue.Properties;
using GestionSpectacle.Vue.utils;

namespace WindowsFormsApp1;

public partial class AcceuilForm : Form
{
    private readonly ConnexionForm
        _formConnexion;

    private readonly ListEventForm _formEvenem;
    private readonly PanierForm _formPanier;

    private readonly InscriptionForm formInscription;
    private readonly ReservationForm reservationForm;
    private UserControl activeControl;
    private Panel mainPanel;

    public AcceuilForm()
    {
        InitializeComponent();
        formInscription = new InscriptionForm();
        _formConnexion = new ConnexionForm();
        _formEvenem = new ListEventForm();
        _formPanier = new PanierForm();
        reservationForm=    new ReservationForm();  
        if (Settings.Default.isConnected)
        {
            isConnectedTextLabel.Text = $" Bienvenue, {Settings.Default.UserName}";
            seDéconnecterToolStripMenuItem.Visible = true;
            inscriptionToolStripMenuItem.Visible = false;
            connectionStripMenuItem1.Visible = false;
        }
        else
        {
            seDéconnecterToolStripMenuItem.Visible = false;
            inscriptionToolStripMenuItem.Visible = true;
            connectionStripMenuItem1.Visible = true;
            isConnectedTextLabel.Text = "Veuillez vous inscrire ou vous connectez !";
        }
    }


    private void inscriptionToolStripMenuItem_Click_1(object sender, EventArgs e)
    {
        FormUtilities.ShowFormInPanel(panelAcceuil, formInscription);
    }

    private void toolStripMenuItem1_Click(object sender, EventArgs e)
    {
        FormUtilities.ShowFormInPanel(panelAcceuil, _formConnexion);
    }


    private void rechercherDesEvenementsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        FormUtilities.ShowFormInPanel(panelAcceuil, _formEvenem);
    }

    private void panierToolStripMenuItem_Click_1(object sender, EventArgs e)
    {
        _formPanier.GetCart();
        _formPanier.ShowDialog();
    }

    private void reservationToolStripMenuItem_Click(object sender, EventArgs e)
    {
        FormUtilities.ShowFormInPanel(panelAcceuil, reservationForm);
    }
}