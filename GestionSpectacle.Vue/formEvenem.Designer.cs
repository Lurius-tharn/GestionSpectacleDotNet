namespace WindowsFormsApp1
{
    partial class formEvenem
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerFirst = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerLast = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonPanier = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.spectaclesDataGridView = new System.Windows.Forms.DataGridView();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buttonRechercher = new System.Windows.Forms.Button();
            this.VilleSpectacleInput = new System.Windows.Forms.TextBox();
            this.evenNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evenType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evenDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evenLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evenPlaces = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evenPrix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evenImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelAcceuil.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spectaclesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAcceuil
            // 
            this.panelAcceuil.Controls.Add(this.VilleSpectacleInput);
            this.panelAcceuil.Controls.Add(this.buttonRechercher);
            this.panelAcceuil.Controls.Add(this.label3);
            this.panelAcceuil.Controls.Add(this.label2);
            this.panelAcceuil.Controls.Add(this.label1);
            this.panelAcceuil.Controls.Add(this.dateTimePickerFirst);
            this.panelAcceuil.Controls.Add(this.dateTimePickerLast);
            this.panelAcceuil.Controls.Add(this.panel1);
            this.panelAcceuil.Controls.Add(this.monthCalendar);
            this.panelAcceuil.Location = new System.Drawing.Point(10, 29);
            this.panelAcceuil.Name = "panelAcceuil";
            this.panelAcceuil.Size = new System.Drawing.Size(990, 549);
            this.panelAcceuil.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(11, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = "Evenements";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Au";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Du";
            // 
            // dateTimePickerFirst
            // 
            this.dateTimePickerFirst.Location = new System.Drawing.Point(8, 87);
            this.dateTimePickerFirst.Name = "dateTimePickerFirst";
            this.dateTimePickerFirst.Size = new System.Drawing.Size(230, 23);
            this.dateTimePickerFirst.TabIndex = 4;
            // 
            // dateTimePickerLast
            // 
            this.dateTimePickerLast.Location = new System.Drawing.Point(8, 140);
            this.dateTimePickerLast.Name = "dateTimePickerLast";
            this.dateTimePickerLast.Size = new System.Drawing.Size(230, 23);
            this.dateTimePickerLast.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonPanier);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.buttonNext);
            this.panel1.Controls.Add(this.buttonPrevious);
            this.panel1.Location = new System.Drawing.Point(245, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 532);
            this.panel1.TabIndex = 2;
            // 
            // buttonPanier
            // 
            this.buttonPanier.Location = new System.Drawing.Point(326, 474);
            this.buttonPanier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPanier.Name = "buttonPanier";
            this.buttonPanier.Size = new System.Drawing.Size(82, 22);
            this.buttonPanier.TabIndex = 4;
            this.buttonPanier.Text = "Panier";
            this.buttonPanier.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.spectaclesDataGridView);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(740, 431);
            this.panel2.TabIndex = 3;
            // 
            // spectaclesDataGridView
            // 
            this.spectaclesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.spectaclesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.evenNom,
            this.evenType,
            this.evenDate,
            this.evenLieu,
            this.evenPlaces,
            this.evenPrix,
            this.evenImage});
            this.spectaclesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spectaclesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.spectaclesDataGridView.Name = "spectaclesDataGridView";
            this.spectaclesDataGridView.RowHeadersWidth = 51;
            this.spectaclesDataGridView.RowTemplate.Height = 24;
            this.spectaclesDataGridView.Size = new System.Drawing.Size(740, 431);
            this.spectaclesDataGridView.TabIndex = 4;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(628, 466);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(47, 37);
            this.buttonNext.TabIndex = 1;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = true;
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(48, 466);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(47, 37);
            this.buttonPrevious.TabIndex = 0;
            this.buttonPrevious.Text = "<";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(0, 288);
            this.monthCalendar.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // buttonRechercher
            // 
            this.buttonRechercher.Location = new System.Drawing.Point(77, 500);
            this.buttonRechercher.Name = "buttonRechercher";
            this.buttonRechercher.Size = new System.Drawing.Size(75, 23);
            this.buttonRechercher.TabIndex = 8;
            this.buttonRechercher.Text = "Rechercher";
            this.buttonRechercher.UseVisualStyleBackColor = true;
            this.buttonRechercher.Click += new System.EventHandler(this.buttonRechercher_Click_1);
            // 
            // VilleSpectacleInput
            // 
            this.VilleSpectacleInput.Location = new System.Drawing.Point(11, 217);
            this.VilleSpectacleInput.Name = "VilleSpectacleInput";
            this.VilleSpectacleInput.Size = new System.Drawing.Size(216, 23);
            this.VilleSpectacleInput.TabIndex = 9;
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
            this.evenImage.Name = "evenImage";
            // 
            // formEvenem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 586);
            this.Controls.Add(this.panelAcceuil);
            this.Name = "formEvenem";
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
        private Button buttonPrevious;
        private MonthCalendar monthCalendar;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePickerFirst;
        private DateTimePicker dateTimePickerLast;
        private Button buttonNext;
        private Label label3;
        private Panel panel2;
        private Button buttonPanier;
        private DataGridView spectaclesDataGridView;
        private Button buttonRechercher;
        private TextBox VilleSpectacleInput;
        private DataGridViewTextBoxColumn evenNom;
        private DataGridViewTextBoxColumn evenType;
        private DataGridViewTextBoxColumn evenDate;
        private DataGridViewTextBoxColumn evenLieu;
        private DataGridViewTextBoxColumn evenPlaces;
        private DataGridViewTextBoxColumn evenPrix;
        private DataGridViewImageColumn evenImage;
    }
}