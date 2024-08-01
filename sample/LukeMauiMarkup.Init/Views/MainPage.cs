using LukeMauiMarkup.Init.ViewModels;
using LukeMauiMarkup.Extentions;
namespace LukeMauiMarkup.Init.Views;

public partial class MainPage : LukeContentPage
{
    public MainPage(MainViewModel viewModel)
    {
        BindingContext = viewModel;
    }

    public override void Build()
    {
        this.Content (
            new ScrollView ()
                .Content (
                    new Grid ()
                        .ColumnDefinitions (Star, 40)
                        .RowDefinitions (Star, 40)
                        .Children(
                            new StackLayout ()
                                .Padding (30)
                                .Row (0)
                                .BackgroundColor (Colors.Blue)
                                .Spacing (25)
                                .Children(
                                    NavigationButton(),
                                    NavigationButton()
                                ),

                            new StackLayout ()
                                .Spacing(25)
                                .Padding (30)
                                .Row (1)
                                .BackgroundColor (Colors.Blue)
                        )
                )
        );
    }

    private Button NavigationButton() => new Button ()
                                            .Size (100, 70)
                                            .Text ("Navigation")
                                            .TapGesture (() =>
                                            {
                                                Navigation.PushAsync (new ChildrenPage ());
                                            });
}
