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

namespace EasyActivityEventerzeugungDesktop
{
    public partial class AnmeldungForm : Form
    {

        public EventHandler<Token> AnmeldungErfolgreich;
        public AnmeldungForm()
        {
            InitializeComponent();
        }

        private Token checkAnmeldung() {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://easy-activity-api.vercel.app/");
                var anmeldedaten = new FormUrlEncodedContent(new Dictionary<string, string> {
                    { "username", nutzernameTextBox.Text },
                    { "password", passwortTextBox.Text }
                });
                var response = client.PostAsync("token", anmeldedaten).Result;
                if(!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Anmeldung fehlgeschlagen");
                    return null;
                } else {
                    var jsonStream = response.Content.ReadAsStream();
                    var test = response.Content.ReadAsStringAsync().Result;
                    var token = JsonSerializer.Deserialize<Token>(jsonStream);
                    if (token?.IstEventveranstalter == true) {
                        return token;
                    } else { 
                        return null;
                    }
                }
            }
        }

        private void abbrechenButton_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void anmeldenButton_Click(object sender, EventArgs e) {
            anmeldenButton.Enabled = abbrechenButton.Enabled = false;
            Token userToken = checkAnmeldung();
            if (userToken != null) {
                AnmeldungErfolgreich?.Invoke(this, userToken);
                this.Close();
                this.Dispose();
            }
            anmeldenButton.Enabled = abbrechenButton.Enabled = true;
        }
    }

    public class Token
    {
        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; }

        [JsonPropertyName("token_type")]
        public string TokenType { get; set; }

        [JsonPropertyName("IstEventveranstalter")]
        public bool IstEventveranstalter { get; set; }
    }
}
