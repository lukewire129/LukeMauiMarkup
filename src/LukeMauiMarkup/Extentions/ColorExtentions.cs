namespace LukeMauiMarkup.Extentions;

public static class ColorExtentions
{

    public static Color ColorHex(this VisualElement element, string colorAsHex)
    {
        if(colorAsHex[0] != '#')
        {
            colorAsHex = $"#{colorAsHex}";
        }
        return Color.FromArgb (colorAsHex);
    }
}
