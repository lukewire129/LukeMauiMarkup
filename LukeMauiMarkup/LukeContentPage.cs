namespace LukeMauiMarkup
{
    public abstract class LukeContentPage : ContentPage
    {
        public void Reload()
        {
            MainThread.BeginInvokeOnMainThread (() =>
            {
                Build ();
            });
        }
        public abstract void Build();
    }
}
