using Microsoft.Maui.Controls;
using System;

namespace PokerClickerV3
{
    public partial class GamePage : ContentPage
    {
        int count = 0;

        // ScoreLabel deklaratsioon
        Label scoreLabel;

        public GamePage()
        {
            InitializeComponent();
        }

        private async void OnPokerImageTapped(object sender, EventArgs e)
        {
            count++;

            await ((VisualElement)sender).ScaleTo(0.8, 250);
            await ((VisualElement)sender).ScaleTo(1, 250);

            // Veenduge, et ScoreLabel on initsialiseeritud enne kasutamist
            if (scoreLabel != null)
                scoreLabel.Text = $"Score: {count}";

            Console.WriteLine($"Clicked {count} times");
        }
    }
}
