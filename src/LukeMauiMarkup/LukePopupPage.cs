using MauiPopup.Views;

namespace LukeMauiMarkup;

public abstract class LukePopupPage : BasePopupPage, ILukePage
{
    public LukePopupPage()
    {
        this.Build ();
    }
    public abstract void Build();
}
