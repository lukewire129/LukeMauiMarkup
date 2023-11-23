using Foundation;

namespace CommunityToolkitMarkup.HotReloadSample
{
    [Register (nameof (AppDelegate))]
    public class AppDelegate : MauiUIApplicationDelegate
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp ();
    }
}
