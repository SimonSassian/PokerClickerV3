using Microsoft.Maui.Controls;

namespace PokerClickerV3
{
    public partial class GamePage : ContentPage
    {
        int count = 0;

        public GamePage()
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
