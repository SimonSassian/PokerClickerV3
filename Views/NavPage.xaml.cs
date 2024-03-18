using Microsoft.Maui.Controls;
using PokerClickerV3.Views;
using System;
using Views;

namespace PokerClickerV3
{
    public partial class NavPage : ContentPage
    {
        public NavPage() : base()
        {
            // Do not initialize content here
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            // Initialize content here
            StackLayout layout = base.Content.GetVisualTreeDescendants().FirstOrDefault() as StackLayout;

            if (layout != null)
            {
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
}
