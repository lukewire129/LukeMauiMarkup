namespace LukeMauiMarkup;
public class HStack : HorizontalStackLayout
{
    public HStack()
    {

    }
    public HStack(IView[] views)
    {
        this.Children.Clear ();
        foreach (var view in views)
        {
            this.Children.Add (view);
        }
    }
}
