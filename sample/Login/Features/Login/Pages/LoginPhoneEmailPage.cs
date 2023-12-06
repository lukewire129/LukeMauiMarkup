using Login.Features.Common;
using Maui.FreakyControls;

namespace Login.Features.Login.Pages;

public class LoginPhoneEmailPage : LukeContentPage
{
    public override void Build()
    {
        this.Title = "휴대전화번호 / 이메일 로그인";
        this.Content = new VStack ()
        {
            Spacing = 40,
            Children =
            {
                new FreakyTextInputLayout()
                {
                    BorderType = Maui.FreakyControls.Shared.Enums.BorderType.Full,
                    BorderStroke = new SolidColorBrush(Black),
                    BorderStrokeThickness =2,
                    BorderCornerRadius = 5,
                    Title ="휴대전화번호 또는 이메일"
                }
                .BackgroundColor(White)
                .Size(this.Width,50),

                new FreakyTextInputLayout()
                {
                    BorderType = Maui.FreakyControls.Shared.Enums.BorderType.Full,
                    BorderStroke = new SolidColorBrush(Black),
                    BorderStrokeThickness =2,
                    BorderCornerRadius = 5,
                    Title ="비밀번호",
                    IsPassword = true
                }
                .BackgroundColor(White)
                .Size(this.Width,50),

                new Grid()
                {
                    Children =
                    {
                        new HyperLinkLabel()
                            .Text("회원가입")
                            .BindTapGesture("SignUpCommand")
                            .Start(),

                        new HyperLinkLabel()
                            .Text("비밀번호 찾기")
                            .BindTapGesture("ForgetPasswordCommand")
                            .End()
                    }
                }
            }
        }
        .Width (this.Width)
        .BackgroundColor (White)
        .Margins(top:30)
        .Paddings(left: 20, right:20);
    }
}
