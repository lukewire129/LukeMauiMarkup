namespace LukeMauiMarkup.Exentions
{
    public static class StackLayoutExtention
    {
        public static TVisualElement Spacing<TVisualElement>(
                   this TVisualElement element,
                   double? Spacing = null) where TVisualElement : Layout, IStackLayout
        {

            if (Spacing != null)
            {
                element.SetValue (StackBase.SpacingProperty, Spacing.Value);
            }
            else
            {
                element.SetValue (StackBase.SpacingProperty, 0);
            }
            return element;
        }
    }
}
