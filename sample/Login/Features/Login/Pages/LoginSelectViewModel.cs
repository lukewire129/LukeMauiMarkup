namespace Login.Features.Login.Pages;

public partial class LoginSelectViewModel : LukeViewModel
{

    [RelayCommand]
    private void Back()
    {
        this.PopModal (true);
    }
}
