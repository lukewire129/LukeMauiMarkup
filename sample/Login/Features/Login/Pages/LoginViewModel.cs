namespace Login.Features.Login.Pages;

public partial class LoginViewModel : LukeViewModel
{
    public LoginViewModel()
    {

    }

    [RelayCommand]
    private void Login()
    {
        this.PushModal (new LoginSelectPage ()
        {
            BindingContext = new LoginSelectViewModel()
        }, true);
    }
}
