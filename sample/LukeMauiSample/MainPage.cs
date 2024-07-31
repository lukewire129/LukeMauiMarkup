using CommunityToolkit.Maui.Markup;
using LukeMauiMarkup;


namespace LukeMauiSample
{
    public class MainPage : LukeContentPage
    {
        public MainPage()
        {
           
        }

        public override void Build()
        {
            Content = new Grid(
                            
                        )
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
