namespace WindowsFormsApp1
{
    partial class formEvenem
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
            panelAcceuil = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dateTimePickerFirst = new DateTimePicker();
            dateTimePickerLast = new DateTimePicker();
            panel1 = new Panel();
            buttonPanier = new Button();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            evenNom = new DataGridViewTextBoxColumn();
            evenType = new DataGridViewTextBoxColumn();
            evenDate = new DataGridViewTextBoxColumn();
            evenLieu = new DataGridViewTextBoxColumn();
            evenPlaces = new DataGridViewTextBoxColumn();
            evenPrix = new DataGridViewTextBoxColumn();
            buttonNext = new Button();
            buttonPrevious = new Button();
            monthCalendar = new MonthCalendar();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panelAcceuil.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelAcceuil
            // 
            panelAcceuil.Controls.Add(label3);
            panelAcceuil.Controls.Add(label2);
            panelAcceuil.Controls.Add(label1);
            panelAcceuil.Controls.Add(dateTimePickerFirst);
            panelAcceuil.Controls.Add(dateTimePickerLast);
            panelAcceuil.Controls.Add(panel1);
            panelAcceuil.Controls.Add(monthCalendar);
            panelAcceuil.Location = new Point(12, 39);
            panelAcceuil.Margin = new Padding(3, 4, 3, 4);
            panelAcceuil.Name = "panelAcceuil";
            panelAcceuil.Size = new Size(1132, 732);
            panelAcceuil.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(13, 21);
            label3.Name = "label3";
            label3.Size = new Size(240, 46);
            label3.TabIndex = 7;
            label3.Text = "Evenements";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 159);
            label2.Name = "label2";
            label2.Size = new Size(27, 20);
            label2.TabIndex = 6;
            label2.Text = "Au";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 92);
            label1.Name = "label1";
            label1.Size = new Size(28, 20);
            label1.TabIndex = 5;
            label1.Text = "Du";
            // 
            // dateTimePickerFirst
            // 
            dateTimePickerFirst.Location = new Point(9, 116);
            dateTimePickerFirst.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerFirst.Name = "dateTimePickerFirst";
            dateTimePickerFirst.Size = new Size(262, 27);
            dateTimePickerFirst.TabIndex = 4;
            // 
            // dateTimePickerLast
            // 
            dateTimePickerLast.Location = new Point(9, 186);
            dateTimePickerLast.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerLast.Name = "dateTimePickerLast";
            dateTimePickerLast.Size = new Size(262, 27);
            dateTimePickerLast.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonPanier);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(buttonNext);
            panel1.Controls.Add(buttonPrevious);
            panel1.Location = new Point(280, 21);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(849, 710);
            panel1.TabIndex = 2;
            // 
            // buttonPanier
            // 
            buttonPanier.Location = new Point(373, 632);
            buttonPanier.Name = "buttonPanier";
            buttonPanier.Size = new Size(94, 29);
            buttonPanier.TabIndex = 4;
            buttonPanier.Text = "Panier";
            buttonPanier.UseVisualStyleBackColor = true;
            buttonPanier.Click += buttonPanier_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(3, 4);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(846, 575);
            panel2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { evenNom, evenType, evenDate, evenLieu, evenPlaces, evenPrix });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(846, 575);
            dataGridView1.TabIndex = 4;
            // 
            // evenNom
            // 
            evenNom.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            evenNom.HeaderText = "Nom";
            evenNom.MinimumWidth = 6;
            evenNom.Name = "evenNom";
            // 
            // evenType
            // 
            evenType.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            evenType.HeaderText = "Type";
            evenType.MinimumWidth = 6;
            evenType.Name = "evenType";
            // 
            // evenDate
            // 
            evenDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            evenDate.HeaderText = "Date";
            evenDate.MinimumWidth = 6;
            evenDate.Name = "evenDate";
            // 
            // evenLieu
            // 
            evenLieu.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            evenLieu.HeaderText = "Lieu";
            evenLieu.MinimumWidth = 6;
            evenLieu.Name = "evenLieu";
            // 
            // evenPlaces
            // 
            evenPlaces.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            evenPlaces.HeaderText = "Places";
            evenPlaces.MinimumWidth = 6;
            evenPlaces.Name = "evenPlaces";
            // 
            // evenPrix
            // 
            evenPrix.HeaderText = "Prix";
            evenPrix.MinimumWidth = 6;
            evenPrix.Name = "evenPrix";
            evenPrix.Width = 125;
            // 
            // buttonNext
            // 
            buttonNext.Location = new Point(718, 622);
            buttonNext.Margin = new Padding(3, 4, 3, 4);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(54, 49);
            buttonNext.TabIndex = 1;
            buttonNext.Text = ">";
            buttonNext.UseVisualStyleBackColor = true;
            // 
            // buttonPrevious
            // 
            buttonPrevious.Location = new Point(55, 622);
            buttonPrevious.Margin = new Padding(3, 4, 3, 4);
            buttonPrevious.Name = "buttonPrevious";
            buttonPrevious.Size = new Size(54, 49);
            buttonPrevious.TabIndex = 0;
            buttonPrevious.Text = "<";
            buttonPrevious.UseVisualStyleBackColor = true;
            // 
            // monthCalendar
            // 
            monthCalendar.Location = new Point(9, 229);
            monthCalendar.Margin = new Padding(9, 11, 9, 11);
            monthCalendar.Name = "monthCalendar";
            monthCalendar.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // formEvenem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1156, 782);
            Controls.Add(panelAcceuil);
            Margin = new Padding(3, 4, 3, 4);
            Name = "formEvenem";
            Text = "formEvenem";
            panelAcceuil.ResumeLayout(false);
            panelAcceuil.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelAcceuil;
        private ContextMenuStrip contextMenuStrip1;
        private Panel panel1;
        private Button buttonPrevious;
        private MonthCalendar monthCalendar;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePickerFirst;
        private DateTimePicker dateTimePickerLast;
        private Button buttonNext;
        private Label label3;
        private Panel panel2;
        private Button buttonPanier;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn evenNom;
        private DataGridViewTextBoxColumn evenType;
        private DataGridViewTextBoxColumn evenDate;
        private DataGridViewTextBoxColumn evenLieu;
        private DataGridViewTextBoxColumn evenPlaces;
        private DataGridViewTextBoxColumn evenPrix;
    }
}