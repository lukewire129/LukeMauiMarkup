namespace Login.Features.Login.Pages;

public class LoginSelectPage : LukePopupPage
{
    public LoginSelectPage()
    {
        this.ContentBackground (White);
        this.HorizontalOptions = LayoutOptions.Fill;
        this.VerticalOptions = LayoutOptions.End;
    }
    public override void Build()
    {
        this.Content = new Grid ()
        {
            RowDefinitions = Rows.Define (Auto, 37, Star),
            Children =
            {
                new Grid()
                {
                    Children =
                    {
                        new Label()
                            .Text("다른 방법으로 로그인", Colors.Black)
                            .Font(family: "NotoSansKRExtraBold", size: 20)
                            .Start(),
                    }
                }
                .Row(0),

                new VStack()
                {
                    Spacing = 11,
                    Children =
                    {
                        new Grid()
                        {
                            ColumnDefinitions = Columns.Define (30, Star),
                            Children =
                            {
                                new Button()
                                    .Height(66)
                                    .ColumnSpan(2)
                                    .BackgroundColor(this.ColorHex("564ddb"))
                                    .Font("NotoSansKRMedium", 18)
                                    .Text("휴대전화/이메일로 시작하기", White)
                                    .BindCommand("GoPhoneEmailLoginCommand"),

                                new Grid()
                                    .Column(0)
                            }
                        }
                        .Paddings(20,0,20,0),

                        new Grid()
                        {
                            ColumnDefinitions = Columns.Define (30, Star),
                            Children =
                            {
                                new Button()
                                    .Height(66)
                                    .ColumnSpan(2)
                                    .BackgroundColor(this.ColorHex("3976ea"))
                                    .Font("NotoSansKRMedium", 18)
                                    .Text("페이스북으로 시작하기", White),

                                new Grid()
                                    .Column(0)
                            }
                        }
                        .Paddings(20,0,20,0),

                        new Grid()
                        {
                            ColumnDefinitions = Columns.Define (30, Star),
                            Children =
                            {
                                new Button()
                                    .Height(66)
                                    .ColumnSpan(2)
                                    .BackgroundColor(Colors.White)
                                    .Border(Width:1.2, Corner:5, Color:Colors.Black)
                                    .Font("NotoSansKRMedium", 18)
                                    .Text("Apple로 시작하기", Colors.Black),

                                new Grid()
                                    .Column(0)                                    
                            }
                        }
                        .Paddings(20,0,20,0),

                    }
                }
                .Paddings(left:20, right:20)
                .Row(2)
            }
        }
        .Height (369)
        .Paddings (left: 20, right: 20, top: 20);
    }
}