namespace Login.Features.Login.Pages;

public class LoginPhoneEmailPage : LukeContentPage
{
    public override void Build()
    {
        this.Content = new VStack ()
        {
            new Grid
            {
                Children =
                {
                    new BoxView()
                    {
                    },

                    new Editor()
                        .Placeholder("휴대전화번호 또는 이메일")
                        .PlaceholderColor(this.ColorHex("888b97")),
                    }
            }.Width(this.Width)
        }
        .BackgroundColor (White);
    }
}