using GestionSpectacle.Vue;

namespace WindowsFormsApp1;

public partial class Acceuil : Form
{
    private readonly FormConnexion
        _formConnexion;

    private readonly formInscription formInscription;

    private readonly formEvenem _formEvenem;

    private UserControl activeControl;
    private Panel mainPanel;

    public Acceuil()
    {
        InitializeComponent();
        formInscription = new formInscription();
        _formConnexion = new FormConnexion();
        _formEvenem = new formEvenem();
    }


    private void panelAcceuil_Paint(object sender, PaintEventArgs e)
    {
    }

    private void reservationToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var formReserv = new formReserv();
        formReserv.ShowDialog();
    }

    private void historiqueToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var formReserv = new formCompte();
        formReserv.ShowDialog();
    }

    private void Acceuil_Load(object sender, EventArgs e)
    {
    }

    private void ShowFormInPanel(Form formToShow)
    {
        // Effacez le contenu actuel du panel
        panelAcceuil.Controls.Clear();

        // Ajoutez le nouveau formulaire au panel
        formToShow.TopLevel = false;
        formToShow.FormBorderStyle = FormBorderStyle.None;
        formToShow.Dock = DockStyle.Fill;
        panelAcceuil.Controls.Add(formToShow);
        formToShow.Show();
    }

    private void acceuilToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void evenementsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var formReserv = new formEvenem();
        formReserv.ShowDialog();
    }

    private void label1_Click(object sender, EventArgs e)
    {
    }

    private void inscriptionToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var formReserv = new formInscription();
        formReserv.ShowDialog();
    }

    private void panierToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var formReserv = new formPanier();
        formReserv.ShowDialog();
    }


    private void inscriptionToolStripMenuItem_Click_1(object sender, EventArgs e)
    {
        ShowFormInPanel(formInscription);
    }

    private void toolStripMenuItem1_Click(object sender, EventArgs e)
    {
        ShowFormInPanel(_formConnexion);
    }


    private void rechercherDesEvenementsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ShowFormInPanel(_formEvenem);
    }
}