namespace LukeMauiMarkup
{
    public partial class Grid : Microsoft.Maui.Controls.Grid
    {
        public Grid(IView[] views) : base()
        {
            this.Children.Clear ();
            foreach (var view in views)
            {
                this.Children.Add (view);
            }
        }
    }
}
