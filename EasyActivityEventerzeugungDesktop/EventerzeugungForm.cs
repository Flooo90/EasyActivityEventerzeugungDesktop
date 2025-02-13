namespace EasyActivityEventerzeugungDesktop
{
    public partial class EventerzeugungForm : Form
    {
        public EventerzeugungForm()
        {
            InitializeComponent();
            AnmeldungForm anmeldungForm = new AnmeldungForm();
            anmeldungForm.AnmeldungErfolgreich += handleAnmeldungErfolgreich;
            anmeldungForm.ShowDialog();
        }

        private void handleAnmeldungErfolgreich(object sender, Token token) {
            this.nutzerToken = token;
        }

        private Token nutzerToken;
    }
}
