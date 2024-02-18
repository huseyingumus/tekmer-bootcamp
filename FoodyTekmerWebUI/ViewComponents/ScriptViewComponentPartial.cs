
using Microsoft.AspNetCore.Mvc;
namespace FoodyTekmerWebUI.ViewComponents

{
    public class ScriptViewComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
}
