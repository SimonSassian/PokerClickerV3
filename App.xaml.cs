using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Views;

namespace PokerClickerV3
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Set the MainPage to your intro page
            MainPage = new NavigationPage(new IntroPage());
        }
    }
}
