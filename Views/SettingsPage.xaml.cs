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

        // Muusika sisse või välja lülitamine
        private void ToggleMusicSwitch_Toggled(object sender, ToggledEventArgs e)
        {
            // Kood muusika sisse või välja lülitamiseks
            bool musicOn = e.Value;
            if (musicOn)
            {
                // Lülita muusika sisse
                // Näide: MusicPlayer.Play();
            }
            else
            {
                // Lülita muusika välja
                // Näide: MusicPlayer.Stop();
            }
        }

        // Tume või hele reþiimi vahetamine
        private void ToggleDarkModeSwitch_Toggled(object sender, ToggledEventArgs e)
        {
            bool darkModeOn = e.Value;
            if (darkModeOn)
            {
                // Lülita tume reþiim sisse
                App.Current.UserAppTheme = AppTheme.Dark;
            }
            else
            {
                // Lülita hele reþiim sisse
                App.Current.UserAppTheme = AppTheme.Light;
            }
        }

        // Käivitatakse, kui kasutaja klõpsab seadete nupul
        private void OnSettingsButtonClicked(object sender, EventArgs e)
        {
            // Siin saate lisada koodi, mis peaks käivituma, kui kasutaja klõpsab seadete nuppu
            Navigation.PushAsync(new SettingsPage());
        }
    }
}
