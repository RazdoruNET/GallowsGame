using Microsoft.AspNetCore.Mvc;

namespace GallowsGame.Views.Shared.Components.BadBoy;

public class BadBoyViewComponent : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync(bool active = false)
    {
        return View(active);
    }
}