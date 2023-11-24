
namespace Login.UI.Views;

public class MainPage : LukeContentPage
{
    public MainPage()
    {

    }

    public override void Build()
    {
        Content = new Grid
        {
            RowDefinitions = Rows.Define(Auto, Auto),

            Children =
            {
                new Label()
                    .Text("아파트 실거래가는")
                    .TextColor(this.ColorHex("#9da2e8"))
                    .CenterHorizontal()
                    .CenterVertical(),

            }
        };
    }
}