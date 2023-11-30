namespace Login.Features.Login.Pages;

public class LoginSelectPage : LukePopupPage
{
    public LoginSelectPage()
    {
        this.ContentBackground (Colors.White);
        this.HorizontalOptions = LayoutOptions.Fill;
        this.VerticalOptions = LayoutOptions.End;
    }
    public override void Build()
    {
        this.Content = new Grid ()
        {
            RowDefinitions = Rows.Define(Auto, 10, Star),
            Children =
            {
                new Grid()
                {
                    Children =
                    { 
                        new Label()
                            .Text("다른 방법으로 로그인")
                            .Font(family: "NotoSansKRExtraBold", size: 20)
                            .Start(),

                    }
                }
                .Row(0),

                new VerticalStackLayout()
                {
                    Spacing =10,
                    Children =
                    {
                        new TypeLoginButton(),
                        new TypeLoginButton(),
                        new TypeLoginButton(),
                    }
                }
                .Paddings(left:20, right:20)
                .Row(2)
            }
        }
        .Height(300)
        .Paddings (left: 20, right: 20);
    }
}

public class TypeLoginButton : Button
{
    public TypeLoginButton()
    {
        this.Height (50);
    }
}