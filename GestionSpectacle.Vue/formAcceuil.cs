using GestionSpectacle.Vue;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Acceuil : Form
    {
        private UserControl activeControl;
        private Panel mainPanel;
        public Acceuil()
        {
            InitializeComponent();

        }



        private void panelAcceuil_Paint(object sender, PaintEventArgs e)
        {

        }

        private void reservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formReserv formReserv = new formReserv();
            formReserv.ShowDialog();
        }

        private void historiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCompte formReserv = new formCompte();
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
            formEvenem formReserv = new formEvenem();
            formReserv.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void inscriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formInscription formReserv = new formInscription();
            formReserv.ShowDialog();
        }

        private void panierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formPanier formReserv = new formPanier();
            formReserv.ShowDialog();
        }
    }
}