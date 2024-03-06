namespace PokerClickerV3
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnPokerImageTapped(object sender, EventArgs e)
        {
            count++;

            // Pildi suuruse muutmine animatsiooniga
            await ((VisualElement)sender).ScaleTo(0.8, 250); // Muudab suurust 80% -le originaalist
            await ((VisualElement)sender).ScaleTo(1, 250); // Taastab originaalsuuruse

            // Skoori väärtuse muutmine vastavalt klõpsude arvule
            ScoreLabel.Text = $"Score: {count}";

            // Asendage SemanticScreenReader.Announce oma eelistatud teabeedastusmeetodiga
            Announce($"Clicked {count} times");
        }

        // Funktsioon teabe edastamiseks (võib olla osa teisest teenusest)
        private void Announce(string message)
        {
            // Asendage see osa oma rakenduse konkreetse teabe edastamise meetodiga
            Console.WriteLine(message);
        }
    }
}
