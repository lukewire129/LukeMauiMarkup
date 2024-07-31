namespace LukeMauiMarkup.Extentions;

public static class GridExtentions
{
    public static T ColumnDefinitions<T>(
              this T self,
              ColumnDefinitionCollection? Define = null) where T : Grid, IGridLayout
    {

        self.ColumnDefinitions = Define;
        return self;
    }

    public static T ColumnDefinitions<T>(
              this T self,
              params GridLength[] widths) where T : Grid, IGridLayout
    {
        var columnDefinitions = new ColumnDefinitionCollection ();

        for (int i = 0; i < widths.Length; i++)
        {
            columnDefinitions.Add (new ColumnDefinition { Width = widths[i] });
        }
        self.ColumnDefinitions = columnDefinitions;
        return self;
    }

    public static T RowDefinitions<T>(
      this T self,
      RowDefinitionCollection? Define = null) where T : Grid, IGridLayout
    {

        self.RowDefinitions = Define;
        return self;
    }

    public static T RowDefinitions<T>(
              this T self,
              params GridLength[] heights) where T : Grid, IGridLayout
    {
        var rowDefinitions = new RowDefinitionCollection ();

        for (int i = 0; i < heights.Length; i++)
        {
            rowDefinitions.Add (new RowDefinition { Height = heights[i] });
        }
        self.RowDefinitions = rowDefinitions;
        return self;
    }
}
