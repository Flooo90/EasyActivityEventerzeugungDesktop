using System.Net.Http.Headers;
using System.Text.Json;

namespace EasyActivityEventerzeugungDesktop {
    public partial class EventForm:Form {
        public EventForm () {
            InitializeComponent();
            AnmeldungForm anmeldungForm = new AnmeldungForm();
            anmeldungForm.AnmeldungErfolgreich += handleAnmeldungErfolgreich;
            anmeldungForm.ShowDialog();
        }

        private void handleAnmeldungErfolgreich (object sender,Token token) {
            this.nutzerToken = token;
            var meineAktivitäten = abrufenMeineAktivitäten(token);
            meineAktivitätenDataGridView.DataSource = meineAktivitäten;
        }

        private List<EventDaten> abrufenMeineAktivitäten (Token token) {
            using (HttpClient client = new HttpClient()) {
                List<EventDaten> aktivitäten = new List<EventDaten>();
                client.BaseAddress = new Uri("https://easy-activity-api.vercel.app/");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer",token.AccessToken);
                var response = client.GetAsync("Aktivitaet/MeineAktivitaeten").Result;
                if (!response.IsSuccessStatusCode) {
                    return aktivitäten;
                }
                var jsonStream = response.Content.ReadAsStream();
                var test = DateTime.MinValue;
                var ApiAntworten = JsonSerializer.Deserialize<List<Dictionary<string,object>>>(jsonStream);
                foreach (Dictionary<string,object> apiAntwort in ApiAntworten) {
                    aktivitäten.Add(new EventDaten(apiAntwort));
                }
                return aktivitäten;
            }
        }

        private void neuesEventErstellenButton_Click (object sender,EventArgs e) {
            EventAnpassenForm eventAnpassenForm = new EventAnpassenForm(nutzerToken);
            eventAnpassenForm.ShowDialog();
            var meineAktivitäten = abrufenMeineAktivitäten(nutzerToken);
            meineAktivitätenDataGridView.DataSource = meineAktivitäten;
        }

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
