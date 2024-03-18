using PokerClickerV3;

namespace Views;

    public partial class IntroPage : ContentPage
    {
        public IntroPage()
        {
            InitializeComponent();
        }

        private async void Play_Clicked(object sender, EventArgs e)
        {
            // Navigate to the game page
            await Navigation.PushAsync(new NavPage());
        }
    }