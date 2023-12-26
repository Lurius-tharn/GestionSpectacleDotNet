namespace GestionSpectacle.Vue
{
    partial class ConnexionForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelAcceuil = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.stayConnectedCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAcceuilUser = new System.Windows.Forms.TextBox();
            this.textBoxAcceuilPassword = new System.Windows.Forms.TextBox();
            this.buttonConnexion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panelAcceuil.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAcceuil
            // 
            this.panelAcceuil.AutoSize = true;
            this.panelAcceuil.Controls.Add(this.label3);
            this.panelAcceuil.Controls.Add(this.stayConnectedCheckBox);
            this.panelAcceuil.Controls.Add(this.label1);
            this.panelAcceuil.Controls.Add(this.textBoxAcceuilUser);
            this.panelAcceuil.Controls.Add(this.textBoxAcceuilPassword);
            this.panelAcceuil.Controls.Add(this.buttonConnexion);
            this.panelAcceuil.Controls.Add(this.label2);
            this.panelAcceuil.Location = new System.Drawing.Point(-4, 6);
            this.panelAcceuil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelAcceuil.Name = "panelAcceuil";
            this.panelAcceuil.Size = new System.Drawing.Size(1453, 1216);
            this.panelAcceuil.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(388, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(542, 54);
            this.label3.TabIndex = 28;
            this.label3.Text = "Vous avez déja un compte ?";
            // 
            // stayConnectedCheckBox
            // 
            this.stayConnectedCheckBox.AutoSize = true;
            this.stayConnectedCheckBox.Location = new System.Drawing.Point(538, 392);
            this.stayConnectedCheckBox.Name = "stayConnectedCheckBox";
            this.stayConnectedCheckBox.Size = new System.Drawing.Size(168, 29);
            this.stayConnectedCheckBox.TabIndex = 27;
            this.stayConnectedCheckBox.Text = "Rester connecter";
            this.stayConnectedCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(388, 174);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 41);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nom d\'utilisateur";
            // 
            // textBoxAcceuilUser
            // 
            this.textBoxAcceuilUser.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxAcceuilUser.Location = new System.Drawing.Point(686, 168);
            this.textBoxAcceuilUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxAcceuilUser.Name = "textBoxAcceuilUser";
            this.textBoxAcceuilUser.Size = new System.Drawing.Size(256, 47);
            this.textBoxAcceuilUser.TabIndex = 25;
            // 
            // textBoxAcceuilPassword
            // 
            this.textBoxAcceuilPassword.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAcceuilPassword.Location = new System.Drawing.Point(686, 253);
            this.textBoxAcceuilPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxAcceuilPassword.Name = "textBoxAcceuilPassword";
            this.textBoxAcceuilPassword.Size = new System.Drawing.Size(256, 47);
            this.textBoxAcceuilPassword.TabIndex = 26;
            // 
            // buttonConnexion
            // 
            this.buttonConnexion.Location = new System.Drawing.Point(390, 387);
            this.buttonConnexion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonConnexion.Name = "buttonConnexion";
            this.buttonConnexion.Size = new System.Drawing.Size(141, 36);
            this.buttonConnexion.TabIndex = 22;
            this.buttonConnexion.Text = "Connexion";
            this.buttonConnexion.UseVisualStyleBackColor = true;
            this.buttonConnexion.Click += new System.EventHandler(this.buttonConnexion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(388, 253);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 41);
            this.label2.TabIndex = 24;
            this.label2.Text = "Mot de passe";
            // 
            // ConnexionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 978);
            this.Controls.Add(this.panelAcceuil);
            this.Name = "ConnexionForm";
            this.Text = "Form1";
            this.panelAcceuil.ResumeLayout(false);
            this.panelAcceuil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelAcceuil;
        private Label label3;
        private CheckBox stayConnectedCheckBox;
        private Label label1;
        private TextBox textBoxAcceuilUser;
        private TextBox textBoxAcceuilPassword;
        private Button buttonConnexion;
        private Label label2;
    }
}