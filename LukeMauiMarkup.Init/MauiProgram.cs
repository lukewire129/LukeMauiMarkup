using Microsoft.Extensions.Logging;
using LukeMauiMarkup;
namespace CommunityToolkitMarkup.HotReloadSample;

public static partial class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder ();
        builder.UseMauiApp<App> ()
               .UseLukeMauiMarkup ()
               .ConfigureFonts (fonts =>
               {
                   fonts.AddFont ("OpenSans-Regular.ttf", "OpenSansRegular");
                   fonts.AddFont ("OpenSans-SemiBold.ttf", "OpenSansSemiBold");
               });

        builder.Services.AddSingleton (SemanticScreenReader.Default);
        builder.Services.AddSingleton<MainViewModel> ();
        builder.Services.AddSingleton<MainPage> ();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build ();
    }
}
