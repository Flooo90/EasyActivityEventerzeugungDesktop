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
            meineAktivitätenDataGridView = new DataGridView();
            neuesEventErstellenButton = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)meineAktivitätenDataGridView).BeginInit();
            SuspendLayout();
            // 
            // meineAktivitätenDataGridView
            // 
            meineAktivitätenDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            meineAktivitätenDataGridView.Location = new Point(15, 73);
            meineAktivitätenDataGridView.Name = "meineAktivitätenDataGridView";
            meineAktivitätenDataGridView.RowHeadersWidth = 51;
            meineAktivitätenDataGridView.Size = new Size(776, 188);
            meineAktivitätenDataGridView.TabIndex = 0;
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
            // button1
            // 
            button1.Location = new Point(571, 15);
            button1.Name = "button1";
            button1.Size = new Size(220, 29);
            button1.TabIndex = 2;
            button1.Text = "Gewähltes Event bearbeiten";
            button1.UseVisualStyleBackColor = true;
            // 
            // EventForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 271);
            Controls.Add(button1);
            Controls.Add(neuesEventErstellenButton);
            Controls.Add(meineAktivitätenDataGridView);
            Name = "EventForm";
            Text = "Eigene Events";
            ((System.ComponentModel.ISupportInitialize)meineAktivitätenDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView meineAktivitätenDataGridView;
        private Button neuesEventErstellenButton;
        private Button button1;
    }
}
