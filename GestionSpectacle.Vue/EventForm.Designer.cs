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
            this.placeInfoLabel = new System.Windows.Forms.Label();
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
            this.labelClass = new System.Windows.Forms.Label();
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
            this.panel1.Controls.Add(this.placeInfoLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.nbPlacesNumericUpDown);
            this.panel1.Controls.Add(this.buttonPanier);
            this.panel1.Controls.Add(this.panelMain);
            this.panel1.Location = new System.Drawing.Point(245, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 532);
            this.panel1.TabIndex = 2;
            // 
            // placeInfoLabel
            // 
            this.placeInfoLabel.AutoSize = true;
            this.placeInfoLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.placeInfoLabel.Location = new System.Drawing.Point(156, 446);
            this.placeInfoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.placeInfoLabel.Name = "placeInfoLabel";
            this.placeInfoLabel.Size = new System.Drawing.Size(339, 20);
            this.placeInfoLabel.TabIndex = 7;
            this.placeInfoLabel.Text = "( Il n\'y as actuellement pas de places disponibles) ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(16, 446);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Choix des places";
            // 
            // nbPlacesNumericUpDown
            // 
            this.nbPlacesNumericUpDown.Location = new System.Drawing.Point(23, 476);
            this.nbPlacesNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.nbPlacesNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbPlacesNumericUpDown.Name = "nbPlacesNumericUpDown";
            this.nbPlacesNumericUpDown.Size = new System.Drawing.Size(126, 23);
            this.nbPlacesNumericUpDown.TabIndex = 5;
            this.nbPlacesNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonPanier
            // 
            this.buttonPanier.Location = new System.Drawing.Point(617, 461);
            this.buttonPanier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPanier.Name = "buttonPanier";
            this.buttonPanier.Size = new System.Drawing.Size(100, 47);
            this.buttonPanier.TabIndex = 4;
            this.buttonPanier.Text = "Ajouter au panier";
            this.buttonPanier.UseVisualStyleBackColor = true;
            this.buttonPanier.Click += new System.EventHandler(this.buttonPanier_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.descriptionTextLabel);
            this.panelMain.Location = new System.Drawing.Point(3, 3);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(740, 431);
            this.panelMain.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Description";
            // 
            // descriptionTextLabel
            // 
            this.descriptionTextLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descriptionTextLabel.Location = new System.Drawing.Point(3, 85);
            this.descriptionTextLabel.Name = "descriptionTextLabel";
            this.descriptionTextLabel.Size = new System.Drawing.Size(733, 180);
            this.descriptionTextLabel.TabIndex = 0;
            this.descriptionTextLabel.Text = resources.GetString("descriptionTextLabel.Text");
            // 
            // eventNameLabel
            // 
            this.eventNameLabel.AutoSize = true;
            this.eventNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.eventNameLabel.Location = new System.Drawing.Point(3, 33);
            this.eventNameLabel.Name = "eventNameLabel";
            this.eventNameLabel.Size = new System.Drawing.Size(176, 37);
            this.eventNameLabel.TabIndex = 7;
            this.eventNameLabel.Text = "Evenement";
            // 
            // panelAcceuil
            // 
            this.panelAcceuil.Controls.Add(this.button1);
            this.panelAcceuil.Controls.Add(this.nbPlaceMaxLabel);
            this.panelAcceuil.Controls.Add(this.classificationLabel);
            this.panelAcceuil.Controls.Add(this.label5);
            this.panelAcceuil.Controls.Add(this.labelClass);
            this.panelAcceuil.Controls.Add(this.promotorLabel);
            this.panelAcceuil.Controls.Add(this.label7);
            this.panelAcceuil.Controls.Add(this.priceLabel);
            this.panelAcceuil.Controls.Add(this.label4);
            this.panelAcceuil.Controls.Add(this.spectaclePictureBox);
            this.panelAcceuil.Controls.Add(this.startDateLabel);
            this.panelAcceuil.Controls.Add(this.eventNameLabel);
            this.panelAcceuil.Controls.Add(this.label1);
            this.panelAcceuil.Controls.Add(this.panel1);
            this.panelAcceuil.Location = new System.Drawing.Point(11, 0);
            this.panelAcceuil.Name = "panelAcceuil";
            this.panelAcceuil.Size = new System.Drawing.Size(990, 549);
            this.panelAcceuil.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 520);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 20);
            this.button1.TabIndex = 18;
            this.button1.Text = "Fermer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nbPlaceMaxLabel
            // 
            this.nbPlaceMaxLabel.AutoSize = true;
            this.nbPlaceMaxLabel.Location = new System.Drawing.Point(3, 454);
            this.nbPlaceMaxLabel.Name = "nbPlaceMaxLabel";
            this.nbPlaceMaxLabel.Size = new System.Drawing.Size(19, 15);
            this.nbPlaceMaxLabel.TabIndex = 15;
            this.nbPlaceMaxLabel.Text = "50";
            // 
            // classificationLabel
            // 
            this.classificationLabel.AutoSize = true;
            this.classificationLabel.Location = new System.Drawing.Point(3, 407);
            this.classificationLabel.Name = "classificationLabel";
            this.classificationLabel.Size = new System.Drawing.Size(53, 15);
            this.classificationLabel.TabIndex = 15;
            this.classificationLabel.Text = "Musique";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(-2, 428);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "nombre de places";
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelClass.Location = new System.Drawing.Point(-2, 382);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(213, 25);
            this.labelClass.TabIndex = 14;
            this.labelClass.Text = "Classification principale";
            // 
            // promotorLabel
            // 
            this.promotorLabel.AutoSize = true;
            this.promotorLabel.Location = new System.Drawing.Point(3, 357);
            this.promotorLabel.Name = "promotorLabel";
            this.promotorLabel.Size = new System.Drawing.Size(103, 15);
            this.promotorLabel.TabIndex = 13;
            this.promotorLabel.Text = "SAS SALLE PLEYEL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(-2, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Promoteur principal";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(3, 305);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(34, 15);
            this.priceLabel.TabIndex = 11;
            this.priceLabel.Text = "39.40";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(-2, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Prix";
            // 
            // spectaclePictureBox
            // 
            this.spectaclePictureBox.Location = new System.Drawing.Point(11, 140);
            this.spectaclePictureBox.Name = "spectaclePictureBox";
            this.spectaclePictureBox.Size = new System.Drawing.Size(208, 137);
            this.spectaclePictureBox.TabIndex = 9;
            this.spectaclePictureBox.TabStop = false;
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.startDateLabel.Location = new System.Drawing.Point(43, 86);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(73, 15);
            this.startDateLabel.TabIndex = 8;
            this.startDateLabel.Text = "22/11/2000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Date";
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 548);
            this.Controls.Add(this.panelAcceuil);
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
        private Label labelClass;
        private Label promotorLabel;
        private Label label7;
        private Label priceLabel;
        private Label label4;
        private Button button1;
        private Label label2;
        private NumericUpDown nbPlacesNumericUpDown;
        private Label nbPlaceMaxLabel;
        private Label label5;
        private Label placeInfoLabel;
    }
}