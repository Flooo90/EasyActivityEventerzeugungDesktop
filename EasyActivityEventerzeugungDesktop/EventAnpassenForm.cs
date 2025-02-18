using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyActivityEventerzeugungDesktop {
    public partial class EventAnpassenForm:Form {
        /// <summary> Initialisiert eine neue Instanz der <see cref="EventAnpassenForm"/> Klasse </summary>
        /// <param name="token"> Das Token, der für die Authentifizierung oder Autorisierung verwendet wird </param>
        public EventAnpassenForm (Token token) {
            InitializeComponent();
            this.token = token;
        }

        /// <summary> Initialisiert eine neue Instanz der <see cref="EventAnpassenForm"/> Klasse mit dem angegebenen Token und den Eventdaten </summary>
        /// <param name="token"> Das Token, das für die Authentifizierung oder Autorisierung verwendet wird </param>
        /// <param name="aktivität"> Die Eventdaten, die im Formular angezeigt und bearbeitet werden sollen </param>
        public EventAnpassenForm (Token token,EventDaten aktivität) : this(token) {
            eventnameTextBox.Text = aktivität.Titel;
            eventbeschreibungRichTextBox.Text = aktivität.Beschreibung;
            eventstartDateTimePicker.Value = aktivität.Startzeitpunkt;
            if (aktivität.Endzeitpunkt != DateTime.MinValue) {
                eventEndeCheckBox.Checked = true;
                eventendeDateTimePicker.Value = aktivität.Endzeitpunkt;
            }
            staatTextBox.Text = aktivität.Staat;
            ortTextBox.Text = aktivität.Ort;
            postleitzahlTextBox.Text = aktivität.Postleitzahl;
            straßeTextBox.Text = aktivität.Straße;
            hausnummerTextBox.Text = aktivität.Hausnummer;
            bearbeitetEvent = (true, aktivität.AktivitätID);
        }

        Token token;

        /// <summary> Behandelt das Click-Ereignis des eventSpeichernButton.
        /// Deaktiviert den eventSpeichernButton und abbrechenButton, überprüft dann, ob das Event bearbeitet oder erstellt wird.
        /// Wenn das Event bearbeitet wird, versucht es, das Event in der Datenbank zu aktualisieren und zeigt eine Nachricht an, die den Erfolg oder Misserfolg anzeigt.
        /// Wenn das Event erstellt wird, versucht es, das Event in der Datenbank zu erstellen und zeigt eine Nachricht an, die den Erfolg oder Misserfolg anzeigt.
        /// Schließlich wird das Formular geschlossen </summary>
        /// <param name="sender"> Die Quelle des Ereignisses </param>
        /// <param name="e"> Ein EventArgs, das die Ereignisdaten enthält </param>
        private void eventSpeichernButton_Click (object sender,EventArgs e) {
            eventSpeichernButton.Enabled = abbrechenButton.Enabled = false;
            if (bearbeitetEvent.bearbeiten) {
                if (bearbeitenEventInDatenbank(token,bearbeitetEvent.id)) {
                    MessageBox.Show("Event erfolgreich bearbeitet");
                } else {
                    MessageBox.Show("Event konnte nicht bearbeitet werden");
                }
            } else {
                if (erstelleEventInDatenbank(token)) {
                    MessageBox.Show("Event erfolgreich erstellt");
                } else {
                    MessageBox.Show("Event konnte nicht erstellt werden");
                }
            }
            this.Close();
        }

        /// <summary> Aktualisiert ein Event in der Datenbank mit den angegebenen Details </summary>
        /// <param name="token"> Das Authentifizierungstoken, das für die Autorisierung gegenüber der API verwendet wird </param>
        /// <param name="id"> Die eindeutige Kennung des zu aktualisierenden Events </param>
        /// <returns> Gibt <c>true</c> zurück, wenn das Event erfolgreich aktualisiert wurde; andernfalls <c>false</c> </returns>
        /// <remarks>
        /// Diese Methode sendet eine PATCH-Anfrage an die API, um die Eventdetails zu aktualisieren
        /// Die Eventdetails werden aus verschiedenen UI-Elementen wie Textfeldern und Datumsauswahlen gesammelt
        /// </remarks>
        private bool bearbeitenEventInDatenbank (Token token,long id) {
            using (HttpClient client = new HttpClient()) {
                client.BaseAddress = new Uri("https://easy-activity-api.vercel.app/");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(token.TokenType,token.AccessToken);
                var eventdaten = new Dictionary<string,object> {
                    { "Titel", eventnameTextBox.Text },
                    { "Beschreibung", eventbeschreibungRichTextBox.Text },
                    { "Adresse", new Dictionary<string,string>{
                        { "Staat", staatTextBox.Text },
                        { "Ort", ortTextBox.Text },
                        { "Postleitzahl", postleitzahlTextBox.Text },
                        { "Straße", straßeTextBox.Text },
                        { "Hausnummer", hausnummerTextBox.Text }
                    }
                    },
                    {"Ortsabstimmung",false },
                    {"Zeitabstimmung",false },
                    { "Startzeitpunkt", eventstartDateTimePicker.Value },
                    { "Endzeitpunkt",eventEndeCheckBox.Checked? eventendeDateTimePicker.Value : DateTime.MinValue},
                    { "OffenesEnde",!eventEndeCheckBox.Checked }
                };
                var json = JsonSerializer.Serialize(eventdaten);
                var content = new StringContent(json,Encoding.UTF8,"application/json");
                var response = client.PatchAsync($"Aktivitaet/{id}",content).Result;
                if (response.IsSuccessStatusCode) {
                    return true;
                } else {
                    return false;
                }
            }
        }

        /// <summary> Erstellt ein neues Event in der Datenbank mit den angegebenen Details </summary>
        /// <param name="token"> Das Authentifizierungstoken, das für die Autorisierung gegenüber der API verwendet wird </param>
        /// <returns> Gibt <c>true</c> zurück, wenn das Event erfolgreich erstellt wurde; andernfalls <c>false</c> </returns>
        /// <remarks>
        /// Diese Methode sendet eine POST-Anfrage an die API, um ein neues Event zu erstellen
        /// Die Eventdetails werden aus verschiedenen UI-Elementen wie Textfeldern und Datumsauswahlen gesammelt
        /// </remarks>
        private bool erstelleEventInDatenbank (Token token) {
            using (HttpClient client = new HttpClient()) {
            client.BaseAddress = new Uri("https://easy-activity-api.vercel.app/");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(token.TokenType,token.AccessToken);
            var eventdaten = new Dictionary<string,object> {
                { "Titel", eventnameTextBox.Text },
                { "Beschreibung", eventbeschreibungRichTextBox.Text },
                { "Adresse", new Dictionary<string,string>{
                { "Staat", staatTextBox.Text },
                { "Ort", ortTextBox.Text },
                { "Postleitzahl", postleitzahlTextBox.Text },
                { "Straße", straßeTextBox.Text },
                { "Hausnummer", hausnummerTextBox.Text }
                }
                },
                {"Ortsabstimmung",false },
                {"Zeitabstimmung",false },
                { "Startzeitpunkt", eventstartDateTimePicker.Value },
                { "Endzeitpunkt",eventEndeCheckBox.Checked? eventendeDateTimePicker.Value : DateTime.MinValue},
                { "OffenesEnde",!eventEndeCheckBox.Checked }
            };
            var json = JsonSerializer.Serialize(eventdaten);
            var content = new StringContent(json,Encoding.UTF8,"application/json");
            var response = client.PostAsync("Aktivitaet",content).Result;
            if (response.IsSuccessStatusCode) {
                return true;
            } else {
                return false;
            }
            }
        }

        /// <summary> Behandelt das Click-Ereignis des abbrechenButton.
        /// Zeigt dem Benutzer ein Bestätigungsdialogfeld, um zu bestätigen, ob er den Vorgang abbrechen möchte.
        /// Wenn der Benutzer bestätigt, wird das Formular geschlossen </summary>
        /// <param name="sender"> Die Quelle des Ereignisses </param>
        /// <param name="e"> Ein EventArgs, das die Ereignisdaten enthält </param>
        private void abbrechenButton_Click (object sender,EventArgs e) {
            if (MessageBox.Show("Wollen Sie den Vorgang wirklich abbrechen?","Abbrechen",MessageBoxButtons.YesNo) == DialogResult.Yes) {
                this.Close();
            }
        }
        private (bool bearbeiten, long id) bearbeitetEvent = (false, long.MinValue);
    }
}
