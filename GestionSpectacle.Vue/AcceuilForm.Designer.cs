namespace WindowsFormsApp1
{
    partial class AcceuilForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.acceuilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.seDéconnecterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evenementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercherDesEvenementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelAcceuil = new System.Windows.Forms.Panel();
            this.isConnectedTextLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panelAcceuil.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acceuilToolStripMenuItem,
            this.compteToolStripMenuItem,
            this.evenementsToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1022, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // acceuilToolStripMenuItem
            // 
            this.acceuilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inscriptionToolStripMenuItem,
            this.connectionStripMenuItem1,
            this.seDéconnecterToolStripMenuItem});
            this.acceuilToolStripMenuItem.Name = "acceuilToolStripMenuItem";
            this.acceuilToolStripMenuItem.Size = new System.Drawing.Size(58, 22);
            this.acceuilToolStripMenuItem.Text = "Acceuil";
            // 
            // inscriptionToolStripMenuItem
            // 
            this.inscriptionToolStripMenuItem.Name = "inscriptionToolStripMenuItem";
            this.inscriptionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inscriptionToolStripMenuItem.Text = "Inscription";
            this.inscriptionToolStripMenuItem.Click += new System.EventHandler(this.inscriptionToolStripMenuItem_Click_1);
            // 
            // connectionStripMenuItem1
            // 
            this.connectionStripMenuItem1.Name = "connectionStripMenuItem1";
            this.connectionStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.connectionStripMenuItem1.Text = "Connection";
            this.connectionStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // seDéconnecterToolStripMenuItem
            // 
            this.seDéconnecterToolStripMenuItem.Name = "seDéconnecterToolStripMenuItem";
            this.seDéconnecterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.seDéconnecterToolStripMenuItem.Text = "Se Déconnecter";
            this.seDéconnecterToolStripMenuItem.Click += new System.EventHandler(this.seDéconnecterToolStripMenuItem_Click);
            // 
            // compteToolStripMenuItem
            // 
            this.compteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.panierToolStripMenuItem,
            this.reservationToolStripMenuItem,
            this.historiqueToolStripMenuItem});
            this.compteToolStripMenuItem.Name = "compteToolStripMenuItem";
            this.compteToolStripMenuItem.Size = new System.Drawing.Size(62, 22);
            this.compteToolStripMenuItem.Text = "Compte";
            // 
            // panierToolStripMenuItem
            // 
            this.panierToolStripMenuItem.Name = "panierToolStripMenuItem";
            this.panierToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.panierToolStripMenuItem.Text = "Panier";
            this.panierToolStripMenuItem.Click += new System.EventHandler(this.panierToolStripMenuItem_Click_1);
            // 
            // reservationToolStripMenuItem
            // 
            this.reservationToolStripMenuItem.Name = "reservationToolStripMenuItem";
            this.reservationToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.reservationToolStripMenuItem.Text = "Reservation";
            this.reservationToolStripMenuItem.Click += new System.EventHandler(this.reservationToolStripMenuItem_Click);
            // 
            // historiqueToolStripMenuItem
            // 
            this.historiqueToolStripMenuItem.Name = "historiqueToolStripMenuItem";
            this.historiqueToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.historiqueToolStripMenuItem.Text = "Historique";
            // 
            // evenementsToolStripMenuItem
            // 
            this.evenementsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rechercherDesEvenementsToolStripMenuItem});
            this.evenementsToolStripMenuItem.Name = "evenementsToolStripMenuItem";
            this.evenementsToolStripMenuItem.Size = new System.Drawing.Size(83, 22);
            this.evenementsToolStripMenuItem.Text = "Evenements";
            // 
            // rechercherDesEvenementsToolStripMenuItem
            // 
            this.rechercherDesEvenementsToolStripMenuItem.Name = "rechercherDesEvenementsToolStripMenuItem";
            this.rechercherDesEvenementsToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.rechercherDesEvenementsToolStripMenuItem.Text = "Rechercher des evenements";
            this.rechercherDesEvenementsToolStripMenuItem.Click += new System.EventHandler(this.rechercherDesEvenementsToolStripMenuItem_Click);
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aProposToolStripMenuItem});
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 22);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aProposToolStripMenuItem.Text = "A propos";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panelAcceuil
            // 
            this.panelAcceuil.AutoSize = true;
            this.panelAcceuil.Controls.Add(this.isConnectedTextLabel);
            this.panelAcceuil.Controls.Add(this.label3);
            this.panelAcceuil.Location = new System.Drawing.Point(9, 23);
            this.panelAcceuil.Name = "panelAcceuil";
            this.panelAcceuil.Size = new System.Drawing.Size(1027, 620);
            this.panelAcceuil.TabIndex = 19;
            // 
            // isConnectedTextLabel
            // 
            this.isConnectedTextLabel.AutoSize = true;
            this.isConnectedTextLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.isConnectedTextLabel.Location = new System.Drawing.Point(20, 146);
            this.isConnectedTextLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.isConnectedTextLabel.Name = "isConnectedTextLabel";
            this.isConnectedTextLabel.Size = new System.Drawing.Size(82, 21);
            this.isConnectedTextLabel.TabIndex = 6;
            this.isConnectedTextLabel.Text = "Bienvenue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(367, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 76);
            this.label3.TabIndex = 5;
            this.label3.Text = "Accueil";
            // 
            // AcceuilForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1022, 474);
            this.Controls.Add(this.panelAcceuil);
            this.Controls.Add(this.menuStrip1);
            this.Name = "AcceuilForm";
            this.Text = " ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelAcceuil.ResumeLayout(false);
            this.panelAcceuil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem acceuilToolStripMenuItem;
        private ToolStripMenuItem compteToolStripMenuItem;
        private ToolStripMenuItem reservationToolStripMenuItem;
        private ToolStripMenuItem historiqueToolStripMenuItem;
        private ToolStripMenuItem evenementsToolStripMenuItem;
        private ToolStripMenuItem aideToolStripMenuItem;
        private ToolStripMenuItem aProposToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private Panel panelAcceuil;
        private Label label3;
        private ToolStripMenuItem inscriptionToolStripMenuItem;
        private ToolStripMenuItem panierToolStripMenuItem;
        private ToolStripMenuItem connectionStripMenuItem1;
        private ToolStripMenuItem rechercherDesEvenementsToolStripMenuItem;
        private Label isConnectedTextLabel;
        private ToolStripMenuItem seDéconnecterToolStripMenuItem;
    }
}