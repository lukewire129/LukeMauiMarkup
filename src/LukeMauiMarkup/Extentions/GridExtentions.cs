using Microsoft.Maui.Controls;

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

    public static T RowDefinitions<T>(
      this T self,
      RowDefinitionCollection? Define = null) where T : Grid, IGridLayout
    {

        self.RowDefinitions = Define;
        return self;
    }

    public static T Definitions<T>(
      this T self,
      ColumnDefinitionCollection? columnDefine = null,
      RowDefinitionCollection? rowDefine = null) where T : Grid, IGridLayout
    {
        self.ColumnDefinitions = columnDefine;
        self.RowDefinitions = rowDefine;
        return self;
    }
}
