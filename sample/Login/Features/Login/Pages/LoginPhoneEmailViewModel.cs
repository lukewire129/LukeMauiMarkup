using Maui.FreakyControls;

namespace Login.Features.Login.Pages;

public partial class LoginPhoneEmailViewModel : LukeViewModel
{
    [RelayCommand]
    private void SignUp()
    {
        this.Push (new LoginSignupPage());
    }

    [RelayCommand]
    private void ForgetPassword()
    {
        // this.Push ();
    }
}