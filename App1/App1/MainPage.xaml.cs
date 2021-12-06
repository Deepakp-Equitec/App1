using App1.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
     
        private async void barChartonclicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new barchart()));
        }

        private async void lineChartonclicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new linechart()));

        }

        private async void pieChartonclicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new piechart()));
        }
    }
    

    
}