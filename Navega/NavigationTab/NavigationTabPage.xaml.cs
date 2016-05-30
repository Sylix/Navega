using Xamarin.Forms;

namespace Navega.NavigationTab
{
    public partial class NavigationTabPage : TabbedPage
    {
        public NavigationTabPage ()
        {
            NavigationPage.SetBackButtonTitle (this, string.Empty);

            InitializeComponent ();
        }
    }
}