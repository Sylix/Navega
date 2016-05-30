using Xamarin.Forms;

namespace Navega
{
    public partial class NavegaPage : ContentPage
    {
        public NavegaPage ()
        {
            InitializeComponent ();

            //switch (Device.OS)
            //{
            //    case TargetPlatform.Android:
            //        MainLayout.Padding = new Thickness(16);
            //        break;
            //    case TargetPlatform.iOS:
            //        MainLayout.Padding = new Thickness(0, 20, 0, 0);
            //        break;
            //    case TargetPlatform.Windows:
            //        MainLayout.Padding = new Thickness(20);
            //        break;
            //    case TargetPlatform.WinPhone:
            //        MainLayout.Padding = new Thickness(12, 8);
            //        break;
            //}

            //Informacao.Text = Device.OnPlatform("Estou no iOS", "Estou no Android", "Estou no Windows");

            //Retangulo.BackgroundColor = Device.OnPlatform(Color.Fuchsia, Color.Green, Color.Blue);
        }
    }
}