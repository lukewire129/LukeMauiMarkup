using Login.Features.Common;
using Login.Features.Signup.Pages;

namespace Login.Features.Signup.Services;

public class SignupService
{
    private Dictionary<int, PageContainer> pageContainers = new();
    private int idx = 0;
    public SignupService()
    {
        pageContainers = new Dictionary<int, PageContainer>()
        {
            {0, new PageContainer(new SignupPage(), new SignupViewModel()) },
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
}