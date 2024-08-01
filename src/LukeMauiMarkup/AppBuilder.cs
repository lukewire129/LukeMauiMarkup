using CommunityToolkit.Maui.Markup;

namespace LukeMauiMarkup
{
    public static class AppBuilder
    {
        public static MauiAppBuilder UseLukeMauiMarkup(this MauiAppBuilder builder)
        {
            builder.UseMauiCommunityToolkitMarkup ();
            // C# Hot Reload Handler
            builder.Services.AddSingleton<ICommunityToolkitHotReloadHandler, HotReloadHandler> ();
            return builder;
        }
    }
}