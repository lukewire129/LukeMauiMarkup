using Login.Features.Common;
using UraniumUI.Material.Controls;

namespace Login.Features.Login.Pages;

public class LoginPhoneEmailPage : LukeContentPage
{
    public override void Build()
    {
        this.Title("휴대전화번호 / 이메일 로그인")
            .Content (
                new VStack ()
                    .Width (this.Width)
                    .BackgroundColor (White)
                    .Margins (top: 30)
                    .Paddings (left: 20, right: 20)
                    .Spacing(40)
                    .Children (
                        new TextField ()
                        {
                            Title = "휴대전화번호 또는 이메일"
                        }
                        .BackgroundColor (White)
                        .Size (this.Width, 50),

                        new TextField ()
                        {
                            Title = "비밀번호",
                            IsPassword = true
                        }
                        .BackgroundColor (White)
                        .Size (this.Width, 50),

                        new Grid ()
                            .Children (
                                 new HyperLinkLabel ()
                                    .Text ("회원가입")
                                    .BindTapGesture ("SignUpCommand")
                                    .Start (),

                                new HyperLinkLabel ()
                                    .Text ("비밀번호 찾기")
                                    .BindTapGesture ("ForgetPasswordCommand")
                                    .End ()
                            )
                    )
        );
    }
}
