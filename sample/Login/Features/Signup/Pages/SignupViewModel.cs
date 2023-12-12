using Login.Features.Signup.Common;
using Login.Features.Signup.Services;
using System.ComponentModel;

namespace Login.Features.Signup.Pages;

public partial class SignupViewModel : SingupBaseViewModel
{
    [ObservableProperty] string _authButtonName = "인증번호받기";
    [ObservableProperty] bool _isRequestButtonEnabled = false;

    [ObservableProperty] string _phoneNumber;
    [ObservableProperty] bool _isRequestPhoneNumber = true;

    [ObservableProperty] string _authNumber;
    [ObservableProperty] bool _isRequestAuthNumber = false;
    public SignupViewModel()
    {
    }
    int totalTimerSec = 180;
    System.Timers.Timer t;

    [RelayCommand]
    private void RequestAuth()
    {
        IsRequestAuthNumber = true;
        IsRequestPhoneNumber = false;
        IsRequestButtonEnabled = false;

        AuthButtonName = GetTimer (totalTimerSec);
        t = new System.Timers.Timer (TimeSpan.FromSeconds (1));
        t.Elapsed += (s, e) =>
        {
            totalTimerSec -=1;
            AuthButtonName = GetTimer (totalTimerSec);
            if (totalTimerSec == 0)
                t.Stop ();
        };
        t.Start ();
    }

    protected override void OnPropertyChanged(PropertyChangedEventArgs e)
    {
        base.OnPropertyChanged (e);

        if(e.PropertyName == nameof(AuthNumber))
        {
            if (AuthNumber.Length != 4)
                return;
            IPlatformApplication.Current.Services.GetService<SignupService> ().PhoneNumber (this.PhoneNumber);
            this.NextStep ();
        }
        else if(e.PropertyName == nameof(PhoneNumber))
        {
            IsRequestButtonEnabled = !String.IsNullOrEmpty (PhoneNumber);
        }
    }

    private string GetTimer(int sec)
    {
        return TimeSpan.FromSeconds (sec).ToString (@"mm\:ss");
    }
}