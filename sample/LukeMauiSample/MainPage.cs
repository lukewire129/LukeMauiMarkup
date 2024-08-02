using CommunityToolkit.Maui.Markup;
using LukeMauiMarkup;
using LukeMauiMarkup.Attributes;
using LukeMauiSample.ViewModels;


namespace LukeMauiSample
{
    [ContextAttribute (typeof(MainPageViewModel))]
    public class MainPage : LukeContentPage
    {
        public override void Build()
        {
            Content = new Grid()
            {
                Children =
                {
                    new Label()
                    .Text("Welcome to .NET MAUI!!!")
                    .TextColor(Colors.Blue)
                    .CenterHorizontal()
                    .CenterVertical(),
                }
            }
            .BackgroundColor(Colors.Red);
        }
    }
}
