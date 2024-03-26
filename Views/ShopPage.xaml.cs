using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;

namespace PokerClickerV3
{
    public partial class ShopPage : ContentPage
    {
        private int clicks = 0;
        private Dictionary<string, int> upgrades = new Dictionary<string, int>()
        {
            { "Upgrade 1", 100 },
            { "Upgrade 2", 200 },
            { "Upgrade 3", 300 }
            // Add more upgrades as needed
        };

        // Define ClicksLabel and UpgradesList variables
        private Label ClicksLabel;
        private ListView UpgradesList;

        public ShopPage(int currentClicks)
        {
            InitializeComponent(); // Added InitializeComponent method
            clicks = currentClicks;
            UpdateUI();
        }

        private void InitializeComponent() // Added InitializeComponent method
        {
            global::Microsoft.Maui.Controls.Xaml.Extensions.LoadFromXaml(this, typeof(ShopPage));
            ClicksLabel = this.FindByName<Label>("ClicksLabel");
            UpgradesList = this.FindByName<ListView>("UpgradesList");
        }

        private void UpdateUI()
        {
            if (ClicksLabel != null && UpgradesList != null)
            {
                ClicksLabel.Text = $"You have {clicks} clicks.";
                UpgradesList.ItemsSource = upgrades;
            }
        }

        private void OnBuyClicked(object sender, EventArgs e)
        {
            var selectedItem = (KeyValuePair<string, int>)UpgradesList.SelectedItem;

            if (selectedItem.Value <= clicks)
            {
                clicks -= selectedItem.Value;
                // Apply the purchased upgrade
                DisplayAlert("Purchase Successful", $"{selectedItem.Key} purchased successfully.", "OK");
            }
            else
            {
                DisplayAlert("Insufficient Clicks", "You don't have enough clicks to purchase this upgrade.", "OK");
            }

            UpdateUI();
        }

        private void OnBackClicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}
