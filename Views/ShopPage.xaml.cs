using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;

namespace PokerClickerV3
{
    public partial class ShopPage : ContentPage
    {
        private int clicks = 0;
        private Dictionary<string, (int cost, int multiplier)> upgrades = new Dictionary<string, (int cost, int multiplier)>()
        {
            { "Upgrade 1", (100, 2) },
            { "Upgrade 2", (200, 4) },
            { "Upgrade 3", (300, 6) }
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

            // Add back button
            var backButton = new Button
            {
                Text = "Back"
            };
            backButton.Clicked += BackButton_Clicked;
            ((StackLayout)Content).Children.Add(backButton);
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
                var (upgradeCost, multiplier) = upgrades[selectedItem];
                if (upgradeCost <= clicks)
                {
                    clicks -= upgradeCost;
                    DisplayAlert("Purchase Successful", $"{selectedItem} purchased successfully.", "OK");
                    UpdateUI();
                    ApplyMultiplier(multiplier);
                    upgrades.Remove(selectedItem);
                    UpgradesList.ItemsSource = null;
                    UpgradesList.ItemsSource = upgrades.Keys;
                }
                else
                {
                    DisplayAlert("Insufficient Clicks", "You don't have enough clicks to purchase this upgrade.", "OK");
                }
            }
        }

        private void ApplyMultiplier(int multiplier)
        {
            clicks *= multiplier;
        }

        private async void BackButton_Clicked(object sender, EventArgs e)
        {
            // Navigeerime tagasi GamePage.xaml-le
            await Navigation.PushAsync(new GamePage());

        }
    }
}
