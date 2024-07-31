using MauiIcons.Core;
using MauiIcons.Cupertino;
using Microsoft.Maui.Controls.Shapes;
using System.Text;

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
                        new ButtonLayout()
                        {
                            Children =
                            {
                                new Button()
                                    .Height(66)
                                    .ColumnSpan(2)
                                    .BackgroundColor(this.ColorHex("564ddb"))
                                    .Font("NotoSansKRBold", 18)
                                    .Text("휴대전화/이메일로 시작하기", White)
                                    .BindCommand("GoPhoneEmailLoginCommand"),


                                new MauiIcon()
                                    .Margins(left: 10)
                                    .IconSize(25)
                                    .Icon(CupertinoIcons.Phone)
                                    .IconColor(White)
                                    .Center()
                                    .Column(0)
                            }
                        },

                        new ButtonLayout()
                        {
                            Children =
                            {
                                new Button()
                                    .Height(66)
                                    .ColumnSpan(2)
                                    .BackgroundColor(this.ColorHex("3976ea"))
                                    .Font("NotoSansKRBold", 18)
                                    .Text("페이스북으로 시작하기", White),

                                new Microsoft.Maui.Controls.Shapes.Path()
                                {
                                    Data = (Geometry)new PathGeometryConverter().ConvertFromInvariantString("M12 2.04C6.5 2.04 2 6.53 2 12.06C2 17.06 5.66 21.21 10.44 21.96V14.96H7.9V12.06H10.44V9.85C10.44 7.34 11.93 5.96 14.22 5.96C15.31 5.96 16.45 6.15 16.45 6.15V8.62H15.19C13.95 8.62 13.56 9.39 13.56 10.18V12.06H16.34L15.89 14.96H13.56V21.96A10 10 0 0 0 22 12.06C22 6.53 17.5 2.04 12 2.04Z"),                                    
                                    Fill = new SolidColorBrush(White)
                                }                 
                                .Center()
                                .Column(0)
                            }
                        },

                        new ButtonLayout()
                        {
                            Children =
                            {
                                new Button()
                                    .Height(66)
                                    .ColumnSpan(2)
                                    .BackgroundColor(Colors.White)
                                    .Border(Width:1.2, Corner:5, Color:Colors.Black)
                                    .Font("NotoSansKRBold", 18)
                                    .Text("Apple로 시작하기", Colors.Black),

                               new Microsoft.Maui.Controls.Shapes.Path()
                                {
                                    Data = (Geometry)new PathGeometryConverter().ConvertFromInvariantString("M18.71,19.5C17.88,20.74 17,21.95 15.66,21.97C14.32,22 13.89,21.18 12.37,21.18C10.84,21.18 10.37,21.95 9.1,22C7.79,22.05 6.8,20.68 5.96,19.47C4.25,17 2.94,12.45 4.7,9.39C5.57,7.87 7.13,6.91 8.82,6.88C10.1,6.86 11.32,7.75 12.11,7.75C12.89,7.75 14.37,6.68 15.92,6.84C16.57,6.87 18.39,7.1 19.56,8.82C19.47,8.88 17.39,10.1 17.41,12.63C17.44,15.65 20.06,16.66 20.09,16.67C20.06,16.74 19.67,18.11 18.71,19.5M13,3.5C13.73,2.67 14.94,2.04 15.94,2C16.07,3.17 15.6,4.35 14.9,5.19C14.21,6.04 13.07,6.7 11.95,6.61C11.8,5.46 12.36,4.26 13,3.5Z"),
                                    Fill = new SolidColorBrush(Black)
                                }
                                .Center()
                                .Column(0)
                            }
                        }
                    }
                }
                .Row(2)
            }
        }
        .Height (369)
        .Paddings (left: 20, right: 20, top: 20);
    }
}

public class ButtonLayout : Grid
{
    public ButtonLayout()
    {
        this.ColumnDefinitions = Columns.Define (50, Star);
        this.Paddings (20, 0, 20, 0);
    }
}