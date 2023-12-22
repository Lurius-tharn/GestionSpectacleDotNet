namespace GestionSpectacle.Vue
{
    partial class formPanier
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panierTitre = new DataGridViewTextBoxColumn();
            panierDate = new DataGridViewTextBoxColumn();
            panierType = new DataGridViewTextBoxColumn();
            panierPlaces = new DataGridViewTextBoxColumn();
            panierLieu = new DataGridViewTextBoxColumn();
            panierPrix = new DataGridViewTextBoxColumn();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panelAcceuil = new Panel();
            buttonPaye = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelAcceuil.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(334, 67);
            label1.Name = "label1";
            label1.Size = new Size(135, 46);
            label1.TabIndex = 1;
            label1.Text = "Panier";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { panierTitre, panierDate, panierType, panierPlaces, panierLieu, panierPrix });
            dataGridView1.Location = new Point(3, 158);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(771, 352);
            dataGridView1.TabIndex = 2;
            // 
            // panierTitre
            // 
            panierTitre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            panierTitre.HeaderText = "Titre";
            panierTitre.MinimumWidth = 6;
            panierTitre.Name = "panierTitre";
            panierTitre.ReadOnly = true;
            // 
            // panierDate
            // 
            panierDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            panierDate.HeaderText = "Date";
            panierDate.MinimumWidth = 6;
            panierDate.Name = "panierDate";
            panierDate.ReadOnly = true;
            // 
            // panierType
            // 
            panierType.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            panierType.HeaderText = "Type";
            panierType.MinimumWidth = 6;
            panierType.Name = "panierType";
            panierType.ReadOnly = true;
            // 
            // panierPlaces
            // 
            panierPlaces.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            panierPlaces.HeaderText = "Places";
            panierPlaces.MinimumWidth = 6;
            panierPlaces.Name = "panierPlaces";
            panierPlaces.ReadOnly = true;
            // 
            // panierLieu
            // 
            panierLieu.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            panierLieu.HeaderText = "Lieu";
            panierLieu.MinimumWidth = 6;
            panierLieu.Name = "panierLieu";
            panierLieu.ReadOnly = true;
            // 
            // panierPrix
            // 
            panierPrix.HeaderText = "Prix";
            panierPrix.MinimumWidth = 6;
            panierPrix.Name = "panierPrix";
            panierPrix.Width = 125;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // panelAcceuil
            // 
            panelAcceuil.Controls.Add(dataGridView1);
            panelAcceuil.Controls.Add(label1);
            panelAcceuil.Location = new Point(13, -16);
            panelAcceuil.Margin = new Padding(3, 4, 3, 4);
            panelAcceuil.Name = "panelAcceuil";
            panelAcceuil.Size = new Size(774, 522);
            panelAcceuil.TabIndex = 21;
            // 
            // buttonPaye
            // 
            buttonPaye.Location = new Point(347, 525);
            buttonPaye.Name = "buttonPaye";
            buttonPaye.Size = new Size(94, 29);
            buttonPaye.TabIndex = 22;
            buttonPaye.Text = "Payer";
            buttonPaye.UseVisualStyleBackColor = true;
            // 
            // formPanier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 576);
            Controls.Add(buttonPaye);
            Controls.Add(panelAcceuil);
            Name = "formPanier";
            Text = "formPanier";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelAcceuil.ResumeLayout(false);
            panelAcceuil.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private ContextMenuStrip contextMenuStrip1;
        private Panel panelAcceuil;
        private Button buttonPaye;
        private DataGridViewTextBoxColumn panierTitre;
        private DataGridViewTextBoxColumn panierDate;
        private DataGridViewTextBoxColumn panierType;
        private DataGridViewTextBoxColumn panierPlaces;
        private DataGridViewTextBoxColumn panierLieu;
        private DataGridViewTextBoxColumn panierPrix;
    }
}