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

        private Label ClicksLabel;
        private ListView UpgradesList;

        public ShopPage(int currentClicks)
        {
            InitializeUI(); // Initialize UI elements
            clicks = currentClicks;
            UpdateUI();
        }

        private void InitializeUI()
        {
            // Create ClicksLabel
            ClicksLabel = new Label
            {
                Text = "You have 0 clicks."
            };

            // Create UpgradesList
            UpgradesList = new ListView
            {
                ItemsSource = upgrades.Keys // Only display upgrade names
            };

            // Event handlers
            UpgradesList.ItemTapped += OnBuyClicked; // You can handle item tap to buy upgrades

            // Add UI elements to the content
            Content = new StackLayout
            {
                Children = { ClicksLabel, UpgradesList }
            };
        }

        private void UpdateUI()
        {
            ClicksLabel.Text = $"You have {clicks} clicks.";
        }

        private void OnBuyClicked(object sender, ItemTappedEventArgs e)
        {
            var selectedItem = e.Item as string;
            if (selectedItem != null && upgrades.ContainsKey(selectedItem))
            {
                var upgradeCost = upgrades[selectedItem];
                if (upgradeCost <= clicks)
                {
                    clicks -= upgradeCost;
                    DisplayAlert("Purchase Successful", $"{selectedItem} purchased successfully.", "OK");
                    UpdateUI();
                }
                else
                {
                    DisplayAlert("Insufficient Clicks", "You don't have enough clicks to purchase this upgrade.", "OK");
                }
            }
        }
    }
}
