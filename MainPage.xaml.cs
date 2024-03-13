using PokerClickerV3.Views;

namespace PokerClickerV3
{


  public partial class MainPage : ContentPage
  {
    private void PlayClicked(object sender, EventArgs e)
    {
        // Handle the Settings button click event
        // For example, navigate to the Settings page
        //Navigation.PushAsync(new SettingsPage());
        Application.Current.MainPage = new NavigationPage(new NavPage());
    }

  }
}