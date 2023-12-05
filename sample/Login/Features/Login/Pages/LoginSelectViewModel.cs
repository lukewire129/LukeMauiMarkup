namespace Login.Features.Login.Pages;

public partial class LoginSelectViewModel : LukeViewModel
{
    /// <summary>
    /// 휴대폰/이메일로 시작하기
    /// </summary>
    [RelayCommand]
    private void GoPhoneEmailLogin()
    {
        this.PopModal (false);
        this.Push (new LoginPhoneEmailPage ()
        {

        });
    }

    [RelayCommand]
    private void Back()
    {
        this.PopModal (false);
    }
}
