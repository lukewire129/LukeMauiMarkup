using Login.Features.Signup.Common;
using UraniumUI.Material.Controls;

namespace Login.Features.Signup.Pages;
public class SignupPage : LukeContentPage
{
    public override void Build()
    {
        Title = "일반회원 가입";
        Content = new Grid ()
        {
            Children =
            {
                new VStack ()
                {
                    Spacing = 40,
                    Children =
                    {
                        new TextField()
                        {
                            Title ="휴대전화번호",
                            Keyboard = Keyboard.Numeric,
                        }
                        .BackgroundColor(White)
                        .Size(Width,50)
                        .Bind(TextField.TextProperty, static (SignupViewModel vm) => vm.PhoneNumber, // getter
                                                                  static (SignupViewModel vm, string value) => vm.PhoneNumber = value) // setter
                        .Bind(TextField.IsEnabledProperty, static (SignupViewModel vm) => vm.IsRequestPhoneNumber,
                                                                       static (SignupViewModel vm, bool value) => vm.IsRequestPhoneNumber = value),

                        new TextField()
                        {
                            Title ="인증번호",
                            Keyboard = Keyboard.Numeric
                        }
                        .BackgroundColor(White)
                        .Size(Width,50)
                        .Bind(TextField.TextProperty, static (SignupViewModel vm) => vm.AuthNumber, // getter
                                                                  static (SignupViewModel vm, string value) => vm.AuthNumber = value) // setter
                        .Bind(TextField.IsVisibleProperty, static (SignupViewModel vm) => vm.IsRequestAuthNumber,
                                                                       static (SignupViewModel vm, bool value) => vm.IsRequestAuthNumber = value),

                        new Label()
                            .Text("휴대전화 인증이 필요합니다. 휴대전화번호는 외부에 노출하지 않습니다.")
                    }
                }
                .Margins(top: 30)
                .Paddings (left: 20, right: 20)
                .Top(),

                new Button()
                    .Border(Corner:0)
                    .Height(60)
                    .Bottom()
                    .Font("")
                    .BindCommand("RequestAuthCommand")
                    .Bind(Button.TextProperty, static (SignupViewModel vm) => vm.AuthButtonName, // getter
                                               static (SignupViewModel vm, string value) => vm.AuthButtonName = value) // setter,
                    .Bind(Button.IsEnabledProperty, static (SignupViewModel vm) => vm.IsRequestButtonEnabled, // getter
                                                    static (SignupViewModel vm, bool value) => vm.IsRequestButtonEnabled = value) // setter,
            }
        };
    }

    protected override bool OnBackButtonPressed()
    {
        ((SingupBaseViewModel)this.BindingContext).PreNextStep ();
        return base.OnBackButtonPressed ();
    }
}
