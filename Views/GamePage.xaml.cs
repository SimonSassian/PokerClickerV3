using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Compatibility;
using System;

namespace PokerClickerV3
{
    public partial class GamePage : ContentPage
    {
        int count = 0;
        Label scoreLabel;

        public GamePage()
        {
            InitializeComponent();

            // Loome ja konfigureerime skoori sildi
            scoreLabel = new Label
            {
                Text = $"Score: {count}",
                FontSize = 18,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Start
            };

            // Lisame skoori sildi StackLayout'ile
            stackLayout.Children.Add(scoreLabel);

            // Lisame tagasi nupu
            var backButton = new Button
            {
                Text = "Back"
            };
            backButton.Clicked += OnBackButtonClicked;
            stackLayout.Children.Add(backButton);
        }

        private async void OnPokerImageTapped(object sender, EventArgs e)
        {
            count++;

            await ((VisualElement)sender).ScaleTo(0.8, 250);
            await ((VisualElement)sender).ScaleTo(1, 250);

            if (scoreLabel != null)
                scoreLabel.Text = $"Score: {count}";

            Console.WriteLine($"Clicked {count} times");
        }

        // Tagasi nupu käsitsemine
        private async void OnBackButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        // Lisatud OnGameButtonClicked funktsioon
        async void OnGameButtonClicked(object sender, EventArgs e)
        {
            // Siia lisage vajalik kood, mis peaks käivituma nupule "Game" klõpsamisel
            Console.WriteLine("Game button clicked");
            Navigation.PushAsync(new GamePage());
        }

        async void OnShopButtonClicked(System.Object sender, System.EventArgs e)
            => Application.Current.MainPage = new NavigationPage(new ShopPage(count));

        async void OnSettingsButtonClicked(System.Object sender, System.EventArgs e)
            => Application.Current.MainPage = new NavigationPage(new SettingsPage());
    }
}
