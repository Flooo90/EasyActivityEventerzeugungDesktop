namespace EasyActivityEventerzeugungDesktop
{
    partial class AnmeldungForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnmeldungForm));
            passwortTextBox = new TextBox();
            nutzernameTextBox = new TextBox();
            passwortLabel = new Label();
            nutzernameLabel = new Label();
            anmeldenButton = new Button();
            abbrechenButton = new Button();
            SuspendLayout();
            // 
            // passwortTextBox
            // 
            passwortTextBox.Location = new Point(138, 57);
            passwortTextBox.Name = "passwortTextBox";
            passwortTextBox.Size = new Size(193, 27);
            passwortTextBox.TabIndex = 7;
            // 
            // nutzernameTextBox
            // 
            nutzernameTextBox.Location = new Point(138, 12);
            nutzernameTextBox.Name = "nutzernameTextBox";
            nutzernameTextBox.Size = new Size(193, 27);
            nutzernameTextBox.TabIndex = 6;
            // 
            // passwortLabel
            // 
            passwortLabel.AutoSize = true;
            passwortLabel.Location = new Point(14, 60);
            passwortLabel.Name = "passwortLabel";
            passwortLabel.Size = new Size(69, 20);
            passwortLabel.TabIndex = 5;
            passwortLabel.Text = "Passwort:";
            // 
            // nutzernameLabel
            // 
            nutzernameLabel.AutoSize = true;
            nutzernameLabel.Location = new Point(14, 15);
            nutzernameLabel.Name = "nutzernameLabel";
            nutzernameLabel.Size = new Size(93, 20);
            nutzernameLabel.TabIndex = 4;
            nutzernameLabel.Text = "Nutzername:";
            // 
            // anmeldenButton
            // 
            anmeldenButton.Location = new Point(12, 107);
            anmeldenButton.Name = "anmeldenButton";
            anmeldenButton.Size = new Size(94, 29);
            anmeldenButton.TabIndex = 8;
            anmeldenButton.Text = "Anmelden";
            anmeldenButton.UseVisualStyleBackColor = true;
            anmeldenButton.Click += anmeldenButton_Click;
            // 
            // abbrechenButton
            // 
            abbrechenButton.Location = new Point(237, 107);
            abbrechenButton.Name = "abbrechenButton";
            abbrechenButton.Size = new Size(94, 29);
            abbrechenButton.TabIndex = 9;
            abbrechenButton.Text = "Abbrechen";
            abbrechenButton.UseVisualStyleBackColor = true;
            abbrechenButton.Click += abbrechenButton_Click;
            // 
            // AnmeldungForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 148);
            ControlBox = false;
            Controls.Add(abbrechenButton);
            Controls.Add(anmeldenButton);
            Controls.Add(passwortTextBox);
            Controls.Add(nutzernameTextBox);
            Controls.Add(passwortLabel);
            Controls.Add(nutzernameLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AnmeldungForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Anmeldung";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox passwortTextBox;
        private TextBox nutzernameTextBox;
        private Label passwortLabel;
        private Label nutzernameLabel;
        private Button anmeldenButton;
        private Button abbrechenButton;
    }
}