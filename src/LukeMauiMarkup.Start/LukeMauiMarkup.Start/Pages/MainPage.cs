namespace LukeMauiMarkup.Start.Pages;

internal class MainPage : LukeContentPage
{
    public override void Build()
        => this.Content (
                new Grid()
                    .RowDefinitions(Auto, Star)
                    .Children(
                        new Label()
                            .Text("Hello LukeMauiMarkup"),

                        new Label ()
                            .Row(1)
                            .Text ("Hello LukeMauiMarkup")
                    )
                .CenterVertical()
                .CenterHorizontal()
             );
}
