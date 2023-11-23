﻿using LukeMauiMarkup.Init.Views;

namespace LukeMauiMarkup.Init
{
    public partial class App : Application
    {
        public App(IServiceProvider services)
        {
            Resources.MergedDictionaries.Add (AppColors.Instance);
            Resources.MergedDictionaries.Add (AppStyles.Instance);
            Resources.Add ("ApplePadding", new Thickness (30, 60, 30, 30));
            Resources.Add ("DefaultPadding", new Thickness (30));
            Resources.Add ("ItemSpacing", 10d);
            Resources.Add (new Style (typeof (StackBase))
            {
                ApplyToDerivedTypes = true,
                Setters =
                {
                    new() { Property = StackBase.SpacingProperty, Value = AppResource<double>("ItemSpacing") },
                },
            });
            Resources.Add ("MauiLabel", new Style (typeof (Label))
            {
                Setters =
                {
                    new() { Property = Label.TextColorProperty, Value = RequestedTheme switch { AppTheme.Dark => AppColor("White"), AppTheme.Light or _ => AppColor("Primary") } },
                },
            });
            Resources.Add ("Action", new Style (typeof (Button))
            {
                Setters =
                {
                    new() { Property = Button.BackgroundColorProperty, Value = RequestedTheme switch { AppTheme.Dark => AppColor("BackgroundDark"), AppTheme.Light or _ => AppColor("BackgroundLight") } },
                    new() { Property = Button.TextColorProperty, Value = RequestedTheme switch { AppTheme.Dark => AppColor("TextDark"), AppTheme.Light or _ => AppColor("TextLight") } },
                    new() { Property = Button.FontFamilyProperty, Value = AppResource<string>("AppFont") },
                    new() { Property = Button.FontSizeProperty, Value = AppResource<double>("AppFontSize") },
                    new() { Property = Button.PaddingProperty, Value = new Thickness(14,10) },
                },
            });
            Resources.Add ("PrimaryAction", new Style (typeof (Button))
            {
                BasedOn = (Style)Resources["Action"],
                Setters =
                {
                    new() { Property = Button.BackgroundColorProperty, Value = AppColor("Primary") },
                    new() { Property = Button.FontAttributesProperty, Value = FontAttributes.Bold },
                    new() { Property = Button.TextColorProperty, Value = AppColor("White") },
                },
            });

            MainPage = services.GetService<MainPage> ();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow (activationState);
            window.Title = "LukeMauiMarkup.Init";
            return window;
        }
    }
}
