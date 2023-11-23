namespace LukeMauiMarkup.Init.Views
{
    internal class ChildrenPage : LukeContentPage
    {
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
