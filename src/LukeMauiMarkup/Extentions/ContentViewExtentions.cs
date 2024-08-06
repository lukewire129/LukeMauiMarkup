namespace LukeMauiMarkup.Extentions;

public static class ContentViewExtentions
{
    public static T Content<T>(this T self,
            Microsoft.Maui.Controls.View content)
            where T : Microsoft.Maui.Controls.View
    {
        self.SetValue (Microsoft.Maui.Controls.ContentView.ContentProperty, content);
        return self;
    }

    public static T Content<T>(this T self,
        Func<Microsoft.Maui.Controls.View> configure)
        where T : Microsoft.Maui.Controls.ContentView
    {
        var content = configure ();
        self.SetValue (Microsoft.Maui.Controls.ContentView.ContentProperty, content);
        return self;
    }
}
