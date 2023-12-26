namespace GestionSpectacle.Vue
{
    partial class EventForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.nbPlacesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.buttonPanier = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.descriptionTextLabel = new System.Windows.Forms.Label();
            this.eventNameLabel = new System.Windows.Forms.Label();
            this.panelAcceuil = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.nbPlaceMaxLabel = new System.Windows.Forms.Label();
            this.classificationLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.promotorLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.spectaclePictureBox = new System.Windows.Forms.PictureBox();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbPlacesNumericUpDown)).BeginInit();
            this.panelMain.SuspendLayout();
            this.panelAcceuil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spectaclePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.nbPlacesNumericUpDown);
            this.panel1.Controls.Add(this.buttonPanier);
            this.panel1.Controls.Add(this.panelMain);
            this.panel1.Location = new System.Drawing.Point(350, 27);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1061, 887);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 744);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Choix des places";
            // 
            // nbPlacesNumericUpDown
            // 
            this.nbPlacesNumericUpDown.Location = new System.Drawing.Point(33, 793);
            this.nbPlacesNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbPlacesNumericUpDown.Name = "nbPlacesNumericUpDown";
            this.nbPlacesNumericUpDown.Size = new System.Drawing.Size(180, 31);
            this.nbPlacesNumericUpDown.TabIndex = 5;
            this.nbPlacesNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonPanier
            // 
            this.buttonPanier.Location = new System.Drawing.Point(881, 768);
            this.buttonPanier.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonPanier.Name = "buttonPanier";
            this.buttonPanier.Size = new System.Drawing.Size(143, 78);
            this.buttonPanier.TabIndex = 4;
            this.buttonPanier.Text = "Ajouter au panier";
            this.buttonPanier.UseVisualStyleBackColor = true;
            this.buttonPanier.Click += new System.EventHandler(this.buttonPanier_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.descriptionTextLabel);
            this.panelMain.Location = new System.Drawing.Point(4, 5);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1057, 718);
            this.panelMain.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(4, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 41);
            this.label3.TabIndex = 1;
            this.label3.Text = "Description";
            // 
            // descriptionTextLabel
            // 
            this.descriptionTextLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descriptionTextLabel.Location = new System.Drawing.Point(4, 141);
            this.descriptionTextLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descriptionTextLabel.Name = "descriptionTextLabel";
            this.descriptionTextLabel.Size = new System.Drawing.Size(1047, 300);
            this.descriptionTextLabel.TabIndex = 0;
            this.descriptionTextLabel.Text = resources.GetString("descriptionTextLabel.Text");
            // 
            // eventNameLabel
            // 
            this.eventNameLabel.AutoSize = true;
            this.eventNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.eventNameLabel.Location = new System.Drawing.Point(4, 55);
            this.eventNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.eventNameLabel.Name = "eventNameLabel";
            this.eventNameLabel.Size = new System.Drawing.Size(268, 55);
            this.eventNameLabel.TabIndex = 7;
            this.eventNameLabel.Text = "Evenement";
            // 
            // panelAcceuil
            // 
            this.panelAcceuil.Controls.Add(this.button1);
            this.panelAcceuil.Controls.Add(this.nbPlaceMaxLabel);
            this.panelAcceuil.Controls.Add(this.classificationLabel);
            this.panelAcceuil.Controls.Add(this.label5);
            this.panelAcceuil.Controls.Add(this.label9);
            this.panelAcceuil.Controls.Add(this.promotorLabel);
            this.panelAcceuil.Controls.Add(this.label7);
            this.panelAcceuil.Controls.Add(this.priceLabel);
            this.panelAcceuil.Controls.Add(this.label4);
            this.panelAcceuil.Controls.Add(this.spectaclePictureBox);
            this.panelAcceuil.Controls.Add(this.startDateLabel);
            this.panelAcceuil.Controls.Add(this.eventNameLabel);
            this.panelAcceuil.Controls.Add(this.label1);
            this.panelAcceuil.Controls.Add(this.panel1);
            this.panelAcceuil.Location = new System.Drawing.Point(16, 0);
            this.panelAcceuil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelAcceuil.Name = "panelAcceuil";
            this.panelAcceuil.Size = new System.Drawing.Size(1414, 915);
            this.panelAcceuil.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 867);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 18;
            this.button1.Text = "Fermer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nbPlaceMaxLabel
            // 
            this.nbPlaceMaxLabel.AutoSize = true;
            this.nbPlaceMaxLabel.Location = new System.Drawing.Point(4, 756);
            this.nbPlaceMaxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nbPlaceMaxLabel.Name = "nbPlaceMaxLabel";
            this.nbPlaceMaxLabel.Size = new System.Drawing.Size(32, 25);
            this.nbPlaceMaxLabel.TabIndex = 15;
            this.nbPlaceMaxLabel.Text = "50";
            // 
            // classificationLabel
            // 
            this.classificationLabel.AutoSize = true;
            this.classificationLabel.Location = new System.Drawing.Point(4, 678);
            this.classificationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.classificationLabel.Name = "classificationLabel";
            this.classificationLabel.Size = new System.Drawing.Size(80, 25);
            this.classificationLabel.TabIndex = 15;
            this.classificationLabel.Text = "Musique";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(-3, 714);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 36);
            this.label5.TabIndex = 14;
            this.label5.Text = "nombre de places";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(-3, 636);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(299, 36);
            this.label9.TabIndex = 14;
            this.label9.Text = "Classification principale";
            // 
            // promotorLabel
            // 
            this.promotorLabel.AutoSize = true;
            this.promotorLabel.Location = new System.Drawing.Point(4, 595);
            this.promotorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.promotorLabel.Name = "promotorLabel";
            this.promotorLabel.Size = new System.Drawing.Size(155, 25);
            this.promotorLabel.TabIndex = 13;
            this.promotorLabel.Text = "SAS SALLE PLEYEL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(-3, 553);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(259, 36);
            this.label7.TabIndex = 12;
            this.label7.Text = "Promoteur principal";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(4, 508);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(56, 25);
            this.priceLabel.TabIndex = 11;
            this.priceLabel.Text = "39.40";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(-3, 466);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 36);
            this.label4.TabIndex = 10;
            this.label4.Text = "Prix";
            // 
            // spectaclePictureBox
            // 
            this.spectaclePictureBox.Location = new System.Drawing.Point(16, 233);
            this.spectaclePictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.spectaclePictureBox.Name = "spectaclePictureBox";
            this.spectaclePictureBox.Size = new System.Drawing.Size(297, 228);
            this.spectaclePictureBox.TabIndex = 9;
            this.spectaclePictureBox.TabStop = false;
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.startDateLabel.Location = new System.Drawing.Point(61, 143);
            this.startDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(108, 25);
            this.startDateLabel.TabIndex = 8;
            this.startDateLabel.Text = "22/11/2000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Date";
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1446, 913);
            this.Controls.Add(this.panelAcceuil);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EventForm";
            this.Text = "EventForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbPlacesNumericUpDown)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelAcceuil.ResumeLayout(false);
            this.panelAcceuil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spectaclePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button buttonPanier;
        private Panel panelMain;
        private Label eventNameLabel;
        private Panel panelAcceuil;
        private Label startDateLabel;
        private Label label1;
        private Label label3;
        private Label descriptionTextLabel;
        private PictureBox spectaclePictureBox;
        private Label classificationLabel;
        private Label label9;
        private Label promotorLabel;
        private Label label7;
        private Label priceLabel;
        private Label label4;
        private Button button1;
        private Label label2;
        private NumericUpDown nbPlacesNumericUpDown;
        private Label nbPlaceMaxLabel;
        private Label label5;
    }
}