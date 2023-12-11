namespace Login.Features.Common;
public class PageContainer
{
    private readonly LukeContentPage page;
    private readonly LukeViewModel vm;

    public PageContainer(LukeContentPage page,
                         LukeViewModel vm)
    {
        this.page = page;
        this.vm = vm;


        this.page.BindingContext = vm;
    }

    public LukeContentPage Page => page;
}
