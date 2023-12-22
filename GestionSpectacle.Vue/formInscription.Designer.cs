namespace GestionSpectacle.Vue
{
    partial class formInscription
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonInscription = new System.Windows.Forms.Button();
            this.userNameInput = new System.Windows.Forms.TextBox();
            this.passwordnput = new System.Windows.Forms.TextBox();
            this.passwordComfirmInput = new System.Windows.Forms.TextBox();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProviderApp = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 184);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom d\'utilisateur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 255);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mot de passe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 326);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirmer mot de passe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 386);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nom";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // buttonInscription
            // 
            this.buttonInscription.Location = new System.Drawing.Point(229, 582);
            this.buttonInscription.Margin = new System.Windows.Forms.Padding(4);
            this.buttonInscription.Name = "buttonInscription";
            this.buttonInscription.Size = new System.Drawing.Size(118, 36);
            this.buttonInscription.TabIndex = 5;
            this.buttonInscription.Text = "S\'inscrire";
            this.buttonInscription.UseVisualStyleBackColor = true;
            this.buttonInscription.Click += new System.EventHandler(this.buttonInscription_Click_1);
            // 
            // userNameInput
            // 
            this.userNameInput.Location = new System.Drawing.Point(345, 184);
            this.userNameInput.Margin = new System.Windows.Forms.Padding(4);
            this.userNameInput.Name = "userNameInput";
            this.userNameInput.Size = new System.Drawing.Size(155, 31);
            this.userNameInput.TabIndex = 6;
            this.userNameInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.userNameInput.Validating += new System.ComponentModel.CancelEventHandler(this.user_Name_Validating);
            // 
            // passwordnput
            // 
            this.passwordnput.Location = new System.Drawing.Point(345, 255);
            this.passwordnput.Margin = new System.Windows.Forms.Padding(4);
            this.passwordnput.Name = "passwordnput";
            this.passwordnput.Size = new System.Drawing.Size(155, 31);
            this.passwordnput.TabIndex = 7;
            // 
            // passwordComfirmInput
            // 
            this.passwordComfirmInput.Location = new System.Drawing.Point(345, 326);
            this.passwordComfirmInput.Margin = new System.Windows.Forms.Padding(4);
            this.passwordComfirmInput.Name = "passwordComfirmInput";
            this.passwordComfirmInput.Size = new System.Drawing.Size(155, 31);
            this.passwordComfirmInput.TabIndex = 8;
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(345, 386);
            this.NameInput.Margin = new System.Windows.Forms.Padding(4);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(155, 31);
            this.NameInput.TabIndex = 10;
            this.NameInput.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(229, 71);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Inscription";
            // 
            // errorProviderApp
            // 
            this.errorProviderApp.ContainerControl = this;
            // 
            // formInscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 671);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NameInput);
            this.Controls.Add(this.passwordComfirmInput);
            this.Controls.Add(this.passwordnput);
            this.Controls.Add(this.userNameInput);
            this.Controls.Add(this.buttonInscription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formInscription";
            this.Text = "formInscription";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Button buttonInscription;
        private TextBox userNameInput;
        private TextBox passwordnput;
        private TextBox passwordComfirmInput;
        private TextBox NameInput;
        private Label label6;
        private ErrorProvider errorProviderApp;
    }
}