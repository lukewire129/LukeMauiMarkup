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

            foreach (var type in types)
            {
                if (type.IsSubclassOf (typeof (Page)))
                {
                    if (TryGetModalStackPage (window, out var modalPage))
                    {
                        await currentPage.Dispatcher.DispatchAsync (async () =>
                        {
                            await currentPage.Navigation.PopModalAsync (false);
                            await currentPage.Navigation.PushModalAsync (modalPage, false);
                        });

                        return;
                    }

                    await currentPage.Dispatcher.DispatchAsync (async () =>
                    {
                        var navi = (NavigationPage)currentPage;
                        ((LukeContentPage)navi.CurrentPage).Build ();
                    });
                }
            }
        }
    }
    bool TryGetModalStackPage(Window window, [NotNullWhen (true)] out Page? page)
    {
        page = window.Navigation.ModalStack.LastOrDefault ();
        return page is not null;
    }
}
