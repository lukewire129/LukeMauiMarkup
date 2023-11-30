using System.Runtime.CompilerServices;

namespace LukeMauiMarkup.Exentions;

public static class LukePopupPageExtentions
{

    public static void ContentBackground(this LukePopupPage lukePopupPage, Color color)
    {
        lukePopupPage.ForegroundColor = color;
    }
}
