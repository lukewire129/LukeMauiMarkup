namespace LukeMauiMarkup
{
    public abstract class LukeContentPage : ContentPage
    {
        public LukeContentPage()
        {
            this.Build ();
        }
        public abstract void Build();
    }
}
