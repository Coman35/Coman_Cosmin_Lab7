﻿namespace ComanCosminLab7
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }
        private async void OnNavigateButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AboutPage()); // Navighează către AboutPage sau o altă pagină
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

          //  if (count == 1)
            //    CounterBtn.Text = $"Clicked {count} time";
           // else
             //   CounterBtn.Text = $"Clicked {count} times";

          //  SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
