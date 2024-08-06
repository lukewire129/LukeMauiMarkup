using Login.Features.Signup.Services;
using MauiIcons.Cupertino;
#if DEBUG
using Microsoft.Extensions.Logging;
#endif
using UraniumUI;

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
                .UseUraniumUI ()
                .UseUraniumUIMaterial ()
                .UseCupertinoMauiIcons()
                .ConfigureFonts (fonts =>
                {
                    fonts.AddFont ("DoHyeon-Regular.ttf", "DoHyeonRegular");
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
            builder.Services.AddSingleton<SignupService> ();
            return builder.Build ();
        }
    }
}
