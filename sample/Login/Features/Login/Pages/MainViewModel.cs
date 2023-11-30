namespace Login.Features.Login.Pages;

public partial class MainViewModel : LukeViewModel
{
    public MainViewModel()
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
