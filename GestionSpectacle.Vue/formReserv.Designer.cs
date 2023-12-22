namespace WindowsFormsApp1
{
    partial class formReserv
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
            contextMenuStrip2 = new ContextMenuStrip(components);
            panelAcceuil = new Panel();
            dataGridView1 = new DataGridView();
            reservationTitre = new DataGridViewTextBoxColumn();
            reservationDate = new DataGridViewTextBoxColumn();
            reservationType = new DataGridViewTextBoxColumn();
            reservationPlaces = new DataGridViewTextBoxColumn();
            reservationLieu = new DataGridViewTextBoxColumn();
            label1 = new Label();
            panelAcceuil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(20, 20);
            contextMenuStrip2.Name = "contextMenuStrip1";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // panelAcceuil
            // 
            panelAcceuil.Controls.Add(dataGridView1);
            panelAcceuil.Controls.Add(label1);
            panelAcceuil.Location = new Point(12, 46);
            panelAcceuil.Margin = new Padding(3, 4, 3, 4);
            panelAcceuil.Name = "panelAcceuil";
            panelAcceuil.Size = new Size(774, 501);
            panelAcceuil.TabIndex = 18;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { reservationTitre, reservationDate, reservationType, reservationPlaces, reservationLieu });
            dataGridView1.Location = new Point(3, 158);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(771, 352);
            dataGridView1.TabIndex = 2;
            // 
            // reservationTitre
            // 
            reservationTitre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            reservationTitre.HeaderText = "Titre";
            reservationTitre.MinimumWidth = 6;
            reservationTitre.Name = "reservationTitre";
            reservationTitre.ReadOnly = true;
            // 
            // reservationDate
            // 
            reservationDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            reservationDate.HeaderText = "Date";
            reservationDate.MinimumWidth = 6;
            reservationDate.Name = "reservationDate";
            reservationDate.ReadOnly = true;
            // 
            // reservationType
            // 
            reservationType.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            reservationType.HeaderText = "Type";
            reservationType.MinimumWidth = 6;
            reservationType.Name = "reservationType";
            reservationType.ReadOnly = true;
            // 
            // reservationPlaces
            // 
            reservationPlaces.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            reservationPlaces.HeaderText = "Places";
            reservationPlaces.MinimumWidth = 6;
            reservationPlaces.Name = "reservationPlaces";
            reservationPlaces.ReadOnly = true;
            // 
            // reservationLieu
            // 
            reservationLieu.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            reservationLieu.HeaderText = "Lieu";
            reservationLieu.MinimumWidth = 6;
            reservationLieu.Name = "reservationLieu";
            reservationLieu.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(275, 58);
            label1.Name = "label1";
            label1.Size = new Size(232, 46);
            label1.TabIndex = 1;
            label1.Text = "Reservation";
            label1.Click += label1_Click;
            // 
            // formReserv
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(panelAcceuil);
            Margin = new Padding(3, 4, 3, 4);
            Name = "formReserv";
            Text = "formReserv";
            panelAcceuil.ResumeLayout(false);
            panelAcceuil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private Panel panelAcceuil;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn reservationTitre;
        private DataGridViewTextBoxColumn reservationDate;
        private DataGridViewTextBoxColumn reservationType;
        private DataGridViewTextBoxColumn reservationPlaces;
        private DataGridViewTextBoxColumn reservationLieu;
    }
}