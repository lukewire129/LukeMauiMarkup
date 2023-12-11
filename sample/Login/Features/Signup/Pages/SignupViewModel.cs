using Login.Features.Signup.Common;
using Login.Features.Signup.Models;

namespace Login.Features.Signup.Pages;

public partial class SignupViewModel : SingupBaseViewModel
{
    public SignupViewModel()
    {
    }

    [RelayCommand]
    private void UserInformation(UserModel user)
    {
        this.NextStep ();
    }

    [RelayCommand]
    private void Back()
    {
        this.PopModal (false);
    }
}