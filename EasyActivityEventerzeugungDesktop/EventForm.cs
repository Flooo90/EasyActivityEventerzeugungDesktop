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
            var meineAktivit�ten = abrufenMeineAktivit�ten(token);
            meineAktivit�tenDataGridView.DataSource = meineAktivit�ten;
        }

        private List<EventDaten> abrufenMeineAktivit�ten (Token token) {
            using (HttpClient client = new HttpClient()) {
                List<EventDaten> aktivit�ten = new List<EventDaten>();
                client.BaseAddress = new Uri("https://easy-activity-api.vercel.app/");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer",token.AccessToken);
                var response = client.GetAsync("Aktivitaet/MeineAktivitaeten").Result;
                if (!response.IsSuccessStatusCode) {
                    return aktivit�ten;
                }
                var jsonStream = response.Content.ReadAsStream();
                var test = DateTime.MinValue;
                var ApiAntworten = JsonSerializer.Deserialize<List<Dictionary<string,object>>>(jsonStream);
                foreach (Dictionary<string,object> apiAntwort in ApiAntworten) {
                    aktivit�ten.Add(new EventDaten(apiAntwort));
                }
                return aktivit�ten;
            }
        }

        private void neuesEventErstellenButton_Click (object sender,EventArgs e) {
            EventAnpassenForm eventAnpassenForm = new EventAnpassenForm(nutzerToken);
            eventAnpassenForm.ShowDialog();
            var meineAktivit�ten = abrufenMeineAktivit�ten(nutzerToken);
            meineAktivit�tenDataGridView.DataSource = meineAktivit�ten;
        }

        private void gew�hltesEventBearbeitenButton_Click (object sender,EventArgs e) {
            EventAnpassenForm eventAnpassenForm = new EventAnpassenForm(
                nutzerToken,
                (EventDaten)meineAktivit�tenDataGridView.CurrentRow.DataBoundItem
            );
            eventAnpassenForm.ShowDialog();
            var meineAktivit�ten = abrufenMeineAktivit�ten(nutzerToken);
            meineAktivit�tenDataGridView.DataSource = meineAktivit�ten;
        }

        private Token nutzerToken;
        private List<EventDaten> aktivit�ten;
    }
}
