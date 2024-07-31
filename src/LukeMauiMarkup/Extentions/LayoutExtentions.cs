namespace LukeMauiMarkup.Extentions;

public static class LayoutExtentions
{
    public static T Children<T>(this T self, IList<Microsoft.Maui.IView> children)
                         where T : Layout
    {
        foreach (var item in children)
            self.Children.Add (item);
        return self;
    }

    public static T Children<T>(this T self, params Microsoft.Maui.IView[] children)
        where T : Layout
    {
        foreach (var item in children)
            self.Children.Add (item);
        return self;
    }

    public static T Children<T>(this T self,  Func<Microsoft.Maui.IView[]> configure)
        where T : Layout
    {
        var children = configure ();
        foreach (var item in children)
            self.Children.Add (item);
        return self;
    }
}
