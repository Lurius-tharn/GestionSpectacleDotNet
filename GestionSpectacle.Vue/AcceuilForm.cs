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

    private UserControl activeControl;
    private Panel mainPanel;

    public AcceuilForm()
    {
        InitializeComponent();
        formInscription = new InscriptionForm();
        _formConnexion = new ConnexionForm();
        _formEvenem = new ListEventForm();
        _formPanier = new PanierForm();
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


    private void panelAcceuil_Paint(object sender, PaintEventArgs e)
    {
    }

    private void reservationToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var formReserv = new ReservationForm();
        formReserv.ShowDialog();
    }

    private void historiqueToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var formReserv = new CompteForm();
        formReserv.ShowDialog();
    }

    private void Acceuil_Load(object sender, EventArgs e)
    {
    }


    private void acceuilToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void evenementsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var formReserv = new ListEventForm();
        formReserv.ShowDialog();
    }

    private void label1_Click(object sender, EventArgs e)
    {
    }

    private void inscriptionToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var formReserv = new InscriptionForm();
        formReserv.ShowDialog();
    }

    private void panierToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var formReserv = new PanierForm();
        formReserv.ShowDialog();
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
}