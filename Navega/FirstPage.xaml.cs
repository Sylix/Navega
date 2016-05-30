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

        private async void Add_OnClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new SecondPage();
            //await Navigation.PushAsync (new SecondPage ());
        }
    }
}