namespace Login.Features.Login.Pages;

public class LoginPage : LukeContentPage
{
    public LoginPage()
    {
        this.BindingContext = new LoginViewModel ();
    }

    public override void Build()
    {
        Content = new Grid
        {
            RowDefinitions = Rows.Define (100, Auto, 55, Auto, 20, Auto),
            Children =
            {
                new Grid
                {
                    Children =
                    {
                        new TitleLabel()
                            .Text("아파트 실거래가는", this.ColorHex ("9da2e8"))
                            .Font(size: 30, family:"NotoSansKRRegular")
                            .ZIndex(1)
                            .Margins(top: -100),

                        new TitleLabel()
                            .Text("호갱노노", this.ColorHex("5d66da"))
                            .Font(size: 63, family:"NotoSansKRBold")
                    }
                }
                .Row(1),
                new VStack
                {
                    Spacing = 10,
                    Children =
                    {
                        new LoginButton()
                        .BackgroundColor(this.ColorHex("f9e001"))
                        .Text("카카오톡으로 시작하기", this.ColorHex("3c1e1e"))
                        .Font(size:18, bold: true)
                        .Border(Corner:5),

                        new LoginButton()
                        .Border(Width:1.2, Corner:5, this.ColorHex("dcdce4"))
                        .BackgroundColor(Transparent)
                        .Text("다른 방법으로 시작하기", this.ColorHex("4c4c4c"))
                        .Font(size:18, bold: true)
                    }
                }
                .Row(3),

                new Label()
                {
                    TextDecorations = TextDecorations.Underline
                }
                .Text("로그인하지 않고 둘러보기", this.ColorHex("a3a5af"))
                .Font(size:15)
                .CenterHorizontal()
                .Row(5)
                .BindTapGesture("LoginCommand")
            }
        }
        .BackgroundColor(White);
    }
}

public class TitleLabel : Label
{
    public TitleLabel()
    {
        this.CenterHorizontal()
            .CenterVertical();
    }
}

public class LoginButton : Button
{
    public LoginButton()
    {
        FontFamily = "NotoSansKRRegular";
        this.Size(337, 68)
            ;
    }
}