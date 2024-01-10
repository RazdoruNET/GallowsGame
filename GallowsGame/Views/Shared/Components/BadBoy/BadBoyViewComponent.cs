using GallowsGame.Models.Enum;
using Microsoft.AspNetCore.Mvc;

namespace GallowsGame.Views.Shared.Components.BadBoy;

public class BadBoyViewComponent : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync(BadBoyStatusEnum active = BadBoyStatusEnum.Init)
    {
        return View(active);
    }
}