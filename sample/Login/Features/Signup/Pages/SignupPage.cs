using Login.Features.Signup.Common;
using Maui.FreakyControls;

namespace Login.Features.Signup.Pages;
public class SignupPage : LukeContentPage
{
    public override void Build()
    {
        Title = "일반회원 가입";
        Content = new Grid()
        {
            Children =
            {
                new VStack ()
                {
                    Spacing = 20,
                    Children =
                    {
                        new FreakyTextInputLayout()
                        {
                            BorderType = Maui.FreakyControls.Shared.Enums.BorderType.Full,
                            BorderStroke = new SolidColorBrush(Black),
                            BorderStrokeThickness =2,
                            BorderCornerRadius = 5,
                            Title ="휴대전화번호",
                            Keyboard = Keyboard.Numeric
                        }
                        .BackgroundColor(White)
                        .Size(Width,50),

                        new Label()
                            .Text("휴대전화 인증이 필요합니다. 휴대전화번호는 외부에 노출하지 않습니다.")
                    }
                }
                .Margins(top: 30)
                .Paddings (left: 20, right: 20)
                .Top(),

                new Button()
                    .Border(Corner:0)
                    .Text("인증번호받기")
                    .Height(60)
                    .Bottom()
            }
        };
    }

    protected override bool OnBackButtonPressed()
    {
        ((SingupBaseViewModel)this.BindingContext).PreNextStep ();
        return base.OnBackButtonPressed ();
    }
}
