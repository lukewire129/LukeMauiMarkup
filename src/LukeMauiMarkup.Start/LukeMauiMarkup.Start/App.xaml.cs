using LukeMauiMarkup.Start.Pages;

namespace LukeMauiMarkup.Start
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
