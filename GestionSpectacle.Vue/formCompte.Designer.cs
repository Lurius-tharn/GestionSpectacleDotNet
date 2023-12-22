namespace WindowsFormsApp1
{
    partial class formCompte
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panelAcceuil = new Panel();
            dataGridViewHistorique = new DataGridView();
            historiqueTitre = new DataGridViewTextBoxColumn();
            historiqueDate = new DataGridViewTextBoxColumn();
            historiqueType = new DataGridViewTextBoxColumn();
            historiquePlaces = new DataGridViewTextBoxColumn();
            historiqueLieu = new DataGridViewTextBoxColumn();
            label1 = new Label();
            panelAcceuil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistorique).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // panelAcceuil
            // 
            panelAcceuil.Controls.Add(dataGridViewHistorique);
            panelAcceuil.Controls.Add(label1);
            panelAcceuil.Location = new Point(13, 39);
            panelAcceuil.Margin = new Padding(3, 4, 3, 4);
            panelAcceuil.Name = "panelAcceuil";
            panelAcceuil.Size = new Size(774, 522);
            panelAcceuil.TabIndex = 19;
            // 
            // dataGridViewHistorique
            // 
            dataGridViewHistorique.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHistorique.Columns.AddRange(new DataGridViewColumn[] { historiqueTitre, historiqueDate, historiqueType, historiquePlaces, historiqueLieu });
            dataGridViewHistorique.Location = new Point(3, 158);
            dataGridViewHistorique.Margin = new Padding(3, 4, 3, 4);
            dataGridViewHistorique.Name = "dataGridViewHistorique";
            dataGridViewHistorique.RowHeadersWidth = 51;
            dataGridViewHistorique.RowTemplate.Height = 24;
            dataGridViewHistorique.Size = new Size(771, 352);
            dataGridViewHistorique.TabIndex = 2;
            // 
            // historiqueTitre
            // 
            historiqueTitre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            historiqueTitre.HeaderText = "Titre";
            historiqueTitre.MinimumWidth = 6;
            historiqueTitre.Name = "historiqueTitre";
            historiqueTitre.ReadOnly = true;
            // 
            // historiqueDate
            // 
            historiqueDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            historiqueDate.HeaderText = "Date";
            historiqueDate.MinimumWidth = 6;
            historiqueDate.Name = "historiqueDate";
            historiqueDate.ReadOnly = true;
            // 
            // historiqueType
            // 
            historiqueType.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            historiqueType.HeaderText = "Type";
            historiqueType.MinimumWidth = 6;
            historiqueType.Name = "historiqueType";
            historiqueType.ReadOnly = true;
            // 
            // historiquePlaces
            // 
            historiquePlaces.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            historiquePlaces.HeaderText = "Places";
            historiquePlaces.MinimumWidth = 6;
            historiquePlaces.Name = "historiquePlaces";
            historiquePlaces.ReadOnly = true;
            // 
            // historiqueLieu
            // 
            historiqueLieu.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            historiqueLieu.HeaderText = "Lieu";
            historiqueLieu.MinimumWidth = 6;
            historiqueLieu.Name = "historiqueLieu";
            historiqueLieu.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(297, 52);
            label1.Name = "label1";
            label1.Size = new Size(200, 46);
            label1.TabIndex = 1;
            label1.Text = "Historique";
            // 
            // formCompte
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(panelAcceuil);
            Margin = new Padding(3, 4, 3, 4);
            Name = "formCompte";
            Text = "formCompte";
            panelAcceuil.ResumeLayout(false);
            panelAcceuil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistorique).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private Panel panelAcceuil;
        private DataGridView dataGridViewHistorique;
        private Label label1;
        private DataGridViewTextBoxColumn historiqueTitre;
        private DataGridViewTextBoxColumn historiqueDate;
        private DataGridViewTextBoxColumn historiqueType;
        private DataGridViewTextBoxColumn historiquePlaces;
        private DataGridViewTextBoxColumn historiqueLieu;
    }
}