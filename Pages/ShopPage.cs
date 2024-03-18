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

        public ShopPage(int currentClicks)
        {
            InitializeComponent();
            clicks = currentClicks;
            UpdateUI();
        }

        private void UpdateUI()
        {
            ClicksLabel.Text = $"You have {clicks} clicks.";

            UpgradesList.ItemsSource = upgrades;
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
