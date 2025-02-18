using System.Net.Http.Headers;
using System.Text.Json;

namespace EasyActivityEventerzeugungDesktop {
    public partial class EventForm:Form {
        /// <summary> Initialisiert eine neue Instanz der <see cref="EventForm"/> Klasse.
        /// Dieser Konstruktor initialisiert die Form-Komponenten und erstellt eine Instanz von 
        /// <see cref="AnmeldungForm"/>. Er abonniert das <see cref="AnmeldungForm.AnmeldungErfolgreich"/> 
        /// Ereignis mit der <see cref="handleAnmeldungErfolgreich"/> Methode und zeigt die 
        /// <see cref="AnmeldungForm"/> als Dialog an </summary>
        public EventForm () {
            InitializeComponent();
            AnmeldungForm anmeldungForm = new AnmeldungForm();
            anmeldungForm.AnmeldungErfolgreich += handleAnmeldungErfolgreich;
            anmeldungForm.ShowDialog();
        }

        /// <summary> Behandelt das erfolgreiche Anmeldeereignis </summary>
        /// <param name="sender"> Die Quelle des Ereignisses </param>
        /// <param name="token"> Das Token, das nach erfolgreicher Anmeldung empfangen wurde </param>
        private void handleAnmeldungErfolgreich (object sender,Token token) {
            this.nutzerToken = token;
            var meineAktivitäten = abrufenMeineAktivitäten(token);
            meineAktivitätenDataGridView.DataSource = meineAktivitäten;
        }

        /// <summary> Ruft die Aktivitäten des Benutzers ab, indem eine Anfrage an die Easy Activity API gesendet wird </summary>
        /// <param name="token"> Das Token, das für die Authentifizierung gegenüber der API verwendet wird </param>
        /// <returns> Eine Liste von <see cref="EventDaten"/>, die die Aktivitäten des Benutzers enthält </returns>
        private List<EventDaten> abrufenMeineAktivitäten (Token token) {
            using (HttpClient client = new HttpClient()) {
                List<EventDaten> aktivitäten = new List<EventDaten>();
                client.BaseAddress = new Uri("https://easy-activity-api.vercel.app/");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(token.TokenType,token.AccessToken);
                var response = client.GetAsync("Aktivitaet/MeineAktivitaeten").Result;
                if (!response.IsSuccessStatusCode) {
                    return aktivitäten;
                }
                var jsonStream = response.Content.ReadAsStream();
                var ApiAntworten = JsonSerializer.Deserialize<List<Dictionary<string,object>>>(jsonStream);
                foreach (Dictionary<string,object> apiAntwort in ApiAntworten) {
                    aktivitäten.Add(new EventDaten(apiAntwort));
                }
                return aktivitäten;
            }
        }

        /// <summary> Wird aufgerufen, wenn der Button 'Neues Event Erstellen' geklickt wird.
        /// Öffnet ein neues Formular zur Anpassung eines Events und aktualisiert die Aktivitäten-Ansicht </summary>
        /// <param name="sender"> Die Quelle des Ereignisses </param>
        /// <param name="e"> Die <see cref="EventArgs"/> Instanz, die die Ereignisdaten enthält </param>
        private void neuesEventErstellenButton_Click (object sender,EventArgs e) {
            EventAnpassenForm eventAnpassenForm = new EventAnpassenForm(nutzerToken);
            eventAnpassenForm.ShowDialog();
            var meineAktivitäten = abrufenMeineAktivitäten(nutzerToken);
            meineAktivitätenDataGridView.DataSource = meineAktivitäten;
        }

        /// <summary> Wird aufgerufen, wenn der Button 'Gewähltes Event Bearbeiten' geklickt wird.
        /// Öffnet ein neues Formular zur Bearbeitung des ausgewählten Events und aktualisiert die Aktivitäten-Ansicht </summary>
        /// <param name="sender"> Die Quelle des Ereignisses </param>
        /// <param name="e"> Die <see cref="EventArgs"/> Instanz, die die Ereignisdaten enthält </param>
        private void gewähltesEventBearbeitenButton_Click (object sender,EventArgs e) {
            EventAnpassenForm eventAnpassenForm = new EventAnpassenForm(
                nutzerToken,
                (EventDaten)meineAktivitätenDataGridView.CurrentRow.DataBoundItem
            );
            eventAnpassenForm.ShowDialog();
            var meineAktivitäten = abrufenMeineAktivitäten(nutzerToken);
            meineAktivitätenDataGridView.DataSource = meineAktivitäten;
        }

        private Token nutzerToken;
        private List<EventDaten> aktivitäten;
    }
}
