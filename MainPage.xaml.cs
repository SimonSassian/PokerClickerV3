using Microsoft.Maui.Controls;
using System;

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

            await ((VisualElement)sender).ScaleTo(0.8, 250);
            await ((VisualElement)sender).ScaleTo(1, 250);

            ScoreLabel.Text = $"Score: {count}";

            Console.WriteLine($"Clicked {count} times");
        }

        private void OnGameButtonClicked(object sender, EventArgs e)
        {
            // Handle the Game button click event
            // For example, navigate to the Game page
            Navigation.PushAsync(new MainPage());
        }

        private void OnShopButtonClicked(object sender, EventArgs e)
        {
            // Handle the Shop button click event
            // For example, navigate to the Shop page
            Navigation.PushAsync(new ShopPage());
        }

        private void OnSettingsButtonClicked(object sender, EventArgs e)
        {
            // Handle the Settings button click event
            // For example, navigate to the Settings page
            Navigation.PushAsync(new SettingsPage());
        }
    }
}
