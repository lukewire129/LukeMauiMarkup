namespace LukeMauiMarkup.Exentions
{
    public static class BorderExtentions
    {
        public static TVisualElement Border<TVisualElement>(
            this TVisualElement element, 
            double? Width = null, 
            int? Corner = 0, 
            Color? Color = null) where TVisualElement : View , IBorderElement
        {
            if(element is RadioButton rb)
            {
                if (Width != null)
                {
                    element.SetValue (RadioButton.BorderWidthProperty, Width.Value);
                }
                else
                {
                    element.SetValue (RadioButton.BorderWidthProperty, 0);
                }

                if (Corner != null)
                {
                    element.SetValue (RadioButton.CornerRadiusProperty, Corner.Value);
                }
                else
                {
                    element.SetValue (RadioButton.CornerRadiusProperty, 0);
                }

                if (Color != null)
                {
                    element.SetValue (RadioButton.BorderColorProperty, Color);
                }
                else
                {
                    element.SetValue (RadioButton.BorderColorProperty, Colors.Transparent);
                }
            }
            else if (element is IButton)
            {
                if (Width != null)
                {
                    element.SetValue (Button.BorderWidthProperty, Width.Value);
                }
                else
                {
                    element.SetValue (Button.BorderWidthProperty, 0);
                }
                if (Corner != null)
                {
                    element.SetValue (Button.CornerRadiusProperty, Corner.Value);
                }
                else
                {
                    element.SetValue (Button.CornerRadiusProperty, 0);
                }

                if (Color != null)
                {
                    element.SetValue (Button.BorderColorProperty, Color);
                }
                else
                {
                    element.SetValue (Button.BorderColorProperty, Colors.Transparent);
                }
            }
            
            return element;
        }
    }
}
