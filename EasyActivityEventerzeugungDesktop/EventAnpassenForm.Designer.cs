namespace EasyActivityEventerzeugungDesktop
{
    partial class EventAnpassenForm
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
            eventSpeichernButton = new Button();
            abbrechenButton = new Button();
            allgemeineDatenLabel = new Label();
            eventnameLabel = new Label();
            eventbeschreibungLabel = new Label();
            eventstartLabel = new Label();
            standortLabel = new Label();
            eventstartDateTimePicker = new DateTimePicker();
            eventendeDateTimePicker = new DateTimePicker();
            eventnameTextBox = new TextBox();
            eventbeschreibungRichTextBox = new RichTextBox();
            staatLabel = new Label();
            ortLabel = new Label();
            staatTextBox = new TextBox();
            ortTextBox = new TextBox();
            postleitzahlLabel = new Label();
            postleitzahlTextBox = new TextBox();
            label1 = new Label();
            straßeTextBox = new TextBox();
            label2 = new Label();
            hausnummerTextBox = new TextBox();
            eventEndeCheckBox = new CheckBox();
            SuspendLayout();
            // 
            // eventSpeichernButton
            // 
            eventSpeichernButton.Location = new Point(140, 338);
            eventSpeichernButton.Name = "eventSpeichernButton";
            eventSpeichernButton.Size = new Size(150, 29);
            eventSpeichernButton.TabIndex = 0;
            eventSpeichernButton.Text = "Event Speichern";
            eventSpeichernButton.UseVisualStyleBackColor = true;
            eventSpeichernButton.Click += eventSpeichernButton_Click;
            // 
            // abbrechenButton
            // 
            abbrechenButton.Location = new Point(493, 338);
            abbrechenButton.Name = "abbrechenButton";
            abbrechenButton.Size = new Size(150, 29);
            abbrechenButton.TabIndex = 1;
            abbrechenButton.Text = "Abbrechen";
            abbrechenButton.UseVisualStyleBackColor = true;
            abbrechenButton.Click += abbrechenButton_Click;
            // 
            // allgemeineDatenLabel
            // 
            allgemeineDatenLabel.AutoSize = true;
            allgemeineDatenLabel.Font = new Font("Segoe UI", 12F);
            allgemeineDatenLabel.Location = new Point(15, 15);
            allgemeineDatenLabel.Name = "allgemeineDatenLabel";
            allgemeineDatenLabel.Size = new Size(171, 28);
            allgemeineDatenLabel.TabIndex = 2;
            allgemeineDatenLabel.Text = "Allgemeine Daten:";
            // 
            // eventnameLabel
            // 
            eventnameLabel.AutoSize = true;
            eventnameLabel.Location = new Point(15, 60);
            eventnameLabel.Name = "eventnameLabel";
            eventnameLabel.Size = new Size(85, 20);
            eventnameLabel.TabIndex = 3;
            eventnameLabel.Text = "Eventname:";
            // 
            // eventbeschreibungLabel
            // 
            eventbeschreibungLabel.AutoSize = true;
            eventbeschreibungLabel.Location = new Point(15, 100);
            eventbeschreibungLabel.Name = "eventbeschreibungLabel";
            eventbeschreibungLabel.Size = new Size(137, 20);
            eventbeschreibungLabel.TabIndex = 4;
            eventbeschreibungLabel.Text = "Eventbeschreibung:";
            // 
            // eventstartLabel
            // 
            eventstartLabel.AutoSize = true;
            eventstartLabel.Location = new Point(15, 229);
            eventstartLabel.Name = "eventstartLabel";
            eventstartLabel.Size = new Size(77, 20);
            eventstartLabel.TabIndex = 5;
            eventstartLabel.Text = "Eventstart:";
            // 
            // standortLabel
            // 
            standortLabel.AutoSize = true;
            standortLabel.Font = new Font("Segoe UI", 12F);
            standortLabel.Location = new Point(435, 15);
            standortLabel.Name = "standortLabel";
            standortLabel.Size = new Size(92, 28);
            standortLabel.TabIndex = 7;
            standortLabel.Text = "Standort:";
            // 
            // eventstartDateTimePicker
            // 
            eventstartDateTimePicker.CustomFormat = "dd.MM.yyyy HH:mm";
            eventstartDateTimePicker.Format = DateTimePickerFormat.Custom;
            eventstartDateTimePicker.Location = new Point(169, 224);
            eventstartDateTimePicker.Name = "eventstartDateTimePicker";
            eventstartDateTimePicker.Size = new Size(232, 27);
            eventstartDateTimePicker.TabIndex = 9;
            // 
            // eventendeDateTimePicker
            // 
            eventendeDateTimePicker.CustomFormat = "dd.MM.yyyy HH:mm";
            eventendeDateTimePicker.Format = DateTimePickerFormat.Custom;
            eventendeDateTimePicker.Location = new Point(169, 265);
            eventendeDateTimePicker.Name = "eventendeDateTimePicker";
            eventendeDateTimePicker.Size = new Size(232, 27);
            eventendeDateTimePicker.TabIndex = 10;
            // 
            // eventnameTextBox
            // 
            eventnameTextBox.Location = new Point(169, 54);
            eventnameTextBox.Name = "eventnameTextBox";
            eventnameTextBox.Size = new Size(232, 27);
            eventnameTextBox.TabIndex = 11;
            // 
            // eventbeschreibungRichTextBox
            // 
            eventbeschreibungRichTextBox.Location = new Point(169, 97);
            eventbeschreibungRichTextBox.Name = "eventbeschreibungRichTextBox";
            eventbeschreibungRichTextBox.Size = new Size(232, 113);
            eventbeschreibungRichTextBox.TabIndex = 12;
            eventbeschreibungRichTextBox.Text = "";
            // 
            // staatLabel
            // 
            staatLabel.AutoSize = true;
            staatLabel.Location = new Point(435, 60);
            staatLabel.Name = "staatLabel";
            staatLabel.Size = new Size(46, 20);
            staatLabel.TabIndex = 13;
            staatLabel.Text = "Staat:";
            // 
            // ortLabel
            // 
            ortLabel.AutoSize = true;
            ortLabel.Location = new Point(435, 100);
            ortLabel.Name = "ortLabel";
            ortLabel.Size = new Size(33, 20);
            ortLabel.TabIndex = 14;
            ortLabel.Text = "Ort:";
            // 
            // staatTextBox
            // 
            staatTextBox.Location = new Point(552, 54);
            staatTextBox.Name = "staatTextBox";
            staatTextBox.Size = new Size(232, 27);
            staatTextBox.TabIndex = 15;
            // 
            // ortTextBox
            // 
            ortTextBox.Location = new Point(552, 97);
            ortTextBox.Name = "ortTextBox";
            ortTextBox.Size = new Size(232, 27);
            ortTextBox.TabIndex = 16;
            // 
            // postleitzahlLabel
            // 
            postleitzahlLabel.AutoSize = true;
            postleitzahlLabel.Location = new Point(435, 143);
            postleitzahlLabel.Name = "postleitzahlLabel";
            postleitzahlLabel.Size = new Size(87, 20);
            postleitzahlLabel.TabIndex = 17;
            postleitzahlLabel.Text = "Postleitzahl:";
            // 
            // postleitzahlTextBox
            // 
            postleitzahlTextBox.Location = new Point(552, 140);
            postleitzahlTextBox.Name = "postleitzahlTextBox";
            postleitzahlTextBox.Size = new Size(232, 27);
            postleitzahlTextBox.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(435, 186);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 19;
            label1.Text = "Straße:";
            // 
            // straßeTextBox
            // 
            straßeTextBox.Location = new Point(552, 183);
            straßeTextBox.Name = "straßeTextBox";
            straßeTextBox.Size = new Size(232, 27);
            straßeTextBox.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(435, 229);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 21;
            label2.Text = "Hausnummer:";
            // 
            // hausnummerTextBox
            // 
            hausnummerTextBox.Location = new Point(552, 226);
            hausnummerTextBox.Name = "hausnummerTextBox";
            hausnummerTextBox.Size = new Size(232, 27);
            hausnummerTextBox.TabIndex = 22;
            // 
            // eventEndeCheckBox
            // 
            eventEndeCheckBox.AutoSize = true;
            eventEndeCheckBox.Location = new Point(15, 269);
            eventEndeCheckBox.Name = "eventEndeCheckBox";
            eventEndeCheckBox.Size = new Size(103, 24);
            eventEndeCheckBox.TabIndex = 23;
            eventEndeCheckBox.Text = "Eventende:";
            eventEndeCheckBox.UseVisualStyleBackColor = true;
            // 
            // EventAnpassenForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 394);
            ControlBox = false;
            Controls.Add(eventEndeCheckBox);
            Controls.Add(hausnummerTextBox);
            Controls.Add(label2);
            Controls.Add(straßeTextBox);
            Controls.Add(label1);
            Controls.Add(postleitzahlTextBox);
            Controls.Add(postleitzahlLabel);
            Controls.Add(ortTextBox);
            Controls.Add(staatTextBox);
            Controls.Add(ortLabel);
            Controls.Add(staatLabel);
            Controls.Add(eventbeschreibungRichTextBox);
            Controls.Add(eventnameTextBox);
            Controls.Add(eventendeDateTimePicker);
            Controls.Add(eventstartDateTimePicker);
            Controls.Add(standortLabel);
            Controls.Add(eventstartLabel);
            Controls.Add(eventbeschreibungLabel);
            Controls.Add(eventnameLabel);
            Controls.Add(allgemeineDatenLabel);
            Controls.Add(abbrechenButton);
            Controls.Add(eventSpeichernButton);
            Name = "EventAnpassenForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Event Anpassen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button eventSpeichernButton;
        private Button abbrechenButton;
        private Label allgemeineDatenLabel;
        private Label eventnameLabel;
        private Label eventbeschreibungLabel;
        private Label eventstartLabel;
        private Label standortLabel;
        private DateTimePicker eventstartDateTimePicker;
        private DateTimePicker eventendeDateTimePicker;
        private TextBox eventnameTextBox;
        private RichTextBox eventbeschreibungRichTextBox;
        private Label staatLabel;
        private Label ortLabel;
        private TextBox staatTextBox;
        private TextBox ortTextBox;
        private Label postleitzahlLabel;
        private TextBox postleitzahlTextBox;
        private Label label1;
        private TextBox straßeTextBox;
        private Label label2;
        private TextBox hausnummerTextBox;
        private CheckBox eventEndeCheckBox;
    }
}