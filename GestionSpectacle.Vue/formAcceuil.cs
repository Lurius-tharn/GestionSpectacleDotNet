using System.ComponentModel;
using GestionSpectacle.Vue;

namespace WindowsFormsApp1;

public partial class Acceuil : Form
{
    private readonly FormConnexion
        _formConnexion;

    private UserControl activeControl;
    private readonly formInscription formInscription;
    private Panel mainPanel;

    public Acceuil()
    {
        InitializeComponent();
        formInscription = new formInscription();
        _formConnexion = new FormConnexion();
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

    private void panelAcceuil_Paint_1(object sender, PaintEventArgs e)
    {
    }

    private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {
    }

    private void acceuilToolStripMenuItem_Click_1(object sender, EventArgs e)
    {
    }

    private void compteToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void panierToolStripMenuItem_Click_1(object sender, EventArgs e)
    {
    }

    private void reservationToolStripMenuItem_Click_1(object sender, EventArgs e)
    {
    }

    private void historiqueToolStripMenuItem_Click_1(object sender, EventArgs e)
    {
    }

    private void evenementsToolStripMenuItem_Click_1(object sender, EventArgs e)
    {
    }

    private void aideToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
    {
    }

    private void textBoxAcceuilUser_TextChanged(object sender, EventArgs e)
    {
    }

    private void buttonDeconnexion_Click(object sender, EventArgs e)
    {
    }

    private void label2_Click(object sender, EventArgs e)
    {
    }

    private void label3_Click(object sender, EventArgs e)
    {
    }

    private void textBoxAcceuilPassword_TextChanged(object sender, EventArgs e)
    {
    }

    private void label1_Click_1(object sender, EventArgs e)
    {
    }
}