namespace GestionSpectacle.Vue
{
    partial class HistoriqueForm
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
            this.panelAcceuil = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.historiqueDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.IdReservation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evenNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroBillet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evenType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evenDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evenLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evenPrix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evenImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.DaterSuppression = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelAcceuil.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historiqueDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAcceuil
            // 
            this.panelAcceuil.Controls.Add(this.panel1);
            this.panelAcceuil.Controls.Add(this.label1);
            this.panelAcceuil.Location = new System.Drawing.Point(20, 4);
            this.panelAcceuil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelAcceuil.Name = "panelAcceuil";
            this.panelAcceuil.Size = new System.Drawing.Size(1427, 914);
            this.panelAcceuil.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.historiqueDataGridView);
            this.panel1.Location = new System.Drawing.Point(3, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1415, 687);
            this.panel1.TabIndex = 2;
            // 
            // historiqueDataGridView
            // 
            this.historiqueDataGridView.ColumnHeadersHeight = 34;
            this.historiqueDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.historiqueDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdReservation,
            this.evenNom,
            this.NumeroBillet,
            this.evenType,
            this.evenDate,
            this.evenLieu,
            this.evenPrix,
            this.evenImage,
            this.DaterSuppression});
            this.historiqueDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historiqueDataGridView.Location = new System.Drawing.Point(0, 0);
            this.historiqueDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.historiqueDataGridView.Name = "historiqueDataGridView";
            this.historiqueDataGridView.RowHeadersWidth = 51;
            this.historiqueDataGridView.RowTemplate.Height = 70;
            this.historiqueDataGridView.Size = new System.Drawing.Size(1415, 687);
            this.historiqueDataGridView.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(503, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 69);
            this.label1.TabIndex = 1;
            this.label1.Text = "Historique";
            // 
            // IdReservation
            // 
            this.IdReservation.HeaderText = "N° Réservation";
            this.IdReservation.MinimumWidth = 8;
            this.IdReservation.Name = "IdReservation";
            this.IdReservation.Width = 150;
            // 
            // evenNom
            // 
            this.evenNom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.evenNom.HeaderText = "Nom du spectacle";
            this.evenNom.MinimumWidth = 6;
            this.evenNom.Name = "evenNom";
            // 
            // NumeroBillet
            // 
            this.NumeroBillet.HeaderText = "Numéro du billet";
            this.NumeroBillet.MinimumWidth = 8;
            this.NumeroBillet.Name = "NumeroBillet";
            this.NumeroBillet.Width = 150;
            // 
            // evenType
            // 
            this.evenType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.evenType.HeaderText = "Type";
            this.evenType.MinimumWidth = 6;
            this.evenType.Name = "evenType";
            // 
            // evenDate
            // 
            this.evenDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.evenDate.HeaderText = "Date";
            this.evenDate.MinimumWidth = 6;
            this.evenDate.Name = "evenDate";
            // 
            // evenLieu
            // 
            this.evenLieu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.evenLieu.HeaderText = "Lieu";
            this.evenLieu.MinimumWidth = 6;
            this.evenLieu.Name = "evenLieu";
            // 
            // evenPrix
            // 
            this.evenPrix.HeaderText = "Prix";
            this.evenPrix.MinimumWidth = 6;
            this.evenPrix.Name = "evenPrix";
            this.evenPrix.Width = 125;
            // 
            // evenImage
            // 
            this.evenImage.HeaderText = "Image";
            this.evenImage.MinimumWidth = 8;
            this.evenImage.Name = "evenImage";
            this.evenImage.Width = 150;
            // 
            // DaterSuppression
            // 
            this.DaterSuppression.HeaderText = "Date de suppression";
            this.DaterSuppression.MinimumWidth = 8;
            this.DaterSuppression.Name = "DaterSuppression";
            this.DaterSuppression.Width = 150;
            // 
            // HistoriqueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1460, 790);
            this.Controls.Add(this.panelAcceuil);
            this.Name = "HistoriqueForm";
            this.Text = "HistoriqueForm";
            this.panelAcceuil.ResumeLayout(false);
            this.panelAcceuil.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.historiqueDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelAcceuil;
        private Panel panel1;
        private DataGridView historiqueDataGridView;
        private Label label1;
        private DataGridViewTextBoxColumn IdReservation;
        private DataGridViewTextBoxColumn evenNom;
        private DataGridViewTextBoxColumn NumeroBillet;
        private DataGridViewTextBoxColumn evenType;
        private DataGridViewTextBoxColumn evenDate;
        private DataGridViewTextBoxColumn evenLieu;
        private DataGridViewTextBoxColumn evenPrix;
        private DataGridViewImageColumn evenImage;
        private DataGridViewTextBoxColumn DaterSuppression;
    }
}