namespace GestionSpectacle.Vue
{
    partial class FormConnexion
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
            this.textBoxAcceuilUser = new System.Windows.Forms.TextBox();
            this.buttonDeconnexion = new System.Windows.Forms.Button();
            this.buttonConnexion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAcceuilPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxAcceuilUser
            // 
            this.textBoxAcceuilUser.Location = new System.Drawing.Point(409, 68);
            this.textBoxAcceuilUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxAcceuilUser.Name = "textBoxAcceuilUser";
            this.textBoxAcceuilUser.Size = new System.Drawing.Size(124, 31);
            this.textBoxAcceuilUser.TabIndex = 10;
            this.textBoxAcceuilUser.TextChanged += new System.EventHandler(this.textBoxAcceuilUser_TextChanged);
            // 
            // buttonDeconnexion
            // 
            this.buttonDeconnexion.Location = new System.Drawing.Point(463, 347);
            this.buttonDeconnexion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDeconnexion.Name = "buttonDeconnexion";
            this.buttonDeconnexion.Size = new System.Drawing.Size(140, 36);
            this.buttonDeconnexion.TabIndex = 12;
            this.buttonDeconnexion.Text = "Deconnexion";
            this.buttonDeconnexion.UseVisualStyleBackColor = true;
            this.buttonDeconnexion.Click += new System.EventHandler(this.buttonDeconnexion_Click);
            // 
            // buttonConnexion
            // 
            this.buttonConnexion.Location = new System.Drawing.Point(297, 347);
            this.buttonConnexion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonConnexion.Name = "buttonConnexion";
            this.buttonConnexion.Size = new System.Drawing.Size(141, 36);
            this.buttonConnexion.TabIndex = 7;
            this.buttonConnexion.Text = "Connexion";
            this.buttonConnexion.UseVisualStyleBackColor = true;
            this.buttonConnexion.Click += new System.EventHandler(this.buttonConnexion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mot de passe";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxAcceuilPassword
            // 
            this.textBoxAcceuilPassword.Location = new System.Drawing.Point(409, 135);
            this.textBoxAcceuilPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxAcceuilPassword.Name = "textBoxAcceuilPassword";
            this.textBoxAcceuilPassword.Size = new System.Drawing.Size(124, 31);
            this.textBoxAcceuilPassword.TabIndex = 11;
            this.textBoxAcceuilPassword.TextChanged += new System.EventHandler(this.textBoxAcceuilPassword_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nom d\'utilisateur";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxAcceuilUser);
            this.Controls.Add(this.buttonDeconnexion);
            this.Controls.Add(this.buttonConnexion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxAcceuilPassword);
            this.Controls.Add(this.label1);
            this.Name = "FormConnexion";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxAcceuilUser;
        private Button buttonDeconnexion;
        private Button buttonConnexion;
        private Label label2;
        private TextBox textBoxAcceuilPassword;
        private Label label1;
    }
}