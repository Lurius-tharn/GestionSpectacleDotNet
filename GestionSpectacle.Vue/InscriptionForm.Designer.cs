namespace GestionSpectacle.Vue
{
    partial class InscriptionForm
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
            this.errorProviderApp = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelAcceuil = new System.Windows.Forms.Panel();
            this.stayConnectedCheckBox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.passwordComfirmInput = new System.Windows.Forms.TextBox();
            this.passwordnput = new System.Windows.Forms.TextBox();
            this.userNameInput = new System.Windows.Forms.TextBox();
            this.buttonInscription = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApp)).BeginInit();
            this.panelAcceuil.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProviderApp
            // 
            this.errorProviderApp.ContainerControl = this;
            // 
            // panelAcceuil
            // 
            this.panelAcceuil.AutoSize = true;
            this.panelAcceuil.Controls.Add(this.stayConnectedCheckBox);
            this.panelAcceuil.Controls.Add(this.label6);
            this.panelAcceuil.Controls.Add(this.NameInput);
            this.panelAcceuil.Controls.Add(this.passwordComfirmInput);
            this.panelAcceuil.Controls.Add(this.passwordnput);
            this.panelAcceuil.Controls.Add(this.userNameInput);
            this.panelAcceuil.Controls.Add(this.buttonInscription);
            this.panelAcceuil.Controls.Add(this.label5);
            this.panelAcceuil.Controls.Add(this.label3);
            this.panelAcceuil.Controls.Add(this.label2);
            this.panelAcceuil.Controls.Add(this.label1);
            this.panelAcceuil.Location = new System.Drawing.Point(3, 14);
            this.panelAcceuil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelAcceuil.Name = "panelAcceuil";
            this.panelAcceuil.Size = new System.Drawing.Size(1453, 1065);
            this.panelAcceuil.TabIndex = 20;
            // 
            // stayConnectedCheckBox
            // 
            this.stayConnectedCheckBox.AutoSize = true;
            this.stayConnectedCheckBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stayConnectedCheckBox.Location = new System.Drawing.Point(540, 566);
            this.stayConnectedCheckBox.Name = "stayConnectedCheckBox";
            this.stayConnectedCheckBox.Size = new System.Drawing.Size(251, 42);
            this.stayConnectedCheckBox.TabIndex = 23;
            this.stayConnectedCheckBox.Text = "Rester connecter";
            this.stayConnectedCheckBox.UseVisualStyleBackColor = true;
            this.stayConnectedCheckBox.CheckedChanged += new System.EventHandler(this.stayConnectedCheckBox_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(583, 63);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(224, 54);
            this.label6.TabIndex = 22;
            this.label6.Text = "Inscription";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // NameInput
            // 
            this.NameInput.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameInput.Location = new System.Drawing.Point(784, 389);
            this.NameInput.Margin = new System.Windows.Forms.Padding(4);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(298, 45);
            this.NameInput.TabIndex = 21;
            this.NameInput.TextChanged += new System.EventHandler(this.NameInput_TextChanged);
            // 
            // passwordComfirmInput
            // 
            this.passwordComfirmInput.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordComfirmInput.Location = new System.Drawing.Point(784, 329);
            this.passwordComfirmInput.Margin = new System.Windows.Forms.Padding(4);
            this.passwordComfirmInput.Name = "passwordComfirmInput";
            this.passwordComfirmInput.Size = new System.Drawing.Size(298, 45);
            this.passwordComfirmInput.TabIndex = 20;
            this.passwordComfirmInput.TextChanged += new System.EventHandler(this.passwordComfirmInput_TextChanged);
            // 
            // passwordnput
            // 
            this.passwordnput.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordnput.Location = new System.Drawing.Point(784, 258);
            this.passwordnput.Margin = new System.Windows.Forms.Padding(4);
            this.passwordnput.Name = "passwordnput";
            this.passwordnput.Size = new System.Drawing.Size(298, 45);
            this.passwordnput.TabIndex = 19;
            this.passwordnput.TextChanged += new System.EventHandler(this.passwordnput_TextChanged);
            // 
            // userNameInput
            // 
            this.userNameInput.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userNameInput.Location = new System.Drawing.Point(784, 187);
            this.userNameInput.Margin = new System.Windows.Forms.Padding(4);
            this.userNameInput.Name = "userNameInput";
            this.userNameInput.Size = new System.Drawing.Size(298, 45);
            this.userNameInput.TabIndex = 18;
            this.userNameInput.TextChanged += new System.EventHandler(this.userNameInput_TextChanged);
            // 
            // buttonInscription
            // 
            this.buttonInscription.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonInscription.Location = new System.Drawing.Point(364, 558);
            this.buttonInscription.Margin = new System.Windows.Forms.Padding(4);
            this.buttonInscription.Name = "buttonInscription";
            this.buttonInscription.Size = new System.Drawing.Size(169, 56);
            this.buttonInscription.TabIndex = 17;
            this.buttonInscription.Text = "S\'inscrire";
            this.buttonInscription.UseVisualStyleBackColor = true;
            this.buttonInscription.Click += new System.EventHandler(this.buttonInscription_Click_2);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(402, 378);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 38);
            this.label5.TabIndex = 16;
            this.label5.Text = "Nom";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(402, 318);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(331, 38);
            this.label3.TabIndex = 15;
            this.label3.Text = "Confirmer mot de passe";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(402, 247);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 38);
            this.label2.TabIndex = 14;
            this.label2.Text = "Mot de passe";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(402, 176);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 38);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nom d\'utilisateur";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // InscriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 978);
            this.Controls.Add(this.panelAcceuil);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InscriptionForm";
            this.Text = "formInscription";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApp)).EndInit();
            this.panelAcceuil.ResumeLayout(false);
            this.panelAcceuil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ErrorProvider errorProviderApp;
        private Panel panelAcceuil;
        private CheckBox stayConnectedCheckBox;
        private Label label6;
        private TextBox NameInput;
        private TextBox passwordComfirmInput;
        private TextBox passwordnput;
        private TextBox userNameInput;
        private Button buttonInscription;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}