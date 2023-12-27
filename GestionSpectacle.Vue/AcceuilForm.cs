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
    private HistoriqueForm historiqueForm;
    private Panel mainPanel;
    private ReservationForm reservationForm;

    public AcceuilForm()
    {
        InitializeComponent();
        formInscription = new InscriptionForm();
        formInscription.AcceuilForm = this;
        _formConnexion = new ConnexionForm();
        _formConnexion.AcceuilForm = this;

        _formEvenem = new ListEventForm();
        _formPanier = new PanierForm();
        SetMenuConnect();
    }

    public void SetMenuConnect()
    {
        if (Settings.Default.isConnected || UserSingleton.Instance.IsConnected())
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
        reservationForm = new ReservationForm();

        FormUtilities.ShowFormInPanel(panelAcceuil, reservationForm);
    }

    private void seDéconnecterToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Settings.Default.UserId = 0;
        Settings.Default.UserName = null;
        Settings.Default.isConnected = false;
        Settings.Default.Save();
        Application.Exit();
    }

    private void historiqueToolStripMenuItem_Click(object sender, EventArgs e)
    {
        historiqueForm = new HistoriqueForm();

        FormUtilities.ShowFormInPanel(panelAcceuil, historiqueForm);
    }
}