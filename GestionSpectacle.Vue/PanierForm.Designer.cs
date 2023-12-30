namespace GestionSpectacle.Vue
{
    partial class PanierForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cartDataGridView = new System.Windows.Forms.DataGridView();
            this.panierTitre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panierDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panierType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panierPlaces = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panierLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panierPrix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelAcceuil = new System.Windows.Forms.Panel();
            this.buttonPaye = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.totalPriceText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cartDataGridView)).BeginInit();
            this.panelAcceuil.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(418, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Panier";
            // 
            // cartDataGridView
            // 
            this.cartDataGridView.AllowUserToAddRows = false;
            this.cartDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.panierTitre,
            this.panierDate,
            this.panierType,
            this.panierPlaces,
            this.panierLieu,
            this.panierPrix});
            this.cartDataGridView.Location = new System.Drawing.Point(4, 198);
            this.cartDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cartDataGridView.Name = "cartDataGridView";
            this.cartDataGridView.RowHeadersWidth = 51;
            this.cartDataGridView.RowTemplate.Height = 24;
            this.cartDataGridView.Size = new System.Drawing.Size(964, 440);
            this.cartDataGridView.TabIndex = 2;
            // 
            // panierTitre
            // 
            this.panierTitre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.panierTitre.HeaderText = "Titre";
            this.panierTitre.MinimumWidth = 6;
            this.panierTitre.Name = "panierTitre";
            this.panierTitre.ReadOnly = true;
            // 
            // panierDate
            // 
            this.panierDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.panierDate.HeaderText = "Date";
            this.panierDate.MinimumWidth = 6;
            this.panierDate.Name = "panierDate";
            this.panierDate.ReadOnly = true;
            // 
            // panierType
            // 
            this.panierType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.panierType.HeaderText = "Type";
            this.panierType.MinimumWidth = 6;
            this.panierType.Name = "panierType";
            this.panierType.ReadOnly = true;
            // 
            // panierPlaces
            // 
            this.panierPlaces.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.panierPlaces.HeaderText = "Places";
            this.panierPlaces.MinimumWidth = 6;
            this.panierPlaces.Name = "panierPlaces";
            this.panierPlaces.ReadOnly = true;
            // 
            // panierLieu
            // 
            this.panierLieu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.panierLieu.HeaderText = "Lieu";
            this.panierLieu.MinimumWidth = 6;
            this.panierLieu.Name = "panierLieu";
            this.panierLieu.ReadOnly = true;
            // 
            // panierPrix
            // 
            this.panierPrix.HeaderText = "Prix";
            this.panierPrix.MinimumWidth = 6;
            this.panierPrix.Name = "panierPrix";
            this.panierPrix.Width = 125;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panelAcceuil
            // 
            this.panelAcceuil.Controls.Add(this.cartDataGridView);
            this.panelAcceuil.Controls.Add(this.label1);
            this.panelAcceuil.Location = new System.Drawing.Point(16, -20);
            this.panelAcceuil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelAcceuil.Name = "panelAcceuil";
            this.panelAcceuil.Size = new System.Drawing.Size(968, 652);
            this.panelAcceuil.TabIndex = 21;
            // 
            // buttonPaye
            // 
            this.buttonPaye.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonPaye.Location = new System.Drawing.Point(835, 654);
            this.buttonPaye.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPaye.Name = "buttonPaye";
            this.buttonPaye.Size = new System.Drawing.Size(133, 53);
            this.buttonPaye.TabIndex = 22;
            this.buttonPaye.Text = "Payer";
            this.buttonPaye.UseVisualStyleBackColor = true;
            this.buttonPaye.Click += new System.EventHandler(this.buttonPaye_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(469, 660);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 41);
            this.label2.TabIndex = 3;
            this.label2.Text = "£ Prix Total : ";
            // 
            // totalPriceText
            // 
            this.totalPriceText.AutoSize = true;
            this.totalPriceText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalPriceText.Location = new System.Drawing.Point(676, 667);
            this.totalPriceText.Name = "totalPriceText";
            this.totalPriceText.Size = new System.Drawing.Size(78, 32);
            this.totalPriceText.TabIndex = 23;
            this.totalPriceText.Text = "label3";
            // 
            // PanierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 720);
            this.Controls.Add(this.totalPriceText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonPaye);
            this.Controls.Add(this.panelAcceuil);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PanierForm";
            this.Text = "formPanier";
            ((System.ComponentModel.ISupportInitialize)(this.cartDataGridView)).EndInit();
            this.panelAcceuil.ResumeLayout(false);
            this.panelAcceuil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView cartDataGridView;
        private ContextMenuStrip contextMenuStrip1;
        private Panel panelAcceuil;
        private Button buttonPaye;
        private DataGridViewTextBoxColumn panierTitre;
        private DataGridViewTextBoxColumn panierDate;
        private DataGridViewTextBoxColumn panierType;
        private DataGridViewTextBoxColumn panierPlaces;
        private DataGridViewTextBoxColumn panierLieu;
        private DataGridViewTextBoxColumn panierPrix;
        private Label label2;
        private Label totalPriceText;
    }
}