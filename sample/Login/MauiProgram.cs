using Microsoft.Extensions.Logging;

namespace Login
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder ();
            builder
                .UseMauiApp<App> ()
                .UseLukeMauiMarkup ()
                .ConfigureFonts (fonts =>
                {
                    fonts.AddFont ("NotoSansKR-Black.ttf", "NotoSansKRBlack");
                    fonts.AddFont ("NotoSansKR-Bold.ttf", "NotoSansKRBold");
                    fonts.AddFont ("NotoSansKR-ExtraBold.ttf", "NotoSansKRExtraBold");
                    fonts.AddFont ("NotoSansKR-ExtraLight.ttf", "NotoSansKRExtraLight");
                    fonts.AddFont ("NotoSansKR-Light.ttf", "NotoSansKRLight");
                    fonts.AddFont ("NotoSansKR-Medium.ttf", "NotoSansKRMedium");
                    fonts.AddFont ("NotoSansKR-Regular.ttf", "NotoSansKRRegular");
                    fonts.AddFont ("NotoSansKR-SemiBold.ttf", "NotoSansKRSemiBold");
                    fonts.AddFont ("NotoSansKR-Thin.ttf", "NotoSansKRThin");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build ();
        }
    }
}
