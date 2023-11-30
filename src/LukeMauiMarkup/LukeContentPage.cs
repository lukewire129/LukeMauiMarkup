namespace LukeMauiMarkup
{
    public abstract class LukeContentPage : ContentPage, ILukePage
    {
        public LukeContentPage()
        {
            this.Build ();
        }
        public abstract void Build();
    }
}
