﻿namespace LukeMauiMarkup;

public class VStack : VerticalStackLayout
{
    public VStack()
    {

    }
    public VStack(IView[] views)
    {
        this.Children.Clear ();
        foreach(var view in views)
        {
            this.Children.Add (view);
        }
    }
}
