namespace WindowsFormsApp1
{
    partial class Acceuil
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            acceuilToolStripMenuItem = new ToolStripMenuItem();
            inscriptionToolStripMenuItem = new ToolStripMenuItem();
            compteToolStripMenuItem = new ToolStripMenuItem();
            panierToolStripMenuItem = new ToolStripMenuItem();
            reservationToolStripMenuItem = new ToolStripMenuItem();
            historiqueToolStripMenuItem = new ToolStripMenuItem();
            evenementsToolStripMenuItem = new ToolStripMenuItem();
            aideToolStripMenuItem = new ToolStripMenuItem();
            aProposToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panelAcceuil = new Panel();
            buttonDeconnexion = new Button();
            label3 = new Label();
            textBoxAcceuilPassword = new TextBox();
            textBoxAcceuilUser = new TextBox();
            label2 = new Label();
            label1 = new Label();
            buttonConnexion = new Button();
            menuStrip1.SuspendLayout();
            panelAcceuil.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { acceuilToolStripMenuItem, compteToolStripMenuItem, evenementsToolStripMenuItem, aideToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(802, 28);
            menuStrip1.TabIndex = 16;
            menuStrip1.Text = "menuStrip1";
            // 
            // acceuilToolStripMenuItem
            // 
            acceuilToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { inscriptionToolStripMenuItem });
            acceuilToolStripMenuItem.Name = "acceuilToolStripMenuItem";
            acceuilToolStripMenuItem.Size = new Size(71, 24);
            acceuilToolStripMenuItem.Text = "Acceuil";
            acceuilToolStripMenuItem.Click += acceuilToolStripMenuItem_Click;
            // 
            // inscriptionToolStripMenuItem
            // 
            inscriptionToolStripMenuItem.Name = "inscriptionToolStripMenuItem";
            inscriptionToolStripMenuItem.Size = new Size(161, 26);
            inscriptionToolStripMenuItem.Text = "Inscription";
            inscriptionToolStripMenuItem.Click += inscriptionToolStripMenuItem_Click;
            // 
            // compteToolStripMenuItem
            // 
            compteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { panierToolStripMenuItem, reservationToolStripMenuItem, historiqueToolStripMenuItem });
            compteToolStripMenuItem.Name = "compteToolStripMenuItem";
            compteToolStripMenuItem.Size = new Size(76, 24);
            compteToolStripMenuItem.Text = "Compte";
            // 
            // panierToolStripMenuItem
            // 
            panierToolStripMenuItem.Name = "panierToolStripMenuItem";
            panierToolStripMenuItem.Size = new Size(224, 26);
            panierToolStripMenuItem.Text = "Panier";
            panierToolStripMenuItem.Click += panierToolStripMenuItem_Click;
            // 
            // reservationToolStripMenuItem
            // 
            reservationToolStripMenuItem.Name = "reservationToolStripMenuItem";
            reservationToolStripMenuItem.Size = new Size(224, 26);
            reservationToolStripMenuItem.Text = "Reservation";
            reservationToolStripMenuItem.Click += reservationToolStripMenuItem_Click;
            // 
            // historiqueToolStripMenuItem
            // 
            historiqueToolStripMenuItem.Name = "historiqueToolStripMenuItem";
            historiqueToolStripMenuItem.Size = new Size(224, 26);
            historiqueToolStripMenuItem.Text = "Historique";
            historiqueToolStripMenuItem.Click += historiqueToolStripMenuItem_Click;
            // 
            // evenementsToolStripMenuItem
            // 
            evenementsToolStripMenuItem.Name = "evenementsToolStripMenuItem";
            evenementsToolStripMenuItem.Size = new Size(102, 24);
            evenementsToolStripMenuItem.Text = "Evenements";
            evenementsToolStripMenuItem.Click += evenementsToolStripMenuItem_Click;
            // 
            // aideToolStripMenuItem
            // 
            aideToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aProposToolStripMenuItem });
            aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            aideToolStripMenuItem.Size = new Size(54, 24);
            aideToolStripMenuItem.Text = "Aide";
            // 
            // aProposToolStripMenuItem
            // 
            aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            aProposToolStripMenuItem.Size = new Size(153, 26);
            aProposToolStripMenuItem.Text = "A propos";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // panelAcceuil
            // 
            panelAcceuil.Controls.Add(buttonDeconnexion);
            panelAcceuil.Controls.Add(label3);
            panelAcceuil.Controls.Add(textBoxAcceuilPassword);
            panelAcceuil.Controls.Add(textBoxAcceuilUser);
            panelAcceuil.Controls.Add(label2);
            panelAcceuil.Controls.Add(label1);
            panelAcceuil.Controls.Add(buttonConnexion);
            panelAcceuil.Location = new Point(0, 32);
            panelAcceuil.Margin = new Padding(3, 4, 3, 4);
            panelAcceuil.Name = "panelAcceuil";
            panelAcceuil.Size = new Size(802, 515);
            panelAcceuil.TabIndex = 19;
            // 
            // buttonDeconnexion
            // 
            buttonDeconnexion.Location = new Point(424, 435);
            buttonDeconnexion.Margin = new Padding(3, 4, 3, 4);
            buttonDeconnexion.Name = "buttonDeconnexion";
            buttonDeconnexion.Size = new Size(112, 29);
            buttonDeconnexion.TabIndex = 6;
            buttonDeconnexion.Text = "Deconnexion";
            buttonDeconnexion.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(340, 90);
            label3.Name = "label3";
            label3.Size = new Size(151, 46);
            label3.TabIndex = 5;
            label3.Text = "Acceuil";
            // 
            // textBoxAcceuilPassword
            // 
            textBoxAcceuilPassword.Location = new Point(381, 266);
            textBoxAcceuilPassword.Margin = new Padding(3, 4, 3, 4);
            textBoxAcceuilPassword.Name = "textBoxAcceuilPassword";
            textBoxAcceuilPassword.Size = new Size(100, 27);
            textBoxAcceuilPassword.TabIndex = 4;
            // 
            // textBoxAcceuilUser
            // 
            textBoxAcceuilUser.Location = new Point(381, 212);
            textBoxAcceuilUser.Margin = new Padding(3, 4, 3, 4);
            textBoxAcceuilUser.Name = "textBoxAcceuilUser";
            textBoxAcceuilUser.Size = new Size(100, 27);
            textBoxAcceuilUser.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(211, 269);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 2;
            label2.Text = "Mot de passe";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(211, 215);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 1;
            label1.Text = "Nom d'utilisateur";
            label1.Click += label1_Click;
            // 
            // buttonConnexion
            // 
            buttonConnexion.Location = new Point(291, 435);
            buttonConnexion.Margin = new Padding(3, 4, 3, 4);
            buttonConnexion.Name = "buttonConnexion";
            buttonConnexion.Size = new Size(113, 29);
            buttonConnexion.TabIndex = 0;
            buttonConnexion.Text = "Connexion";
            buttonConnexion.UseVisualStyleBackColor = true;
            // 
            // Acceuil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 566);
            Controls.Add(panelAcceuil);
            Controls.Add(menuStrip1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Acceuil";
            Text = " ";
            Load += Acceuil_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelAcceuil.ResumeLayout(false);
            panelAcceuil.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Button buttonDeconnexion;
        private Label label3;
        private TextBox textBoxAcceuilPassword;
        private TextBox textBoxAcceuilUser;
        private Label label2;
        private Label label1;
        private Button buttonConnexion;
        private ToolStripMenuItem inscriptionToolStripMenuItem;
        private ToolStripMenuItem panierToolStripMenuItem;
    }
}