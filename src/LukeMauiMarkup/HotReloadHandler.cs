using CommunityToolkit.Maui.Markup;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace LukeMauiMarkup;

public class HotReloadHandler : ICommunityToolkitHotReloadHandler
{
    public async void OnHotReload(IReadOnlyList<Type> types)
    {
        if (Application.Current?.Windows is null)
        {
            Trace.WriteLine ($"{nameof (HotReloadHandler)} Failed: {nameof (Application)}.{nameof (Application.Current)}.{nameof (Application.Current.Windows)} is null");
            return;
        }

        foreach (var window in Application.Current.Windows)
        {
            if (window.Page is not Page currentPage)
            {
                return;
            }

            await currentPage.Dispatcher.DispatchAsync (() =>
            {
                foreach (var type in types)
                {
                    if (type.IsSubclassOf (typeof (Page)) == false)
                        return;

                    if (TryGetModalStackPage (window, out var modalPage))
                    {
                        ((ILukePage)modalPage).Build ();
                    }
                    else if (currentPage is FlyoutPage flyoutPage)
                    { 
                        ((ILukePage)flyoutPage).Build ();
                    }
                    else if (currentPage is TabbedPage tabbedPage)
                    {
                        string[] names = tabbedPage.CurrentPage.ToString ().Split ('.');
                        if (type.Name != names[names.Length - 1])
                        {
                            return;
                        }
                        ((ILukePage)tabbedPage.CurrentPage).Build ();
                    }
                    else if (currentPage is NavigationPage naviPage)
                    {
                        string[] names = naviPage.CurrentPage.ToString ().Split ('.'); 
                        if (type.Name != names[names.Length -1])
                        {
                            return;
                        }
                        ((ILukePage)naviPage.CurrentPage).Build ();
                    }
                    else if (currentPage is ContentPage contentPage)
                    {
                        ((ILukePage)contentPage).Build ();
                    }
                }
            });
        }
    }
    bool TryGetModalStackPage(Window window, [NotNullWhen (true)] out Page? page)
    {
        page = window.Navigation.ModalStack.LastOrDefault ();
        return page is not null;
    }
}
