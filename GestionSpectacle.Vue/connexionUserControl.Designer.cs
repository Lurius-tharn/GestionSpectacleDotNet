namespace GestionSpectacle.Vue
{
    partial class connexionUserControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            panelAcceuil = new Panel();
            button2 = new Button();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            panelAcceuil.SuspendLayout();
            SuspendLayout();
            // 
            // panelAcceuil
            // 
            panelAcceuil.Controls.Add(button2);
            panelAcceuil.Controls.Add(label3);
            panelAcceuil.Controls.Add(textBox2);
            panelAcceuil.Controls.Add(textBox1);
            panelAcceuil.Controls.Add(label2);
            panelAcceuil.Controls.Add(label1);
            panelAcceuil.Controls.Add(button1);
            panelAcceuil.Location = new Point(9, 42);
            panelAcceuil.Margin = new Padding(3, 4, 3, 4);
            panelAcceuil.Name = "panelAcceuil";
            panelAcceuil.Size = new Size(802, 528);
            panelAcceuil.TabIndex = 18;
            // 
            // button2
            // 
            button2.Location = new Point(424, 435);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(99, 29);
            button2.TabIndex = 6;
            button2.Text = "Deconnexion";
            button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(340, 90);
            label3.Name = "label3";
            label3.Size = new Size(151, 46);
            label3.TabIndex = 5;
            label3.Text = "Acceuil";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(381, 266);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 27);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(381, 212);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 27);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(273, 270);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(273, 220);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(309, 435);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(85, 29);
            button1.TabIndex = 0;
            button1.Text = "Connexion";
            button1.UseVisualStyleBackColor = true;
            // 
            // connexionUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelAcceuil);
            Name = "connexionUserControl";
            Size = new Size(820, 613);
            panelAcceuil.ResumeLayout(false);
            panelAcceuil.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelAcceuil;
        private Button button2;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Button button1;
    }
}
