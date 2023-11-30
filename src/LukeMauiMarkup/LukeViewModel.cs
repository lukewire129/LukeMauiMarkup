using CommunityToolkit.Mvvm.ComponentModel;

namespace LukeMauiMarkup;

public partial class LukeViewModel : ObservableObject
{
    public LukeViewModel()
    {

    }

    protected void Push(Page page, bool animated = false)
    {
        Application.Current.MainPage.Navigation.PushAsync (page, animated);
    }

    protected void PushModal(Page page, bool animated = false)
    {
        Application.Current.MainPage.Navigation.PushModalAsync (page, animated);
    }

    protected void PopM(bool animated = false)
    {
        Application.Current.MainPage.Navigation.PopAsync (animated);
    }

    protected void PopModal(bool animated = false)
    {
        Application.Current.MainPage.Navigation.PopModalAsync (animated);
    }
}
