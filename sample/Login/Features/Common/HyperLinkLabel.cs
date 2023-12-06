namespace Login.Features.Common;

public class HyperLinkLabel : Label
{
    public HyperLinkLabel()
    {
        this.TextDecorations = TextDecorations.Underline;
        this.TextColor (this.ColorHex("a3a5af"))
            .Font (size: 15);
    }
}