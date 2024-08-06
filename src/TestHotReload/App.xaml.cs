using TestHotReload.Pages;

namespace TestHotReload
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent ();

            MainPage = new MainPage ();
        }
    }
}
