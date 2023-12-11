using Login.Features.Signup.Services;

namespace Login.Features.Signup.Common;

public partial class SingupBaseViewModel : LukeViewModel
{
    public void NextStep()
    {
        IPlatformApplication.Current.Services.GetService<SignupService> ().Next ();
    }

    public void PreNextStep()
    {
        IPlatformApplication.Current.Services.GetService<SignupService> ().PreNext ();
    }
}
