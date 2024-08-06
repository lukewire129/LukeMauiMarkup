namespace LukeMauiMarkup.Extentions;

public static class LukePopupPageExtentions
{

    public static LukePopupPage ContentBackground(this LukePopupPage lukePopupPage, Color color)
    {
        lukePopupPage.ForegroundColor = color;
        return lukePopupPage;
    }
}
