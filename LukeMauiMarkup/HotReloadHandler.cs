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
                    await currentPage.Dispatcher.DispatchAsync (async () =>
                    {
                        ((LukeContentPage)currentPage).Build ();
                    });
                }
            }
        }
    }
}
