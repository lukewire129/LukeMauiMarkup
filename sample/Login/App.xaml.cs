using Login.Features.Login.Pages;
namespace Login;

public partial class App : Application
{
    public App()
    {
        InitializeComponent ();
        var navigationPage = new NavigationPage (new LoginPage ());
        navigationPage.BarBackgroundColor = White;
        navigationPage.BarTextColor = Black;        
        MainPage = navigationPage;
    }
}
