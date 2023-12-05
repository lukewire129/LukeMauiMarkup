using Login.Features.Login.Pages;
namespace Login;

public partial class App : Application
{
    public App()
    {
        InitializeComponent ();

        MainPage = new NavigationPage (new LoginPage());
    }
}
