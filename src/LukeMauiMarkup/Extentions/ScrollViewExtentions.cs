namespace LukeMauiMarkup.Extentions;

public static class ScrollViewExtentions
{
    public static T Content<T>(this T self,
            Microsoft.Maui.Controls.View content)
            where T : Microsoft.Maui.Controls.ScrollView
    {
        self.Content = content;
        return self;
    }

    public static T Content<T>(this T self,
        Func<Microsoft.Maui.Controls.View> configure)
        where T : Microsoft.Maui.Controls.ScrollView
    {
        var content = configure ();
        self.Content = content;
        return self;
    }
}