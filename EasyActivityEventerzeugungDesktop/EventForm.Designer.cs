namespace EasyActivityEventerzeugungDesktop
{
    partial class EventForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventForm));
            meineAktivitätenDataGridView = new DataGridView();
            titelDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            beschreibungDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ortDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            staatDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            straßeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hausnummerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            postleitzahlDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            startzeitpunktDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            endzeitpunktDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            eventDatenBindingSource = new BindingSource(components);
            neuesEventErstellenButton = new Button();
            gewähltesEventBearbeitenButton = new Button();
            ((System.ComponentModel.ISupportInitialize)meineAktivitätenDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eventDatenBindingSource).BeginInit();
            SuspendLayout();
            // 
            // meineAktivitätenDataGridView
            // 
            meineAktivitätenDataGridView.AllowUserToAddRows = false;
            meineAktivitätenDataGridView.AllowUserToDeleteRows = false;
            meineAktivitätenDataGridView.AllowUserToResizeRows = false;
            meineAktivitätenDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            meineAktivitätenDataGridView.AutoGenerateColumns = false;
            meineAktivitätenDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            meineAktivitätenDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            meineAktivitätenDataGridView.Columns.AddRange(new DataGridViewColumn[] { titelDataGridViewTextBoxColumn, beschreibungDataGridViewTextBoxColumn, ortDataGridViewTextBoxColumn, staatDataGridViewTextBoxColumn, straßeDataGridViewTextBoxColumn, hausnummerDataGridViewTextBoxColumn, postleitzahlDataGridViewTextBoxColumn, startzeitpunktDataGridViewTextBoxColumn, endzeitpunktDataGridViewTextBoxColumn });
            meineAktivitätenDataGridView.DataSource = eventDatenBindingSource;
            meineAktivitätenDataGridView.Location = new Point(15, 71);
            meineAktivitätenDataGridView.MultiSelect = false;
            meineAktivitätenDataGridView.Name = "meineAktivitätenDataGridView";
            meineAktivitätenDataGridView.ReadOnly = true;
            meineAktivitätenDataGridView.RowHeadersWidth = 51;
            meineAktivitätenDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            meineAktivitätenDataGridView.Size = new Size(1176, 309);
            meineAktivitätenDataGridView.TabIndex = 0;
            // 
            // titelDataGridViewTextBoxColumn
            // 
            titelDataGridViewTextBoxColumn.DataPropertyName = "Titel";
            titelDataGridViewTextBoxColumn.HeaderText = "Titel";
            titelDataGridViewTextBoxColumn.MinimumWidth = 6;
            titelDataGridViewTextBoxColumn.Name = "titelDataGridViewTextBoxColumn";
            titelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // beschreibungDataGridViewTextBoxColumn
            // 
            beschreibungDataGridViewTextBoxColumn.DataPropertyName = "Beschreibung";
            beschreibungDataGridViewTextBoxColumn.HeaderText = "Beschreibung";
            beschreibungDataGridViewTextBoxColumn.MinimumWidth = 6;
            beschreibungDataGridViewTextBoxColumn.Name = "beschreibungDataGridViewTextBoxColumn";
            beschreibungDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ortDataGridViewTextBoxColumn
            // 
            ortDataGridViewTextBoxColumn.DataPropertyName = "Ort";
            ortDataGridViewTextBoxColumn.HeaderText = "Ort";
            ortDataGridViewTextBoxColumn.MinimumWidth = 6;
            ortDataGridViewTextBoxColumn.Name = "ortDataGridViewTextBoxColumn";
            ortDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // staatDataGridViewTextBoxColumn
            // 
            staatDataGridViewTextBoxColumn.DataPropertyName = "Staat";
            staatDataGridViewTextBoxColumn.HeaderText = "Staat";
            staatDataGridViewTextBoxColumn.MinimumWidth = 6;
            staatDataGridViewTextBoxColumn.Name = "staatDataGridViewTextBoxColumn";
            staatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // straßeDataGridViewTextBoxColumn
            // 
            straßeDataGridViewTextBoxColumn.DataPropertyName = "Straße";
            straßeDataGridViewTextBoxColumn.HeaderText = "Straße";
            straßeDataGridViewTextBoxColumn.MinimumWidth = 6;
            straßeDataGridViewTextBoxColumn.Name = "straßeDataGridViewTextBoxColumn";
            straßeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hausnummerDataGridViewTextBoxColumn
            // 
            hausnummerDataGridViewTextBoxColumn.DataPropertyName = "Hausnummer";
            hausnummerDataGridViewTextBoxColumn.HeaderText = "Hausnummer";
            hausnummerDataGridViewTextBoxColumn.MinimumWidth = 6;
            hausnummerDataGridViewTextBoxColumn.Name = "hausnummerDataGridViewTextBoxColumn";
            hausnummerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // postleitzahlDataGridViewTextBoxColumn
            // 
            postleitzahlDataGridViewTextBoxColumn.DataPropertyName = "Postleitzahl";
            postleitzahlDataGridViewTextBoxColumn.HeaderText = "Postleitzahl";
            postleitzahlDataGridViewTextBoxColumn.MinimumWidth = 6;
            postleitzahlDataGridViewTextBoxColumn.Name = "postleitzahlDataGridViewTextBoxColumn";
            postleitzahlDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startzeitpunktDataGridViewTextBoxColumn
            // 
            startzeitpunktDataGridViewTextBoxColumn.DataPropertyName = "Startzeitpunkt";
            startzeitpunktDataGridViewTextBoxColumn.HeaderText = "Startzeitpunkt";
            startzeitpunktDataGridViewTextBoxColumn.MinimumWidth = 6;
            startzeitpunktDataGridViewTextBoxColumn.Name = "startzeitpunktDataGridViewTextBoxColumn";
            startzeitpunktDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endzeitpunktDataGridViewTextBoxColumn
            // 
            endzeitpunktDataGridViewTextBoxColumn.DataPropertyName = "Endzeitpunkt";
            endzeitpunktDataGridViewTextBoxColumn.HeaderText = "Endzeitpunkt";
            endzeitpunktDataGridViewTextBoxColumn.MinimumWidth = 6;
            endzeitpunktDataGridViewTextBoxColumn.Name = "endzeitpunktDataGridViewTextBoxColumn";
            endzeitpunktDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eventDatenBindingSource
            // 
            eventDatenBindingSource.DataSource = typeof(EventDaten);
            // 
            // neuesEventErstellenButton
            // 
            neuesEventErstellenButton.Location = new Point(15, 15);
            neuesEventErstellenButton.Name = "neuesEventErstellenButton";
            neuesEventErstellenButton.Size = new Size(220, 29);
            neuesEventErstellenButton.TabIndex = 1;
            neuesEventErstellenButton.Text = "Neues Event erstellen";
            neuesEventErstellenButton.UseVisualStyleBackColor = true;
            neuesEventErstellenButton.Click += neuesEventErstellenButton_Click;
            // 
            // gewähltesEventBearbeitenButton
            // 
            gewähltesEventBearbeitenButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            gewähltesEventBearbeitenButton.Location = new Point(971, 15);
            gewähltesEventBearbeitenButton.Name = "gewähltesEventBearbeitenButton";
            gewähltesEventBearbeitenButton.Size = new Size(220, 29);
            gewähltesEventBearbeitenButton.TabIndex = 2;
            gewähltesEventBearbeitenButton.Text = "Gewähltes Event bearbeiten";
            gewähltesEventBearbeitenButton.UseVisualStyleBackColor = true;
            gewähltesEventBearbeitenButton.Click += gewähltesEventBearbeitenButton_Click;
            // 
            // EventForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1202, 392);
            Controls.Add(gewähltesEventBearbeitenButton);
            Controls.Add(neuesEventErstellenButton);
            Controls.Add(meineAktivitätenDataGridView);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EventForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Eigene Events";
            ((System.ComponentModel.ISupportInitialize)meineAktivitätenDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)eventDatenBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView meineAktivitätenDataGridView;
        private Button neuesEventErstellenButton;
        private Button gewähltesEventBearbeitenButton;
        private DataGridViewTextBoxColumn titelDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn beschreibungDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ortDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn staatDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn straßeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hausnummerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn postleitzahlDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn startzeitpunktDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn endzeitpunktDataGridViewTextBoxColumn;
        private BindingSource eventDatenBindingSource;
    }
}
