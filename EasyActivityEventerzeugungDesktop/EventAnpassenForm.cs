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

namespace EasyActivityEventerzeugungDesktop
{
    public partial class EventAnpassenForm : Form
    {
        public EventAnpassenForm(Token token)
        {
            InitializeComponent();
            this.token = token;
        }

        public EventAnpassenForm(Token token, EventDaten aktivität)
        {

        }

        Token token;

        private void eventSpeichernButton_Click(object sender, EventArgs e)
        {
            if (erstelleEventInDatenbank(token)) { 
            
            }
        }

        private bool erstelleEventInDatenbank(Token token)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://easy-activity-api.vercel.app/");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token.AccessToken);
                var eventdaten = new Dictionary<string, object> {
                    { "Titel", eventnameTextBox.Text },
                    { "Beschreibung", beschreibungRichTextBox.Text },
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
                    { "Endzeitpunkt",eventEndeCheckBox.Checked? eventendeDateTimePicker.Value : string.Empty}
                } ;
                var json = JsonSerializer.Serialize(eventdaten);

                // JSON-Daten in den HTTP-Inhalt einfügen
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = client.PostAsync("Aktivitaet", content).Result;
                var resText = response.Content.ReadAsStringAsync().Result;
            }
            return false;
        }
    }
}
