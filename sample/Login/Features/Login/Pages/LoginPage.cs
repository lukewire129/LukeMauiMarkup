﻿using Login.Features.Common;
using Microsoft.Maui.Controls.Shapes;
using UraniumUI.Material.Controls;

namespace Login.Features.Login.Pages;

public class LoginPage : LukeContentPage
{
    public LoginPage()
    {
        this.BindingContext = new LoginViewModel ();
    }

    public override void Build()
    {
        this.Content (
            new Grid ()
                .RowDefinitions (100, Auto, 55, Auto, 20, Auto)
                .Children (
                    new Grid ()
                        .Row (1)
                        .Children (
                            new TitleLabel ()
                                .Text ("아파트 실거래가는", Color.FromArgb ("#9da2e8"))
                                .Font (size: 30, family: "NotoSansKRRegular")
                                .ZIndex (1)
                                .Margins (top: -100),

                            new TitleLabel ()
                                .Text ("호갱노노", this.ColorHex ("5d66da"))
                                .Font (size: 63, family: "NotoSansKRBold")
                        ),

                    new VStack ()
                        .Row (3)
                        .Spacing (10)
                        .Children (
                            new ButtonView ()
                            {
                                Content = new Grid ()
                                            .Padding (10, 0)
                                            .ColumnDefinitions (Star, Auto, Star)
                                            .Children(
                                                 new HorizontalStackLayout ()
                                                    .Spacing(10)
                                                    .Column (1)
                                                    .Children (
                                                        new Microsoft.Maui.Controls.Shapes.Path ()
                                                        {
                                                            Data = (Geometry)new PathGeometryConverter ().ConvertFromInvariantString ("M255.5 48C299.345 48 339.897 56.5332 377.156 73.5996C414.415 90.666 443.871 113.873 465.522 143.22C487.174 172.566 498 204.577 498 239.252C498 273.926 487.174 305.982 465.522 335.42C443.871 364.857 414.46 388.109 377.291 405.175C340.122 422.241 299.525 430.775 255.5 430.775C241.607 430.775 227.262 429.781 212.467 427.795C148.233 472.402 114.042 494.977 109.892 495.518C107.907 496.241 106.012 496.15 104.208 495.248C103.486 494.706 102.945 493.983 102.584 493.08C102.223 492.177 102.043 491.365 102.043 490.642V489.559C103.126 482.515 111.335 453.169 126.672 401.518C91.8486 384.181 64.1974 361.2 43.7185 332.575C23.2395 303.951 13 272.843 13 239.252C13 204.577 23.8259 172.566 45.4777 143.22C67.1295 113.873 96.5849 90.666 133.844 73.5996C171.103 56.5332 211.655 48 255.5 48Z"),
                                                            Fill = new SolidColorBrush (Black),
                                                            Aspect = Stretch.Fill
                                                        }
                                                        .Start ()
                                                        .Size (29, 29),

                                                        new Label ()
                                                            .CenterVertical ()
                                                            .Text ("카카오로 시작하기", Color.FromArgb ("#191919"))
                                                            .Font (size: 18, family: "NotoSansKRBold")
                                                    )
                                            )
                            }
                            .Size(337, 68)
                            .BorderShape (Corner: 12)
                            .BackgroundColor (Color.FromArgb ("#f9e001")),

                            new Button ()
                                .Size(337, 68)
                                .Border (Width: 1.2, Corner: 12, this.ColorHex ("dcdce4"))
                                .BackgroundColor (Transparent)
                                .Text ("다른 방법으로 시작하기", Color.FromArgb ("#191919"))
                                .Font (size: 18, family: "NotoSansKRBold")
                                .BindCommand (static (LoginViewModel vm) => vm.LoginCommand)
                        ),

                    new HyperLinkLabel ()
                        .Text ("로그인하지 않고 둘러보기")
                        .CenterHorizontal ()
                        .Row (5)
                )
            )
            .BackgroundColor (White);
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