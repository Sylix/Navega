using Xamarin.Forms;

namespace Navega.Tabs
{
    public partial class ContainerPage : TabbedPage
    {
        public ContainerPage ()
        {
            InitializeComponent ();

            Children.Add (new TabTwoPage ());
        }
    }
}