using System;

using Xamarin.Forms;

namespace Navega
{
    public partial class FirstPage : ContentPage
    {
        public FirstPage ()
        {
            InitializeComponent ();

            NavigationPage.SetBackButtonTitle (this, string.Empty);
        }

        private async void SalvarItem_OnClicked (object sender, EventArgs e)
        {
            await Navigation.PushAsync (new SecondPage ());
        }
    }
}