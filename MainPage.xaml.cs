using Microsoft.Maui.Controls;
using System;
using PokerClickerV3.Views;

namespace PokerClickerV3
{
    public partial class NavPage : ContentPage
    {
        public NavPage() : base()
        {
            StackLayout layout = base.Content.GetVisualTreeDescendants().First() as StackLayout;
            Grid grid = new();
            ColumnDefinitionCollection gridColumnDefinitions = grid.ColumnDefinitions;
            for (int i = 0; i < 3; i++)
            {
                ColumnDefinition columnDefinition = new();
                columnDefinition.Width = GridLength.Star;
                gridColumnDefinitions.Add(columnDefinition);
            }

            Microsoft.Maui.Controls.Button gameButton = new();
            gameButton.Text = "Game";
            gameButton.Clicked += (object sender, EventArgs e) => OnGameButtonClicked(sender, e);
            layout.Children.Add(gameButton);

            layout.Children.Add(grid);
        }



        private void OnGameButtonClicked(object sender, EventArgs e)
        {
            // Handle the Game button click event
            // For example, navigate to the Game page
            //Navigation.PushAsync(new MainPage());
        }

        private void OnShopButtonClicked(object sender, EventArgs e)
        {
            // Handle the Shop button click event
            // For example, navigate to the Shop page
            //Navigation.PushAsync(new ShopPage());
        }

        private void OnSettingsButtonClicked(object sender, EventArgs e)
        {
            // Handle the Settings button click event
            // For example, navigate to the Settings page
            //Navigation.PushAsync(new SettingsPage());
            Application.Current.MainPage = new NavigationPage(new SettingsPage());
        }
    }

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
    }
}
