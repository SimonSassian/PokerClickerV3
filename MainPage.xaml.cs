using Microsoft.Maui.Controls;
using System;

namespace PokerClickerV3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var stackLayout = new StackLayout
            {
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            var button = new Button
            {
                Text = "Start Game"
            };
            button.Clicked += OnStartGameClicked;

            stackLayout.Children.Add(button);

            Content = stackLayout;
        }

        private async void OnStartGameClicked(object sender, EventArgs e)
        {
            // Käivitame mängu akna, see võib olla näiteks ShopPage
            var gamePage = new GamePage();
            await Navigation.PushAsync(gamePage);
        }
    }
}
