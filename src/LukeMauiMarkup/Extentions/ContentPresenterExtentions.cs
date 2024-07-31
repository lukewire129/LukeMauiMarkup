namespace LukeMauiMarkup.Extentions;

public static class ContentPresenterExtentions
{
    public static T Content<T>(this T self,
            Microsoft.Maui.Controls.View content)
            where T : Microsoft.Maui.Controls.ContentPresenter
    {
        self.SetValue (Microsoft.Maui.Controls.ContentPresenter.ContentProperty, content);
        return self;
    }

    public static T Content<T>(this T self,
        Func<Microsoft.Maui.Controls.View> configure)
        where T : Microsoft.Maui.Controls.ContentPresenter
    {
        var content = configure ();
        self.SetValue (Microsoft.Maui.Controls.ContentPresenter.ContentProperty, content);
        return self;
    }
}
