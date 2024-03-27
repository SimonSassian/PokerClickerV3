using Microsoft.Maui.ApplicationModel;
using Microsoft.Maui.Controls;
using System;

namespace PokerClickerV3
{
    public partial class SettingsPage : ContentPage
    {
        // Constructor
        public SettingsPage()
        {
            InitializeComponent();
        }

        // Muusika sisse v�i v�lja l�litamine
        private void ToggleMusicSwitch_Toggled(object sender, ToggledEventArgs e)
        {
            // Kood muusika sisse v�i v�lja l�litamiseks
            bool musicOn = e.Value;
            if (musicOn)
            {
                // L�lita muusika sisse
                // N�ide: MusicPlayer.Play();
            }
            else
            {
                // L�lita muusika v�lja
                // N�ide: MusicPlayer.Stop();
            }
        }

        // Tume v�i hele re�iimi vahetamine
        private void ToggleDarkModeSwitch_Toggled(object sender, ToggledEventArgs e)
        {
            bool darkModeOn = e.Value;
            if (darkModeOn)
            {
                // L�lita tume re�iim sisse
                App.Current.UserAppTheme = AppTheme.Dark;
            }
            else
            {
                // L�lita hele re�iim sisse
                App.Current.UserAppTheme = AppTheme.Light;
            }
        }

        // K�ivitatakse, kui kasutaja kl�psab seadete nupul
        private void OnSettingsButtonClicked(object sender, EventArgs e)
        {
            // Siin saate lisada koodi, mis peaks k�ivituma, kui kasutaja kl�psab seadete nuppu
            Navigation.PushAsync(new SettingsPage());
        }
    }
}
