using Login.Features.Common;
using Login.Features.Signup.Models;
using Login.Features.Signup.Pages;

namespace Login.Features.Signup.Services;

public class SignupService
{
    private Dictionary<int, PageContainer> pageContainers = new();
    private int idx = 0;
    private UserModel model;
    public SignupService()
    {
        model = new ();
        pageContainers = new Dictionary<int, PageContainer>()
        {
            {0, new PageContainer(new SignupPage(), new SignupViewModel()) },
            {1, new PageContainer(new UserSignPage(), new UserSignViewModel()) },
        };
    }

    public async void Next()
    {
        await Application.Current.MainPage.Navigation.PushAsync(pageContainers[idx].Page, true);
        idx += 1;
    }

    public async void PreNext()
    {
        if (idx == 0)
            return;
        idx -= 1;
    }
    public void PhoneNumber(string phoneNumber)
    {
        model.PhoneNumber = phoneNumber;
    }
}