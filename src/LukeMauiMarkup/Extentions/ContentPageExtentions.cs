namespace LukeMauiMarkup.Extentions;

public static class ContentPageExtentions
{
    public static T Content<T>(this T self,
            Microsoft.Maui.Controls.View content)
            where T : Microsoft.Maui.Controls.ContentPage
    {
        self.SetValue (Microsoft.Maui.Controls.ContentPage.ContentProperty, content);
        return self;
    }

    public static T Content<T>(this T self,
        Func<Microsoft.Maui.Controls.View> configure)
        where T : Microsoft.Maui.Controls.ContentPage
    {
        var content = configure ();
        self.SetValue (Microsoft.Maui.Controls.ContentPage.ContentProperty, content);
        return self;
    }
    public static T Title<T>(this T self,
        string title)
        where T : Microsoft.Maui.Controls.ContentPage
    {
        self.SetValue (Microsoft.Maui.Controls.ContentPage.TitleProperty, title);
        return self;
    }
    public static T Background<T>(this T self,
         Color color)
        where T : Microsoft.Maui.Controls.ContentPage
    {
        self.SetValue(Microsoft.Maui.Controls.ContentPage.BackgroundColorProperty, color);
        return self;
    }
}
