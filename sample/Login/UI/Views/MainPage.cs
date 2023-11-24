namespace Login.UI.Views;

public class MainPage : LukeContentPage
{
    public MainPage()
    {

    }

    public override void Build()
    {
        Content = new Grid
        {
            RowDefinitions = Rows.Define(Auto, 114, Auto, 25, Auto),
            Children =
            {
                new Grid
                {
                    RowDefinitions = Rows.Define(Auto, Auto),
                    RowSpacing = 0,
                    Children =
                    {
                        new TitleLabel()
                            .Text("아파트 실거래가는", this.ColorHex ("9da2e8"))
                            .Font(size: 30)
                            .Row(0),

                        new TitleLabel()
                            .Font(size: 65, bold: true)
                            .Text("호갱노노", this.ColorHex("5d66da"))
                            .Row(1)
                    }
                }
                .Row(0),

                new VerticalStackLayout
                {
                    Spacing = 10,
                    Children =
                    {
                        new LoginButton
                        {
                            BorderWidth =0
                        }
                        .BackgroundColor(this.ColorHex("f9e001"))
                        .Text("카카오톡으로 시작하기", this.ColorHex("3c1e1e"))
                        .Font(size:18, bold: true),

                        new LoginButton
                        {
                            BorderWidth = 1.2
                        }
                        .BackgroundColor(Colors.Transparent)                        
                        .Text("다른 방법으로 시작하기", this.ColorHex("4c4c4c"))
                        .Font(size:18, bold: true)
                    }
                }
                .Row(2),

                new Label()
                    .Text("로그인하지 않고 둘러보기", this.ColorHex("a3a5af"))
                    .Font(size:15)
                    .CenterHorizontal()
                    .Row(4)
            }
        }
        .CenterHorizontal ()
        .BackgroundColor(Colors.White)
        .Margins(top:140D);
    }
}

public class TitleLabel : Label
{
    public TitleLabel()
    {
        this.CenterHorizontal ()
            .CenterVertical ();
    }
}

public class LoginButton : Button
{
    public LoginButton()
    {
        this.Size (337, 68);
    }
}