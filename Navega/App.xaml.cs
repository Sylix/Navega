using Navega.NavigationTab;
using Xamarin.Forms;

namespace Navega
{
    public partial class App : Application
    {
        public App ()
        {
            InitializeComponent ();

            MainPage = new NavegaPage ();
            //MainPage = new NavigationPage (new FirstPage ());

            //MainPage = new Tabs.ContainerPage ();
            //MainPage = new TabNavigationPage ();
            //MainPage = new NavigationPage (new NavigationTabPage());

            //var nav = new NavigationPage(new NavigationTabPage());
            //if (Device.OS == TargetPlatform.iOS)
            //{
            //    nav.BarBackgroundColor = Color.FromHex("2196F3");
            //    nav.BarTextColor = Color.White;
            //}

            //MainPage = nav;

        }

        protected override void OnStart ()
        {
            // Handle when your app starts
        }

        protected override void OnSleep ()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume ()
        {
            // Handle when your app resumes
        }
    }
}