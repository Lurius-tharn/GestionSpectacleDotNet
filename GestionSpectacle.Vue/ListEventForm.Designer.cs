namespace WindowsFormsApp1
{
    partial class ListEventForm
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
            this.panelAcceuil = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.VilleSpectacleInput = new System.Windows.Forms.TextBox();
            this.buttonRechercher = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerFirst = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerLast = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.spectaclesDataGridView = new System.Windows.Forms.DataGridView();
            this.evenNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evenType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evenDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evenLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evenPlaces = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Statut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evenPrix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evenImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.evenConsult = new System.Windows.Forms.DataGridViewButtonColumn();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelAcceuil.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spectaclesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAcceuil
            // 
            this.panelAcceuil.Controls.Add(this.label4);
            this.panelAcceuil.Controls.Add(this.VilleSpectacleInput);
            this.panelAcceuil.Controls.Add(this.buttonRechercher);
            this.panelAcceuil.Controls.Add(this.label3);
            this.panelAcceuil.Controls.Add(this.label2);
            this.panelAcceuil.Controls.Add(this.label1);
            this.panelAcceuil.Controls.Add(this.dateTimePickerFirst);
            this.panelAcceuil.Controls.Add(this.dateTimePickerLast);
            this.panelAcceuil.Controls.Add(this.panel1);
            this.panelAcceuil.Controls.Add(this.monthCalendar);
            this.panelAcceuil.Location = new System.Drawing.Point(14, 48);
            this.panelAcceuil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelAcceuil.Name = "panelAcceuil";
            this.panelAcceuil.Size = new System.Drawing.Size(1414, 915);
            this.panelAcceuil.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Villes des spectacles";
            // 
            // VilleSpectacleInput
            // 
            this.VilleSpectacleInput.Location = new System.Drawing.Point(16, 362);
            this.VilleSpectacleInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.VilleSpectacleInput.Name = "VilleSpectacleInput";
            this.VilleSpectacleInput.Size = new System.Drawing.Size(307, 31);
            this.VilleSpectacleInput.TabIndex = 9;
            this.VilleSpectacleInput.Text = "Paris";
            // 
            // buttonRechercher
            // 
            this.buttonRechercher.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonRechercher.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRechercher.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonRechercher.Location = new System.Drawing.Point(82, 734);
            this.buttonRechercher.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRechercher.Name = "buttonRechercher";
            this.buttonRechercher.Size = new System.Drawing.Size(196, 63);
            this.buttonRechercher.TabIndex = 8;
            this.buttonRechercher.Text = "Rechercher";
            this.buttonRechercher.UseVisualStyleBackColor = false;
            this.buttonRechercher.Click += new System.EventHandler(this.buttonRechercher_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(16, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 55);
            this.label3.TabIndex = 7;
            this.label3.Text = "Evenements";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 198);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Au";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Du";
            // 
            // dateTimePickerFirst
            // 
            this.dateTimePickerFirst.Location = new System.Drawing.Point(11, 145);
            this.dateTimePickerFirst.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerFirst.Name = "dateTimePickerFirst";
            this.dateTimePickerFirst.Size = new System.Drawing.Size(327, 31);
            this.dateTimePickerFirst.TabIndex = 4;
            // 
            // dateTimePickerLast
            // 
            this.dateTimePickerLast.Location = new System.Drawing.Point(11, 233);
            this.dateTimePickerLast.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerLast.Name = "dateTimePickerLast";
            this.dateTimePickerLast.Size = new System.Drawing.Size(327, 31);
            this.dateTimePickerLast.TabIndex = 3;
            this.dateTimePickerLast.Value = new System.DateTime(2024, 1, 12, 0, 0, 0, 0);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(350, 27);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1061, 887);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.spectaclesDataGridView);
            this.panel2.Location = new System.Drawing.Point(4, 5);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1057, 718);
            this.panel2.TabIndex = 3;
            // 
            // spectaclesDataGridView
            // 
            this.spectaclesDataGridView.ColumnHeadersHeight = 34;
            this.spectaclesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.spectaclesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.evenNom,
            this.evenType,
            this.evenDate,
            this.evenLieu,
            this.evenPlaces,
            this.Statut,
            this.evenPrix,
            this.evenImage,
            this.evenConsult});
            this.spectaclesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spectaclesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.spectaclesDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.spectaclesDataGridView.Name = "spectaclesDataGridView";
            this.spectaclesDataGridView.RowHeadersWidth = 51;
            this.spectaclesDataGridView.RowTemplate.Height = 70;
            this.spectaclesDataGridView.Size = new System.Drawing.Size(1057, 718);
            this.spectaclesDataGridView.TabIndex = 4;
            this.spectaclesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.spectaclesDataGridView_CellContentClick);
            // 
            // evenNom
            // 
            this.evenNom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.evenNom.HeaderText = "Nom";
            this.evenNom.MinimumWidth = 6;
            this.evenNom.Name = "evenNom";
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
            // evenPlaces
            // 
            this.evenPlaces.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.evenPlaces.HeaderText = "Places";
            this.evenPlaces.MinimumWidth = 6;
            this.evenPlaces.Name = "evenPlaces";
            // 
            // Statut
            // 
            this.Statut.HeaderText = "Statut";
            this.Statut.MinimumWidth = 8;
            this.Statut.Name = "Statut";
            this.Statut.Width = 150;
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
            this.evenConsult.HeaderText = "Consulter";
            this.evenConsult.MinimumWidth = 8;
            this.evenConsult.Name = "evenConsult";
            this.evenConsult.Text = "👁️";
            this.evenConsult.Width = 40;
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(16, 438);
            this.monthCalendar.Margin = new System.Windows.Forms.Padding(11, 13, 11, 13);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.ShowTodayCircle = false;
            this.monthCalendar.TabIndex = 1;
           
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ListEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1446, 913);
            this.Controls.Add(this.panelAcceuil);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ListEventForm";
            this.Text = "formEvenem";
            this.panelAcceuil.ResumeLayout(false);
            this.panelAcceuil.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spectaclesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panelAcceuil;
        private ContextMenuStrip contextMenuStrip1;
        private Panel panel1;
        private MonthCalendar monthCalendar;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePickerFirst;
        private DateTimePicker dateTimePickerLast;
        private Label label3;
        private Panel panel2;
        private DataGridView spectaclesDataGridView;
        private Button buttonRechercher;
        private TextBox VilleSpectacleInput;
        private Label label4;
        private DataGridViewTextBoxColumn evenNom;
        private DataGridViewTextBoxColumn evenType;
        private DataGridViewTextBoxColumn evenDate;
        private DataGridViewTextBoxColumn evenLieu;
        private DataGridViewTextBoxColumn evenPlaces;
        private DataGridViewTextBoxColumn Statut;
        private DataGridViewTextBoxColumn evenPrix;
        private DataGridViewImageColumn evenImage;
        private DataGridViewButtonColumn evenConsult;
    }
}