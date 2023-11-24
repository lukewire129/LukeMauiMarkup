using Login.UI.Views;
namespace Login;

public partial class App : Application
{
    public App()
    {
        InitializeComponent ();

        MainPage = new NavigationPage (new MainPage());
    }
}
