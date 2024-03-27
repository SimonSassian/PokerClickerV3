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
            InitializeUI();
        }

        // Initialize UI elements
        private void InitializeUI()
        {
            // Create ToggleMusicSwitch, ToggleDarkModeSwitch, and other UI elements here
            var toggleMusicSwitch = new Switch
            {
                IsToggled = IsMusicOn(),
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };
            toggleMusicSwitch.Toggled += ToggleMusicSwitch_Toggled;

            var toggleDarkModeSwitch = new Switch
            {
                IsToggled = IsDarkModeOn(),
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };
            toggleDarkModeSwitch.Toggled += ToggleDarkModeSwitch_Toggled;

            // Create back button
            var backButton = new Button
            {
                Text = "Back"
            };
            backButton.Clicked += OnBackButtonClicked;

            // Add UI elements to the layout
            Content = new StackLayout
            {
                Children =
                {
                    new Label { Text = "Toggle Music:" },
                    toggleMusicSwitch,
                    new Label { Text = "Toggle Dark Mode:" },
                    toggleDarkModeSwitch,
                    backButton
                }
            };
        }

        // Muusika sisse või välja lülitamine
        private void ToggleMusicSwitch_Toggled(object sender, ToggledEventArgs e)
        {
            bool musicOn = e.Value;
            if (musicOn)
            {
                // Lülita muusika sisse
                // Näiteks: MusicPlayer.Play();
                SetMusicState(true);
            }
            else
            {
                // Lülita muusika välja
                // Näiteks: MusicPlayer.Stop();
                SetMusicState(false);
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
                SetDarkModeState(true);
            }
            else
            {
                // Lülita hele reþiim sisse
                App.Current.UserAppTheme = AppTheme.Light;
                SetDarkModeState(false);
            }
        }

        // Tagasi nupu käsitsemine
        private async void OnBackButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GamePage());
        }

        // Salvesta muusika olek
        private void SetMusicState(bool state)
        {
            // Salvesta muusika olek, kas andmebaasi, faili või muusse salvestuskohta
            // Näiteks: Application.Current.Properties["IsMusicOn"] = state;
        }

        // Lae muusika olek
        private bool IsMusicOn()
        {
            // Lae muusika olek, kas andmebaasist, failist või muust salvestuskohtast
            // Näiteks: return Application.Current.Properties.ContainsKey("IsMusicOn") ? (bool)Application.Current.Properties["IsMusicOn"] : false;
            return false; // Ajutine väärtus, kui andmeid pole
        }

        // Salvesta tumeda reþiimi olek
        private void SetDarkModeState(bool state)
        {
            // Salvesta tumeda reþiimi olek, kas andmebaasi, faili või muusse salvestuskohta
            // Näiteks: Application.Current.Properties["IsDarkModeOn"] = state;
        }

        // Lae tumeda reþiimi olek
        private bool IsDarkModeOn()
        {
            // Lae tumeda reþiimi olek, kas andmebaasist, failist või muust salvestuskohtast
            // Näiteks: return Application.Current.Properties.ContainsKey("IsDarkModeOn") ? (bool)Application.Current.Properties["IsDarkModeOn"] : false;
            return false; // Ajutine väärtus, kui andmeid pole
        }
    }
}
