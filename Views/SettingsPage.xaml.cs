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

        // Muusika sisse v�i v�lja l�litamine
        private void ToggleMusicSwitch_Toggled(object sender, ToggledEventArgs e)
        {
            bool musicOn = e.Value;
            if (musicOn)
            {
                // L�lita muusika sisse
                // N�iteks: MusicPlayer.Play();
                SetMusicState(true);
            }
            else
            {
                // L�lita muusika v�lja
                // N�iteks: MusicPlayer.Stop();
                SetMusicState(false);
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
                SetDarkModeState(true);
            }
            else
            {
                // L�lita hele re�iim sisse
                App.Current.UserAppTheme = AppTheme.Light;
                SetDarkModeState(false);
            }
        }

        // Tagasi nupu k�sitsemine
        private async void OnBackButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GamePage());
        }

        // Salvesta muusika olek
        private void SetMusicState(bool state)
        {
            // Salvesta muusika olek, kas andmebaasi, faili v�i muusse salvestuskohta
            // N�iteks: Application.Current.Properties["IsMusicOn"] = state;
        }

        // Lae muusika olek
        private bool IsMusicOn()
        {
            // Lae muusika olek, kas andmebaasist, failist v�i muust salvestuskohtast
            // N�iteks: return Application.Current.Properties.ContainsKey("IsMusicOn") ? (bool)Application.Current.Properties["IsMusicOn"] : false;
            return false; // Ajutine v��rtus, kui andmeid pole
        }

        // Salvesta tumeda re�iimi olek
        private void SetDarkModeState(bool state)
        {
            // Salvesta tumeda re�iimi olek, kas andmebaasi, faili v�i muusse salvestuskohta
            // N�iteks: Application.Current.Properties["IsDarkModeOn"] = state;
        }

        // Lae tumeda re�iimi olek
        private bool IsDarkModeOn()
        {
            // Lae tumeda re�iimi olek, kas andmebaasist, failist v�i muust salvestuskohtast
            // N�iteks: return Application.Current.Properties.ContainsKey("IsDarkModeOn") ? (bool)Application.Current.Properties["IsDarkModeOn"] : false;
            return false; // Ajutine v��rtus, kui andmeid pole
        }
    }
}
