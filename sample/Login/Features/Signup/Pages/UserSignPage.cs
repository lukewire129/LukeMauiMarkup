using UraniumUI.Material.Controls;

namespace Login.Features.Signup.Pages;

public class UserSignPage : LukeContentPage
{
    public override void Build()
    {
        this.Title = "회원 정보 입력";
        this.Content = new VStack ()
        {
            Spacing = 60,
            Children =
            {
                new VStack(
                [
                    new TextField()
                    {
                        Title ="비밀번호(10자리 이상)",
                        Keyboard = Keyboard.Numeric,
                    }
                    .BackgroundColor(White)
                    .Size(Width,50),

                    new TextField()
                    {
                        Title ="비밀번호 재확인",
                        Keyboard = Keyboard.Numeric,
                    }
                    .BackgroundColor(White)
                    .Size(Width,50),

                    new HStack()
                    {
                        new Label()
                            .FormattedText(
                                    new Span()
                                    {
                                        Text ="년생",
                                        TextColor = Black,
                                        FontFamily="NotoSansKRBold"
                                    },
                                    new Span ()
                                    {
                                        Text = " "
                                    },
                                    new Span()
                                    {
                                        Text = "(선택)",
                                        TextColor = this.ColorHex("bbbee1")
                                    }
                            )
                            .CenterVertical(),
                    }
                ])
                .Spacing(40),

                //new VStack()
                //{
                //    Spacing = 40,
                //    Children =
                //    {
                //        new FreakyTextInputLayout()
                //        {
                //            BorderType = Maui.FreakyControls.Shared.Enums.BorderType.Full,
                //            BorderStroke = new SolidColorBrush(Black),
                //            BorderStrokeThickness =2,
                //            BorderCornerRadius = 5,
                //            Title ="비밀번호(10자리 이상)",
                //            Keyboard = Keyboard.Numeric,
                //        }
                //        .BackgroundColor(White)
                //        .Size(Width,50),

                //        new FreakyTextInputLayout()
                //        {
                //            BorderType = Maui.FreakyControls.Shared.Enums.BorderType.Full,
                //            BorderStroke = new SolidColorBrush(Black),
                //            BorderStrokeThickness =2,
                //            BorderCornerRadius = 5,
                //            Title ="비밀번호 재확인",
                //            Keyboard = Keyboard.Numeric,
                //        }
                //        .BackgroundColor(White)
                //        .Size(Width,50),

                //        new HStack()
                //        {
                //            new Border()
                //            {
                //                Stroke = Black,
                //                StrokeShape = new RoundRectangle()
                //                {
                //                    CornerRadius =3,
                //                    StrokeThickness = 2,
                //                    Stroke = Black,
                //                },
                //                Content = new FreakyEntry()
                //                {
                //                    Placeholder= "●●●●",
                //                    PlaceholderColor= Black
                //                }
                //            }
                //            .Size(60,50),

                //            new Label()
                //                .FormattedText(
                //                      new Span()
                //                      {
                //                          Text ="년생",
                //                          TextColor = Black,
                //                          FontFamily="NotoSansKRBold"
                //                      },
                //                      new Span ()
                //                      {
                //                          Text = " "
                //                      },
                //                      new Span()
                //                      {
                //                          Text = "(선택)",
                //                          TextColor = this.ColorHex("bbbee1")
                //                      }
                //                )
                //                .CenterVertical(),
                //        }
                //    }
                //}
            }
        }
        .Margins (top: 30)
        .Paddings (left: 20, right: 20)
        .Top ();
    }
}
