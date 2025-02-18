using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyActivityEventerzeugungDesktop {
    public partial class AnmeldungForm : Form {

        /// <summary> Ereignis, das ausgelöst wird, wenn der Benutzer sich erfolgreich anmeldet </summary>
        public EventHandler<Token> AnmeldungErfolgreich;

        /// <summary> Initialisiert eine neue Instanz der <see cref="AnmeldungForm"/> Klasse </summary>
        public AnmeldungForm() {
            InitializeComponent();
        }

        /// <summary> Überprüft die Anmeldedaten des Benutzers </summary>
        /// <returns> Ein <see cref="Token"/>, wenn die Anmeldung erfolgreich war; andernfalls null </returns>
        private Token checkAnmeldung() {
            using (HttpClient client = new HttpClient()) {
                client.BaseAddress = new Uri("https://easy-activity-api.vercel.app/");
                var anmeldedaten = new FormUrlEncodedContent(new Dictionary<string, string> {
                    { "username", nutzernameTextBox.Text },
                    { "password", passwortTextBox.Text }
                });
                var response = client.PostAsync("token", anmeldedaten).Result;
                if (!response.IsSuccessStatusCode) {
                    MessageBox.Show("Anmeldung fehlgeschlagen");
                    return null;
                } else {
                    var jsonStream = response.Content.ReadAsStream();
                    try {
                        var token = JsonSerializer.Deserialize<Token>(jsonStream);
                        if (token?.IstEventveranstalter == true) {
                            return token;
                        } else {
                            return null;
                        }
                    } catch (JsonException) {
                        MessageBox.Show("Fehler bei der Verarbeitung der Antwortdaten");
                        return null;
                    }
                }
            }
        }

        /// <summary> Beendet die Anwendung, wenn der Abbrechen-Button geklickt wird </summary>
        /// <param name="sender"> Das Ereignisquelle-Objekt </param>
        /// <param name="e"> Das <see cref="EventArgs"/> Objekt, das die Ereignisdaten enthält </param>
        private void abbrechenButton_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        /// <summary> Überprüft die Anmeldedaten und löst das <see cref="AnmeldungErfolgreich"/> Ereignis aus, wenn die Anmeldung erfolgreich ist </summary>
        /// <param name="sender"> Das Ereignisquelle-Objekt </param>
        /// <param name="e"> Das <see cref="EventArgs"/> Objekt, das die Ereignisdaten enthält </param>
        private void anmeldenButton_Click(object sender, EventArgs e) {
            anmeldenButton.Enabled = abbrechenButton.Enabled = false;
            try {
                Token userToken = checkAnmeldung();
                if (userToken != null) {
                    AnmeldungErfolgreich?.Invoke(this, userToken);
                    this.Close();
                }
            } finally {
                anmeldenButton.Enabled = abbrechenButton.Enabled = true;
            }
        }
    }
}
