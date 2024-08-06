using Foundation;

namespace TestHotReload
{
    [Register ("AppDelegate")]
    public class AppDelegate : MauiUIApplicationDelegate
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp ();
    }
}
