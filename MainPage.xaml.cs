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

            // Asendage SemanticScreenReader.Announce oma eelistatud teabeedastusmeetodiga
            Announce($"Clicked {count} times");
        }

        // Funktsioon teabe edastamiseks (võib olla osa teisest teenusest)
        private void Announce(string message)
        {
            // Asendage see osa oma rakenduse konkreetse teabe edastamise meetodiga
            Console.WriteLine(message);
        }

        private void OnPokerImageClicked(object sender, EventArgs e)
        {
            count++;

            // Jälgime klõpsamise arvu, kuid ei muuda pildi lähtepilti
            if (count == 1)
            {
                ((ImageButton)sender).Source = ImageSource.FromFile("pokerclicked.png");
            }

            SemanticScreenReader.Announce($"Clicked {count} times");
        }
    }
}
