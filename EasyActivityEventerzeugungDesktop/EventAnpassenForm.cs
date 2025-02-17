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
        public EventAnpassenForm (Token token) {
            InitializeComponent();
            this.token = token;
        }

        public EventAnpassenForm (Token token,EventDaten aktivität): this(token) {
            eventnameTextBox.Text = aktivität.Titel;
            eventbeschreibungRichTextBox.Text = aktivität.Beschreibung;
            eventstartDateTimePicker.Value = aktivität.Startzeitpunkt;
            if(aktivität.Endzeitpunkt != DateTime.MinValue) {
                eventEndeCheckBox.Checked = true;
                eventendeDateTimePicker.Value = aktivität.Endzeitpunkt;
            }
            staatTextBox.Text = aktivität.Staat;
            ortTextBox.Text = aktivität.Ort;
            postleitzahlTextBox.Text = aktivität.Postleitzahl;
            straßeTextBox.Text = aktivität.Straße;
            hausnummerTextBox.Text = aktivität.Hausnummer;
            bearbeitetEvent = (true,aktivität.AktivitätID);
        }

        Token token;

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
            this.Dispose();
        }

        private bool bearbeitenEventInDatenbank (Token token,long id) {
            using (HttpClient client = new HttpClient()) {
                client.BaseAddress = new Uri("https://easy-activity-api.vercel.app/");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer",token.AccessToken);
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

        private bool erstelleEventInDatenbank (Token token) {
            using (HttpClient client = new HttpClient()) {
                client.BaseAddress = new Uri("https://easy-activity-api.vercel.app/");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer",token.AccessToken);
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

        private void abbrechenButton_Click (object sender,EventArgs e) {
            if (MessageBox.Show("Wollen Sie den Vorgang wirklich abbrechen?","Abbrechen",MessageBoxButtons.YesNo) == DialogResult.Yes) {
                this.Close();
                this.Dispose();
            }
        }
        private (bool bearbeiten,long id) bearbeitetEvent = (false,long.MinValue);
    }
}
