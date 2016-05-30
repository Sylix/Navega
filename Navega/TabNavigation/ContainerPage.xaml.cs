using Xamarin.Forms;

namespace Navega.TabNavigation
{
    public partial class TabNavigationPage : TabbedPage
    {
        public TabNavigationPage ()
        {
            NavigationPage.SetBackButtonTitle (this, string.Empty);

            InitializeComponent ();

            Children.Add (new NavigationPage (new FirstPage ()));
        }
    }
}