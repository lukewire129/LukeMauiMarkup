using Login.Features.Signup.Services;

namespace Login.Features.Login.Pages;

public partial class LoginPhoneEmailViewModel : LukeViewModel
{
    public LoginPhoneEmailViewModel()
    {
    }

    [RelayCommand]
    private void SignUp()
    {
        IPlatformApplication.Current.Services.GetService<SignupService> ().Next ();
    }

    [RelayCommand]
    private void ForgetPassword()
    {
        // this.Push ();
    }
}