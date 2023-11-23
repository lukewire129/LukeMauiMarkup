using LukeMauiMarkup.Init.ViewModels;

namespace LukeMauiMarkup.Init.Views
{
    public partial class MainPage : LukeContentPage
    {
        public MainPage(MainViewModel viewModel)
        {
            BindingContext = viewModel;
            Build ();
        }

        public override void Build()
        {
            Content = new ScrollView ()
            {
                Content = new Grid ()
                {
                    ColumnDefinitions = Columns.Define (Star, 40),
                    RowDefinitions = Rows.Define (Star, 40),
                    Children =
                    {
                        new StackLayout ()
                        {
                            Spacing = 25,
                            Children =
                            {

                            }
                        }
                        .Padding (30)
                        .Row(0)
                        .BackgroundColor(Colors.Red),

                        new StackLayout ()
                        {
                            Spacing = 25,
                            Children =
                            {

                            }
                        }
                        .Padding (30)
                        .Row(1)
                        .BackgroundColor(Colors.Blue),
                    }
                }
            };
        }
    }
}
