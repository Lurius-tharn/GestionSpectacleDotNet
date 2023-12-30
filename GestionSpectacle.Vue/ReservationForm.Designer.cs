namespace WindowsFormsApp1
{
    partial class ReservationForm
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelAcceuil = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reservationDataGridView = new System.Windows.Forms.DataGridView();
            this.IdReservation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evenNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroBillet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evenType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evenDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evenLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evenPrix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evenImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.evenConsult = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CancelButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panelAcceuil.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // panelAcceuil
            // 
            this.panelAcceuil.Controls.Add(this.panel1);
            this.panelAcceuil.Controls.Add(this.label1);
            this.panelAcceuil.Location = new System.Drawing.Point(15, 58);
            this.panelAcceuil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelAcceuil.Name = "panelAcceuil";
            this.panelAcceuil.Size = new System.Drawing.Size(1427, 914);
            this.panelAcceuil.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reservationDataGridView);
            this.panel1.Location = new System.Drawing.Point(3, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1415, 687);
            this.panel1.TabIndex = 2;
            // 
            // reservationDataGridView
            // 
            this.reservationDataGridView.AllowUserToAddRows = false;
            this.reservationDataGridView.ColumnHeadersHeight = 34;
            this.reservationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.reservationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdReservation,
            this.evenNom,
            this.NumeroBillet,
            this.evenType,
            this.evenDate,
            this.evenLieu,
            this.evenPrix,
            this.evenImage,
            this.evenConsult,
            this.CancelButton});
            this.reservationDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reservationDataGridView.Location = new System.Drawing.Point(0, 0);
            this.reservationDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reservationDataGridView.Name = "reservationDataGridView";
            this.reservationDataGridView.RowHeadersWidth = 51;
            this.reservationDataGridView.RowTemplate.Height = 70;
            this.reservationDataGridView.Size = new System.Drawing.Size(1415, 687);
            this.reservationDataGridView.TabIndex = 5;
            this.reservationDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reservationDataGridView_CellContentClick);
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
            // evenConsult
            // 
            this.evenConsult.FillWeight = 30F;
            this.evenConsult.HeaderText = "Consulter le spectacle";
            this.evenConsult.MinimumWidth = 8;
            this.evenConsult.Name = "evenConsult";
            this.evenConsult.Text = "👁️";
            this.evenConsult.Width = 40;
            // 
            // CancelButton
            // 
            this.CancelButton.HeaderText = "Annuler la reservation";
            this.CancelButton.MinimumWidth = 8;
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Width = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(503, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 69);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reservation";
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 978);
            this.Controls.Add(this.panelAcceuil);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ReservationForm";
            this.Text = "formReserv";
            this.panelAcceuil.ResumeLayout(false);
            this.panelAcceuil.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reservationDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private Panel panelAcceuil;
        private Label label1;
        private Panel panel1;
        private DataGridView reservationDataGridView;
        private DataGridViewTextBoxColumn evenPlaces;
        private DataGridViewTextBoxColumn IdReservation;
        private DataGridViewTextBoxColumn evenNom;
        private DataGridViewTextBoxColumn NumeroBillet;
        private DataGridViewTextBoxColumn evenType;
        private DataGridViewTextBoxColumn evenDate;
        private DataGridViewTextBoxColumn evenLieu;
        private DataGridViewTextBoxColumn evenPrix;
        private DataGridViewImageColumn evenImage;
        private DataGridViewButtonColumn evenConsult;
        private DataGridViewButtonColumn CancelButton;
    }
}