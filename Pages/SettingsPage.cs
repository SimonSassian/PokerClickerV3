using Microsoft.Maui.Controls;
using System;

namespace PokerClickerV3
{
    public partial class SettingsPage : ContentPage
    {
        private bool isMusicOn = true;
        private bool isDarkMode = false;

        public SettingsPage()
        {
            InitializeComponent();
            UpdateUI();
        }

        private void UpdateUI()
        {
            MusicSwitch.IsToggled = isMusicOn;
            ThemeSwitch.IsToggled = isDarkMode;
        }

        private void OnSaveSettingsClicked(object sender, EventArgs e)
        {
            // Save settings logic here
            DisplayAlert("Settings Saved", "Your settings have been saved successfully.", "OK");
        }

        private void OnCancelClicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void OnMusicSwitchToggled(object sender, ToggledEventArgs e)
        {
            isMusicOn = e.Value;
            // Logic to turn music on or off
        }

        private void OnThemeSwitchToggled(object sender, ToggledEventArgs e)
        {
            isDarkMode = e.Value;
            // Logic to switch between dark and light themes
        }
    }
}
